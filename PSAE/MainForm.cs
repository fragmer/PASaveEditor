using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PASaveEditor.FileModel;
using PASaveEditor.Properties;

namespace PASaveEditor {
    public partial class MainForm : Form {
        const string FileFilter = "Prison Architect saves (*.prison)|*.prison|All Files (*.*)|*.*";
        const string AppName = "Prison Architect Save Editor | " + Parser.SupportedVersion;
        string fileName;
        Prison prison;
        string[] prisonerNames;
        Prisoner selectedPrisoner;

        readonly OpenFileDialog openDialog;
        readonly SaveFileDialog saveAsDialog;
        readonly ToolTip toolTips;


        public MainForm() {
            InitializeComponent();
            toolTips = new ToolTip();
            tPrisonerSearch.SetWatermark("Search");

            AssignTooltips();

            string paSavePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Introversion", "Prison Architect", "saves");

            openDialog = new OpenFileDialog {
                Filter = FileFilter,
                InitialDirectory = paSavePath
            };
            saveAsDialog = new SaveFileDialog {
                Filter = FileFilter,
                InitialDirectory = paSavePath
            };

            miEliminateProtected.Click += delegate { Eliminate("Protected"); };
            miEliminateMinSec.Click += delegate { Eliminate("MinSec"); };
            miEliminateNormal.Click += delegate { Eliminate("Normal"); };
            miEliminateMaxSec.Click += delegate { Eliminate("MaxSec"); };
            miEliminateSuperMax.Click += delegate { Eliminate("SuperMax"); };
            miEliminateDeathRow.Click += delegate { Eliminate("DeathRow"); };
            miEliminateAll.Click += delegate { EliminateAll(); };

            miReleaseProtected.Click += delegate { Release("Protected"); };
            miReleaseMinSec.Click += delegate { Release("MinSec"); };
            miReleaseNormal.Click += delegate { Release("Normal"); };
            miReleaseMaxSec.Click += delegate { Release("MaxSec"); };
            miReleaseSuperMax.Click += delegate { Release("SuperMax"); };
            miReleaseDeathRow.Click += delegate { Release("DeathRow"); };
            miReleaseAll.Click += delegate { ReleaseAll(); };

            miExit.Click += delegate { Close(); };

            Shown += delegate { miFileOpen.PerformClick(); };

            // Disable the GUI until a prison file is loaded
            Enabled = false;
        }


        void AssignTooltips() {
            toolTips.SetToolTip(xContinuousIntake, Resources.TipContinuousIntake);
            toolTips.SetToolTip(xDecay, Resources.TipDecay);
            toolTips.SetToolTip(xFailureConditions, Resources.TipFailureConditions);
            toolTips.SetToolTip(xFogOfWar, Resources.TipFogOfWar);
            toolTips.SetToolTip(xMisconduct, Resources.TipMisconduct);
        }


        // Tracks selected prisoner on the "Prisoners" tab.
        // GUI is automatically updated (or disabled) when this property is set.
        Prisoner SelectedPrisoner {
            get { return selectedPrisoner; }
            set {
                selectedPrisoner = value;
                if (value == null) {
                    tName.Text = "";
                    tSurname.Text = "";
                    cCategory.SelectedIndex = -1;
                    lServedStats.Text = "";
                    tName.Enabled = false;
                    tSurname.Enabled = false;
                    cCategory.Enabled = false;
                    pbServed.Value = 0;
                    bEliminate.Enabled = false;
                    bRelease.Enabled = false;
                } else {
                    tName.Enabled = true;
                    tSurname.Enabled = true;
                    cCategory.Enabled = true;
                    bEliminate.Enabled = true;
                    PrisonerBio bio = selectedPrisoner.Bio;
                    tName.Text = bio.Forname;
                    tSurname.Text = bio.Surname;
                    cCategory.SelectedIndex = PrisonerUtil.CategoryNameToIndex(selectedPrisoner.Category);
                    pbServed.Value = (int)Math.Min(Math.Round(bio.Served * 100d / bio.Sentence), 100);
                    lServedStats.Text = String.Format("{0:0.#} of {1} years", bio.Served, bio.Sentence);
                    bRelease.Enabled = (bio.Served < bio.Sentence);
                }
            }
        }


        // Update counts in the menu items under "Eliminate prisoners" shortcut menu.
        // If there are no prisoners to release in this category, option is grayed out.
        void UpdatePrisonerCounts() {
            // Count all Protective Custody prisoners
            UpdatePrisonerCategoryItem(miEliminateProtected, miReleaseProtected, "Protected", "Protective Custody");
            UpdatePrisonerCategoryItem(miEliminateMinSec, miReleaseMinSec, "MinSec", "Minimum Security");
            UpdatePrisonerCategoryItem(miEliminateNormal, miReleaseNormal, "Normal", "Normal Security");
            UpdatePrisonerCategoryItem(miEliminateMaxSec, miReleaseMaxSec, "MaxSec", "Maximum Security");
            UpdatePrisonerCategoryItem(miEliminateSuperMax, miReleaseSuperMax, "SuperMax", "SuperMax");
            UpdatePrisonerCategoryItem(miEliminateDeathRow, miReleaseDeathRow, "DeathRow", "Death Row");
            
            UpdatePrisonerCategoryItem(miEliminateAll, miReleaseAll, null, "All");

            int hiddenReputations =
                prison.Objects.Prisoners.Values
                      .Count(p => p.Bio.Reputations != null && !p.Bio.ReputationRevealed);
            miRevealReputations.Text = String.Format("Reveal reputations ({0})", hiddenReputations);
            miRevealReputations.Enabled = (hiddenReputations > 0);
        }


        void UpdatePrisonerCategoryItem(ToolStripMenuItem miEliminate, ToolStripMenuItem miRelease,
                                        string categoryName, string label) {
            int allCount;
            if (categoryName == null) {
                allCount = prison.Objects.Prisoners.Count;
            } else {
                allCount = PrisonerUtil.CountPrisoners(prison, p => p.Category == categoryName);
            }
            miEliminate.Text = String.Format("{0} ({1})", label, allCount);
            miEliminate.Enabled = (allCount > 0);

            int nonReleasedCount;

            if (categoryName == null) {
                nonReleasedCount = PrisonerUtil.CountPrisoners(prison, p => p.Bio.Served < p.Bio.Sentence);
            } else {
                nonReleasedCount =
                    PrisonerUtil.CountPrisoners(prison,
                                                p => p.Category == categoryName &&
                                                     p.Bio.Served < p.Bio.Sentence);
            }
            miRelease.Text = String.Format("{0} ({1})", label, nonReleasedCount);
            miRelease.Enabled = (nonReleasedCount > 0);
        }


        // Updates list on the "Prisoners" tab. Resets SelectedPrisoner.
        void UpdatePrisoners() {
            lbPrisoners.Items.Clear();
            prisonerNames = prison.Objects.Prisoners.Values
                                  .Select(PrisonerUtil.NamePrisoner)
                                  .ToArray();
            lbPrisoners.Items.AddRange(prisonerNames);
            if (!prison.Objects.Prisoners.Values.Contains(selectedPrisoner)) {
                SelectedPrisoner = null;
            }
            UpdatePrisonerCounts();
        }


        void lbPrisoners_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedPrisoner = prison.Objects.Prisoners.Values.ToArray()[lbPrisoners.SelectedIndex];
        }


        static bool ContainsIgnoreCase(string haystack, string needle) {
            return CultureInfo.InvariantCulture.CompareInfo
                              .IndexOf(haystack, needle, CompareOptions.IgnoreCase) >= 0;
        }


        void tPrisonerSearch_TextChanged(object sender, EventArgs e) {
            lbPrisoners.Items.Clear();
            lbPrisoners.Items.AddRange(
                prisonerNames.Where(name => ContainsIgnoreCase(name, tPrisonerSearch.Text)).ToArray());
        }


        void tName_TextChanged(object sender, EventArgs e) {
            if (SelectedPrisoner != null) {
                SelectedPrisoner.Bio.Forname = tName.Text;
            }
        }


        void tSurname_TextChanged(object sender, EventArgs e) {
            if (SelectedPrisoner != null) {
                SelectedPrisoner.Bio.Surname = tSurname.Text;
            }
        }


        void cCategory_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectedPrisoner != null) {
                SelectedPrisoner.Category = PrisonerUtil.CategoryIndexToName(cCategory.SelectedIndex);
            }
        }


        void bEliminate_Click(object sender, EventArgs e) {
            PrisonerUtil.EliminatePrisoner(prison, SelectedPrisoner.Id);
            SelectedPrisoner = null;
            UpdatePrisoners();
        }


        void miAbout_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog(this);
        }


        #region Shortcuts

        void miRemoveAllTrees_Click(object sender, EventArgs e) {
            var idsToRemove = prison.Objects.OtherObjects
                                    .Values
                                    .Where(obj => obj.Type == "Tree")
                                    .Select(obj => obj.Id)
                                    .ToList();

            idsToRemove.ForEach(id => prison.Objects.OtherObjects.Remove(id));

            MessageBox.Show(String.Format("{0} trees removed.", idsToRemove.Count));
            miRemoveAllTrees.Text = "Remove all trees (0)";
            miRemoveAllTrees.Enabled = false;
        }


        void miUnlockAllResearch_Click(object sender, EventArgs e) {
            for (int i = 0; i < clbResearch.Items.Count; i++) {
                clbResearch.SetItemChecked(i, true);
            }
            MessageBox.Show("All research unlocked!");
        }


        int CountContraband() {
            Node trackers = prison.Contraband.TryGetNode("Trackers");
            if (trackers == null) return 0;
            string sizeStr = trackers.TryGetProperty("Size");
            if (sizeStr == null) return 0;
            return Int32.Parse(sizeStr);
        }


        void miRemoveAllContraband_Click(object sender, EventArgs e) {
            prison.Contraband.Child.Prisoners.Clear();
            int numRemoved = CountContraband();
            prison.Contraband.Nodes.Remove("Trackers");
            MessageBox.Show(String.Format("{0} pieces of contraband removed!", numRemoved));
            miRemoveAllContraband.Text = "Remove all contraband (0)";
            miRemoveAllContraband.Enabled = false;
        }


        void miRevealReputations_Click(object sender, EventArgs e) {
            var toReveal =
                prison.Objects.Prisoners.Values
                      .Where(p => p.Bio.Reputations != null && !p.Bio.ReputationRevealed)
                      .ToList();

            toReveal.ForEach(p => p.Bio.ReputationRevealed = true);
            MessageBox.Show(String.Format("{0} prisoner reputations revealed.", toReveal.Count));
            UpdatePrisonerCounts();
        }


        void EliminateAll() {
            int released = PrisonerUtil.Eliminate(prison, prisoner => true);
            MessageBox.Show(String.Format("All {0} prisoners eliminated.", released));
            UpdatePrisoners();
        }


        void Eliminate(string categoryName) {
            string groupLabel = PrisonerUtil.InternalToInGameCatName(categoryName);
            int released = PrisonerUtil.Eliminate(prison, prisoner => prisoner.Category == categoryName);
            MessageBox.Show(String.Format("{0} {1} prisoners eliminated.", released, groupLabel));
            UpdatePrisoners();
        }


        void ReleaseAll() {
            int released = PrisonerUtil.Release(prison, prisoner => true);
            MessageBox.Show(String.Format("All {0} prisoners scheduled for release.", released));
            UpdatePrisoners();
        }


        void Release(string categoryName) {
            string groupLabel = PrisonerUtil.InternalToInGameCatName(categoryName);
            int released = PrisonerUtil.Release(prison, prisoner => prisoner.Category == categoryName);
            MessageBox.Show(String.Format("{0} {1} prisoners scheduled for release.", released, groupLabel));
            UpdatePrisoners();
        }


        void miRemoveTunnels_Click(object sender, EventArgs e) {
            var cellLabels = prison.Tunnels.Nodes.Keys.Where(Pos.IsPos).ToList();
            cellLabels.ForEach(label => prison.Tunnels.Nodes.Remove(label));
            prison.Tunnels.Diggers.Prisoners.Clear();
            prison.Tunnels.Nodes.Remove("Rooms");
        }


        void bRelease_Click(object sender, EventArgs e) {
            PrisonerUtil.ReleasePrisoner(prison, selectedPrisoner.Id);
            pbServed.Value = 100;
            PrisonerBio bio = selectedPrisoner.Bio;
            lServedStats.Text = String.Format("{0:0.#} of {1} years", bio.Served, bio.Sentence);
            bRelease.Enabled = false;
        }

        #endregion


        #region Loading / Saving

        void miFileOpen_Click(object sender, EventArgs e) {
            if (openDialog.ShowDialog() == DialogResult.OK) {
                fileName = openDialog.FileName;
                using (FileStream fs = File.OpenRead(openDialog.FileName)) {
                    Text = String.Format("Loading {0} | {1}", Path.GetFileName(fileName), AppName);
                    try {
                        prison = new Parser().Load(fs);
                    } catch (Exception ex) {
                        string msg = String.Format("An error occured while loading:{0}{1}{0}{2}",
                                                   Environment.NewLine, ex.GetType().Name, ex.Message);
                        MessageBox.Show(msg, String.Format("Error loading {0}", Path.GetFileName(fileName)),
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    if (prison.Version != Parser.SupportedVersion) {
                        MessageBox.Show(String.Format(Resources.FileVersionWarning, Parser.SupportedVersion,
                                                      prison.Version));
                    }
                    LoadPrisonToGui();
                    Enabled = true;
                    Text = String.Format("{0} | {1}", Path.GetFileName(fileName), AppName);
                }
            } else {
                if (prison == null) {
                    Close();
                }
            }
        }


        void LoadPrisonToGui() {
            // Load general tab
            nDay.Value = TimeConversion.IndexToDay(prison.TimeIndex);
            tTime.Text = String.Format("{0:00}:{1:00}",
                                       TimeConversion.IndexTo12Hour(prison.TimeIndex),
                                       TimeConversion.IndexToMinute(prison.TimeIndex));
            cAmPm.SelectedIndex = (TimeConversion.IsPm(prison.TimeIndex) ? 1 : 0);

            xMisconduct.Checked = prison.EnabledMisconduct;
            xContinuousIntake.Checked = prison.EnabledIntake;
            xFogOfWar.Checked = prison.EnabledVisibility;
            xFailureConditions.Checked = prison.FailureConditions;
            xDecay.Checked = prison.EnabledDecay;

            // Load finances tab
            xUnlimitedFunds.Checked = prison.UnlimitedFunds;
            nBalance.Value = prison.Finance.Balance;
            nBankLoanAmount.Value = prison.Finance.BankLoan;
            nCreditRating.Value = Convert.ToDecimal(prison.Finance.BankCreditRating*100);
            nOwnership.Value = Convert.ToDecimal(prison.Finance.Ownership);

            // Load prisoners tab
            UpdatePrisoners();
            SelectedPrisoner = null;

            // Load research tab
            clbResearch.Items.Clear();
            clbResearch.Items.AddRange(ResearchData.GetInGameNames());
            if (prison.Research != null) {
                foreach (ResearchItem item in prison.Research.Items) {
                    if (item.Label == "None") continue;
                    int idx = ResearchData.GetIndex(item.Label);
                    if (idx < 0) {
                        idx = ResearchData.AddItem(item.Label);
                        clbResearch.Items.Add(item.Label);
                    }
                    if (item.Progress > .999) {
                        clbResearch.SetItemChecked(idx, true);
                    }
                }
            }

            int numContraband = CountContraband();
            miRemoveAllContraband.Text = String.Format("Remove all contraband ({0})", numContraband);
            miRemoveAllContraband.Enabled = (numContraband > 0);

            int numTrees = prison.Objects.OtherObjects
                                 .Values .Count(obj => obj.Type == "Tree");
            miRemoveAllTrees.Text = String.Format("Remove all trees ({0})", numTrees);
            miRemoveAllTrees.Enabled = (numTrees > 0);
        }


        void miFileSaveAs_Click(object sender, EventArgs e) {
            if (saveAsDialog.ShowDialog() == DialogResult.OK) {
                string newFileName = saveAsDialog.FileName;
                if (File.Exists(newFileName) && !PromptToReplace(newFileName)) {
                    return;
                }
                Save(newFileName);
                fileName = newFileName;
            }
        }


        void miFileSave_Click(object sender, EventArgs e) {
            if (PromptToReplace(fileName)) {
                Save(fileName);
            }
        }


        bool PromptToReplace(string file) {
            string msg = String.Format("Are you sure you want to overwrite {0}?",
                                       Path.GetFileName(file));
            return MessageBox.Show(msg, "Saving", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }


        void Save(string newFileName) {
            Enabled = false;
            Text = String.Format("Saving {0} | {1}", Path.GetFileName(newFileName), AppName);
            SaveGuiToPrison();

            string tempFileName = Path.GetTempFileName();
            using (FileStream fs = File.Create(tempFileName)) {
                using (var writer = new Writer(fs)) {
                    writer.WritePrison(prison);
                }
            }
            if (File.Exists(newFileName)) {
                File.Replace(tempFileName, newFileName, newFileName + ".bak");
            } else {
                File.Move(tempFileName, newFileName);
            }

            Text = String.Format("{0} | {1}", Path.GetFileName(fileName), AppName);
            Enabled = true;
        }


        void SaveGuiToPrison() {
            // Store general tab
            prison.TimeIndex = TimeConversion.ToIndex(
                Convert.ToInt32(nDay.Value), tTime.Text, cAmPm.SelectedIndex == 1);

            prison.EnabledMisconduct = xMisconduct.Checked;
            prison.EnabledIntake = xContinuousIntake.Checked;
            prison.EnabledVisibility = xFogOfWar.Checked;
            prison.FailureConditions = xFailureConditions.Checked;
            prison.EnabledDecay = xDecay.Checked;

            // Store finances tab
            prison.UnlimitedFunds = xUnlimitedFunds.Checked;
            prison.Finance.Balance = Convert.ToInt32(nBalance.Value);
            prison.Finance.BankLoan = Convert.ToInt32(nBankLoanAmount.Value);
            prison.Finance.BankCreditRating = Convert.ToDouble(nCreditRating.Value)/100;
            prison.Finance.Ownership = Convert.ToInt32(nOwnership.Value);

            // Prisoner tab is continuously saved already

            // Store research tab
            foreach (string itemName in ResearchData.AllResearch) {
                if (itemName == "None") continue;
                int idx = ResearchData.GetIndex(itemName);
                bool isUnlocked = clbResearch.GetItemChecked(idx);
                if (isUnlocked) {
                    prison.Research.Unlock(itemName);
                } else {
                    prison.Research.Lock(itemName);
                }
            }
        }

        #endregion

        private void moveToPercentage_Click(object sender, EventArgs e)
        {
            if(SelectedPrisoner != null) // not possible but good to check
            {
                selectedPrisoner.Bio.Served = selectedPrisoner.Bio.Sentence * (.95);
                SelectedPrisoner = null;
                UpdatePrisoners();
            }
        }
    }
}
