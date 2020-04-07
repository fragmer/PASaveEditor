namespace PASaveEditor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label lOwnershipUnits;
            System.Windows.Forms.Label lBankLoanAmontUnits;
            System.Windows.Forms.Label lBankLoanAmount;
            System.Windows.Forms.Label lCreditRating;
            System.Windows.Forms.Label lOwnership;
            System.Windows.Forms.Label lBalance;
            System.Windows.Forms.Label lBalanceUnits;
            System.Windows.Forms.ToolStripSeparator sReleasePrisonersSeparator;
            System.Windows.Forms.Label lSurname;
            System.Windows.Forms.Label lName;
            System.Windows.Forms.Label lCategory;
            System.Windows.Forms.Label lDisclaimer;
            System.Windows.Forms.ToolStripSeparator sFileSeparator1;
            System.Windows.Forms.ToolStripSeparator sFileSeparator2;
            System.Windows.Forms.ToolStripSeparator sShortcutsSeparator;
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xDecay = new System.Windows.Forms.CheckBox();
            this.xMisconduct = new System.Windows.Forms.CheckBox();
            this.xFogOfWar = new System.Windows.Forms.CheckBox();
            this.xFailureConditions = new System.Windows.Forms.CheckBox();
            this.xContinuousIntake = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cAmPm = new System.Windows.Forms.ComboBox();
            this.tTime = new System.Windows.Forms.MaskedTextBox();
            this.nDay = new System.Windows.Forms.NumericUpDown();
            this.lDay = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.tpFinance = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.nOwnership = new System.Windows.Forms.NumericUpDown();
            this.xUnlimitedFunds = new System.Windows.Forms.CheckBox();
            this.nBankLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.nCreditRating = new System.Windows.Forms.NumericUpDown();
            this.nBalance = new System.Windows.Forms.NumericUpDown();
            this.tpPrisoners = new System.Windows.Forms.TabPage();
            this.m_BodyType = new System.Windows.Forms.TextBox();
            this.m_Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveToPercentage = new System.Windows.Forms.Button();
            this.bRelease = new System.Windows.Forms.Button();
            this.lServedStats = new System.Windows.Forms.Label();
            this.lServed = new System.Windows.Forms.Label();
            this.pbServed = new System.Windows.Forms.ProgressBar();
            this.cCategory = new System.Windows.Forms.ComboBox();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.bEliminate = new System.Windows.Forms.Button();
            this.tPrisonerSearch = new System.Windows.Forms.TextBox();
            this.lbPrisoners = new System.Windows.Forms.ListBox();
            this.tpResearch = new System.Windows.Forms.TabPage();
            this.clbResearch = new System.Windows.Forms.CheckedListBox();
            this.Gang = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleasePrisoners = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseInsane = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseProtected = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseMinSec = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseMaxSec = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseSuperMax = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseDeathRow = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminatePrisoners = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateInsane = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateProtected = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateMinSec = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateMaxSec = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateSuperMax = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminateDeathRow = new System.Windows.Forms.ToolStripMenuItem();
            this.sEliminatePrisonersSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miEliminateAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miRevealReputations = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnlockAllResearch = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveAllTrees = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveTunnels = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveAllContraband = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            lOwnershipUnits = new System.Windows.Forms.Label();
            lBankLoanAmontUnits = new System.Windows.Forms.Label();
            lBankLoanAmount = new System.Windows.Forms.Label();
            lCreditRating = new System.Windows.Forms.Label();
            lOwnership = new System.Windows.Forms.Label();
            lBalance = new System.Windows.Forms.Label();
            lBalanceUnits = new System.Windows.Forms.Label();
            sReleasePrisonersSeparator = new System.Windows.Forms.ToolStripSeparator();
            lSurname = new System.Windows.Forms.Label();
            lName = new System.Windows.Forms.Label();
            lCategory = new System.Windows.Forms.Label();
            lDisclaimer = new System.Windows.Forms.Label();
            sFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            sFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            sShortcutsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tabs.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).BeginInit();
            this.tpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOwnership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBankLoanAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCreditRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).BeginInit();
            this.tpPrisoners.SuspendLayout();
            this.tpResearch.SuspendLayout();
            this.Gang.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOwnershipUnits
            // 
            lOwnershipUnits.AutoSize = true;
            lOwnershipUnits.Location = new System.Drawing.Point(169, 121);
            lOwnershipUnits.Name = "lOwnershipUnits";
            lOwnershipUnits.Size = new System.Drawing.Size(15, 13);
            lOwnershipUnits.TabIndex = 15;
            lOwnershipUnits.Text = "%";
            // 
            // lBankLoanAmontUnits
            // 
            lBankLoanAmontUnits.AutoSize = true;
            lBankLoanAmontUnits.Location = new System.Drawing.Point(191, 69);
            lBankLoanAmontUnits.Name = "lBankLoanAmontUnits";
            lBankLoanAmontUnits.Size = new System.Drawing.Size(13, 13);
            lBankLoanAmontUnits.TabIndex = 13;
            lBankLoanAmontUnits.Text = "$";
            // 
            // lBankLoanAmount
            // 
            lBankLoanAmount.AutoSize = true;
            lBankLoanAmount.Location = new System.Drawing.Point(11, 69);
            lBankLoanAmount.Name = "lBankLoanAmount";
            lBankLoanAmount.Size = new System.Drawing.Size(93, 13);
            lBankLoanAmount.TabIndex = 5;
            lBankLoanAmount.Text = "Bank loan amount";
            // 
            // lCreditRating
            // 
            lCreditRating.AutoSize = true;
            lCreditRating.Location = new System.Drawing.Point(41, 95);
            lCreditRating.Name = "lCreditRating";
            lCreditRating.Size = new System.Drawing.Size(63, 13);
            lCreditRating.TabIndex = 4;
            lCreditRating.Text = "Credit rating";
            // 
            // lOwnership
            // 
            lOwnership.AutoSize = true;
            lOwnership.Location = new System.Drawing.Point(47, 121);
            lOwnership.Name = "lOwnership";
            lOwnership.Size = new System.Drawing.Size(57, 13);
            lOwnership.TabIndex = 6;
            lOwnership.Text = "Ownership";
            // 
            // lBalance
            // 
            lBalance.AutoSize = true;
            lBalance.Location = new System.Drawing.Point(58, 43);
            lBalance.Name = "lBalance";
            lBalance.Size = new System.Drawing.Size(46, 13);
            lBalance.TabIndex = 3;
            lBalance.Text = "Balance";
            // 
            // lBalanceUnits
            // 
            lBalanceUnits.AutoSize = true;
            lBalanceUnits.Location = new System.Drawing.Point(191, 43);
            lBalanceUnits.Name = "lBalanceUnits";
            lBalanceUnits.Size = new System.Drawing.Size(13, 13);
            lBalanceUnits.TabIndex = 9;
            lBalanceUnits.Text = "$";
            // 
            // sReleasePrisonersSeparator
            // 
            sReleasePrisonersSeparator.Name = "sReleasePrisonersSeparator";
            sReleasePrisonersSeparator.Size = new System.Drawing.Size(171, 6);
            // 
            // lSurname
            // 
            lSurname.AutoSize = true;
            lSurname.Location = new System.Drawing.Point(143, 58);
            lSurname.Name = "lSurname";
            lSurname.Size = new System.Drawing.Size(49, 13);
            lSurname.TabIndex = 5;
            lSurname.Text = "Surname";
            lSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new System.Drawing.Point(157, 32);
            lName.Name = "lName";
            lName.Size = new System.Drawing.Size(35, 13);
            lName.TabIndex = 3;
            lName.Text = "Name";
            lName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCategory
            // 
            lCategory.AutoSize = true;
            lCategory.Location = new System.Drawing.Point(143, 84);
            lCategory.Name = "lCategory";
            lCategory.Size = new System.Drawing.Size(49, 13);
            lCategory.TabIndex = 8;
            lCategory.Text = "Category";
            lCategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDisclaimer
            // 
            lDisclaimer.AutoSize = true;
            lDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lDisclaimer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lDisclaimer.Location = new System.Drawing.Point(28, 248);
            lDisclaimer.Name = "lDisclaimer";
            lDisclaimer.Size = new System.Drawing.Size(363, 48);
            lDisclaimer.TabIndex = 9;
            lDisclaimer.Text = "This tool is still in development. It\'s probably buggy\r\nand may corrupt your save" +
    "s. Don\'t overwrite any\r\nexisting saves.";
            // 
            // sFileSeparator1
            // 
            sFileSeparator1.Name = "sFileSeparator1";
            sFileSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // sFileSeparator2
            // 
            sFileSeparator2.Name = "sFileSeparator2";
            sFileSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // sShortcutsSeparator
            // 
            sShortcutsSeparator.Name = "sShortcutsSeparator";
            sShortcutsSeparator.Size = new System.Drawing.Size(193, 6);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tpGeneral);
            this.tabs.Controls.Add(this.tpFinance);
            this.tabs.Controls.Add(this.tpPrisoners);
            this.tabs.Controls.Add(this.tpResearch);
            this.tabs.Controls.Add(this.Gang);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 24);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(434, 338);
            this.tabs.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(lDisclaimer);
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Size = new System.Drawing.Size(426, 312);
            this.tpGeneral.TabIndex = 4;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.xDecay);
            this.groupBox2.Controls.Add(this.xMisconduct);
            this.groupBox2.Controls.Add(this.xFogOfWar);
            this.groupBox2.Controls.Add(this.xFailureConditions);
            this.groupBox2.Controls.Add(this.xContinuousIntake);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 198);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prison Settings";
            // 
            // xDecay
            // 
            this.xDecay.AutoSize = true;
            this.xDecay.Location = new System.Drawing.Point(23, 111);
            this.xDecay.Name = "xDecay";
            this.xDecay.Size = new System.Drawing.Size(62, 17);
            this.xDecay.TabIndex = 4;
            this.xDecay.Text = "Decay";
            this.xDecay.UseVisualStyleBackColor = true;
            // 
            // xMisconduct
            // 
            this.xMisconduct.AutoSize = true;
            this.xMisconduct.Location = new System.Drawing.Point(23, 88);
            this.xMisconduct.Name = "xMisconduct";
            this.xMisconduct.Size = new System.Drawing.Size(91, 17);
            this.xMisconduct.TabIndex = 3;
            this.xMisconduct.Text = "Misconduct";
            this.xMisconduct.UseVisualStyleBackColor = true;
            // 
            // xFogOfWar
            // 
            this.xFogOfWar.AutoSize = true;
            this.xFogOfWar.Location = new System.Drawing.Point(23, 65);
            this.xFogOfWar.Name = "xFogOfWar";
            this.xFogOfWar.Size = new System.Drawing.Size(86, 17);
            this.xFogOfWar.TabIndex = 2;
            this.xFogOfWar.Text = "Fog of war";
            this.xFogOfWar.UseVisualStyleBackColor = true;
            // 
            // xFailureConditions
            // 
            this.xFailureConditions.AutoSize = true;
            this.xFailureConditions.Location = new System.Drawing.Point(23, 42);
            this.xFailureConditions.Name = "xFailureConditions";
            this.xFailureConditions.Size = new System.Drawing.Size(126, 17);
            this.xFailureConditions.TabIndex = 1;
            this.xFailureConditions.Text = "Failure conditions";
            this.xFailureConditions.UseVisualStyleBackColor = true;
            // 
            // xContinuousIntake
            // 
            this.xContinuousIntake.AutoSize = true;
            this.xContinuousIntake.Location = new System.Drawing.Point(23, 19);
            this.xContinuousIntake.Name = "xContinuousIntake";
            this.xContinuousIntake.Size = new System.Drawing.Size(128, 17);
            this.xContinuousIntake.TabIndex = 0;
            this.xContinuousIntake.Text = "Continuous intake";
            this.xContinuousIntake.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cAmPm);
            this.groupBox1.Controls.Add(this.tTime);
            this.groupBox1.Controls.Add(this.nDay);
            this.groupBox1.Controls.Add(this.lDay);
            this.groupBox1.Controls.Add(this.lTime);
            this.groupBox1.Location = new System.Drawing.Point(216, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In-game time";
            // 
            // cAmPm
            // 
            this.cAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAmPm.FormattingEnabled = true;
            this.cAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cAmPm.Location = new System.Drawing.Point(108, 53);
            this.cAmPm.Name = "cAmPm";
            this.cAmPm.Size = new System.Drawing.Size(44, 21);
            this.cAmPm.TabIndex = 4;
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(52, 53);
            this.tTime.Mask = "90:00";
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(50, 20);
            this.tTime.TabIndex = 3;
            this.tTime.ValidatingType = typeof(System.DateTime);
            // 
            // nDay
            // 
            this.nDay.Location = new System.Drawing.Point(52, 27);
            this.nDay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nDay.Name = "nDay";
            this.nDay.Size = new System.Drawing.Size(50, 20);
            this.nDay.TabIndex = 2;
            this.nDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Location = new System.Drawing.Point(20, 29);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(29, 13);
            this.lDay.TabIndex = 0;
            this.lDay.Text = "Day";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(16, 56);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(34, 13);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "Time";
            // 
            // tpFinance
            // 
            this.tpFinance.Controls.Add(this.button1);
            this.tpFinance.Controls.Add(lOwnershipUnits);
            this.tpFinance.Controls.Add(this.nOwnership);
            this.tpFinance.Controls.Add(this.xUnlimitedFunds);
            this.tpFinance.Controls.Add(lBankLoanAmontUnits);
            this.tpFinance.Controls.Add(lBankLoanAmount);
            this.tpFinance.Controls.Add(this.nBankLoanAmount);
            this.tpFinance.Controls.Add(lCreditRating);
            this.tpFinance.Controls.Add(lOwnership);
            this.tpFinance.Controls.Add(this.nCreditRating);
            this.tpFinance.Controls.Add(lBalance);
            this.tpFinance.Controls.Add(lBalanceUnits);
            this.tpFinance.Controls.Add(this.nBalance);
            this.tpFinance.Location = new System.Drawing.Point(4, 22);
            this.tpFinance.Name = "tpFinance";
            this.tpFinance.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinance.Size = new System.Drawing.Size(426, 312);
            this.tpFinance.TabIndex = 5;
            this.tpFinance.Text = "Finance";
            this.tpFinance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Count Insane number";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nOwnership
            // 
            this.nOwnership.Location = new System.Drawing.Point(110, 119);
            this.nOwnership.Name = "nOwnership";
            this.nOwnership.Size = new System.Drawing.Size(53, 20);
            this.nOwnership.TabIndex = 14;
            this.nOwnership.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // xUnlimitedFunds
            // 
            this.xUnlimitedFunds.AutoSize = true;
            this.xUnlimitedFunds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xUnlimitedFunds.Location = new System.Drawing.Point(26, 17);
            this.xUnlimitedFunds.Name = "xUnlimitedFunds";
            this.xUnlimitedFunds.Size = new System.Drawing.Size(98, 17);
            this.xUnlimitedFunds.TabIndex = 7;
            this.xUnlimitedFunds.Text = "Unlimited funds";
            this.xUnlimitedFunds.UseVisualStyleBackColor = true;
            // 
            // nBankLoanAmount
            // 
            this.nBankLoanAmount.Location = new System.Drawing.Point(110, 67);
            this.nBankLoanAmount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nBankLoanAmount.Name = "nBankLoanAmount";
            this.nBankLoanAmount.Size = new System.Drawing.Size(75, 20);
            this.nBankLoanAmount.TabIndex = 12;
            this.nBankLoanAmount.ValueChanged += new System.EventHandler(this.nBankLoanAmount_ValueChanged);
            // 
            // nCreditRating
            // 
            this.nCreditRating.Location = new System.Drawing.Point(110, 93);
            this.nCreditRating.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nCreditRating.Name = "nCreditRating";
            this.nCreditRating.Size = new System.Drawing.Size(53, 20);
            this.nCreditRating.TabIndex = 10;
            this.nCreditRating.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nBalance
            // 
            this.nBalance.Location = new System.Drawing.Point(110, 41);
            this.nBalance.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nBalance.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nBalance.Name = "nBalance";
            this.nBalance.Size = new System.Drawing.Size(75, 20);
            this.nBalance.TabIndex = 8;
            // 
            // tpPrisoners
            // 
            this.tpPrisoners.Controls.Add(this.m_BodyType);
            this.tpPrisoners.Controls.Add(this.m_Age);
            this.tpPrisoners.Controls.Add(this.label2);
            this.tpPrisoners.Controls.Add(this.label1);
            this.tpPrisoners.Controls.Add(this.moveToPercentage);
            this.tpPrisoners.Controls.Add(this.bRelease);
            this.tpPrisoners.Controls.Add(this.lServedStats);
            this.tpPrisoners.Controls.Add(this.lServed);
            this.tpPrisoners.Controls.Add(this.pbServed);
            this.tpPrisoners.Controls.Add(lCategory);
            this.tpPrisoners.Controls.Add(this.cCategory);
            this.tpPrisoners.Controls.Add(this.tSurname);
            this.tpPrisoners.Controls.Add(lSurname);
            this.tpPrisoners.Controls.Add(this.tName);
            this.tpPrisoners.Controls.Add(lName);
            this.tpPrisoners.Controls.Add(this.bEliminate);
            this.tpPrisoners.Controls.Add(this.tPrisonerSearch);
            this.tpPrisoners.Controls.Add(this.lbPrisoners);
            this.tpPrisoners.Location = new System.Drawing.Point(4, 22);
            this.tpPrisoners.Name = "tpPrisoners";
            this.tpPrisoners.Size = new System.Drawing.Size(426, 312);
            this.tpPrisoners.TabIndex = 2;
            this.tpPrisoners.Text = "Prisoners";
            this.tpPrisoners.UseVisualStyleBackColor = true;
            this.tpPrisoners.Click += new System.EventHandler(this.tpPrisoners_Click);
            // 
            // m_BodyType
            // 
            this.m_BodyType.Location = new System.Drawing.Point(221, 186);
            this.m_BodyType.Name = "m_BodyType";
            this.m_BodyType.Size = new System.Drawing.Size(100, 20);
            this.m_BodyType.TabIndex = 17;
            // 
            // m_Age
            // 
            this.m_Age.Location = new System.Drawing.Point(221, 162);
            this.m_Age.Name = "m_Age";
            this.m_Age.Size = new System.Drawing.Size(100, 20);
            this.m_Age.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Body Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Age";
            // 
            // moveToPercentage
            // 
            this.moveToPercentage.Location = new System.Drawing.Point(266, 137);
            this.moveToPercentage.Name = "moveToPercentage";
            this.moveToPercentage.Size = new System.Drawing.Size(58, 23);
            this.moveToPercentage.TabIndex = 13;
            this.moveToPercentage.Text = "Bond Out!";
            this.moveToPercentage.UseVisualStyleBackColor = true;
            this.moveToPercentage.Click += new System.EventHandler(this.moveToPercentage_Click);
            // 
            // bRelease
            // 
            this.bRelease.Location = new System.Drawing.Point(206, 137);
            this.bRelease.Name = "bRelease";
            this.bRelease.Size = new System.Drawing.Size(58, 23);
            this.bRelease.TabIndex = 12;
            this.bRelease.Text = "Release";
            this.bRelease.UseVisualStyleBackColor = true;
            this.bRelease.Click += new System.EventHandler(this.bRelease_Click);
            // 
            // lServedStats
            // 
            this.lServedStats.AutoSize = true;
            this.lServedStats.Location = new System.Drawing.Point(325, 113);
            this.lServedStats.Name = "lServedStats";
            this.lServedStats.Size = new System.Drawing.Size(86, 13);
            this.lServedStats.TabIndex = 11;
            this.lServedStats.Text = "{0}% of {1} years";
            this.lServedStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lServed
            // 
            this.lServed.AutoSize = true;
            this.lServed.Location = new System.Drawing.Point(151, 113);
            this.lServed.Name = "lServed";
            this.lServed.Size = new System.Drawing.Size(41, 13);
            this.lServed.TabIndex = 10;
            this.lServed.Text = "Served";
            this.lServed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbServed
            // 
            this.pbServed.Location = new System.Drawing.Point(198, 108);
            this.pbServed.Name = "pbServed";
            this.pbServed.Size = new System.Drawing.Size(121, 23);
            this.pbServed.TabIndex = 9;
            // 
            // cCategory
            // 
            this.cCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCategory.FormattingEnabled = true;
            this.cCategory.Items.AddRange(new object[] {
            "Protective Custody",
            "Minimum Security",
            "Normal Security",
            "Maximum Security",
            "SuperMax",
            "Death Row",
            "Insane"});
            this.cCategory.Location = new System.Drawing.Point(198, 81);
            this.cCategory.Name = "cCategory";
            this.cCategory.Size = new System.Drawing.Size(121, 21);
            this.cCategory.TabIndex = 7;
            this.cCategory.SelectedIndexChanged += new System.EventHandler(this.cCategory_SelectedIndexChanged);
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(198, 55);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(121, 20);
            this.tSurname.TabIndex = 6;
            this.tSurname.TextChanged += new System.EventHandler(this.tSurname_TextChanged);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(198, 29);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(121, 20);
            this.tName.TabIndex = 4;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // bEliminate
            // 
            this.bEliminate.Location = new System.Drawing.Point(146, 137);
            this.bEliminate.Name = "bEliminate";
            this.bEliminate.Size = new System.Drawing.Size(58, 23);
            this.bEliminate.TabIndex = 2;
            this.bEliminate.Text = "Eliminate";
            this.bEliminate.UseVisualStyleBackColor = true;
            this.bEliminate.Click += new System.EventHandler(this.bEliminate_Click);
            // 
            // tPrisonerSearch
            // 
            this.tPrisonerSearch.Location = new System.Drawing.Point(8, 3);
            this.tPrisonerSearch.Name = "tPrisonerSearch";
            this.tPrisonerSearch.Size = new System.Drawing.Size(120, 20);
            this.tPrisonerSearch.TabIndex = 1;
            this.tPrisonerSearch.TextChanged += new System.EventHandler(this.tPrisonerSearch_TextChanged);
            // 
            // lbPrisoners
            // 
            this.lbPrisoners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrisoners.FormattingEnabled = true;
            this.lbPrisoners.Location = new System.Drawing.Point(8, 29);
            this.lbPrisoners.Name = "lbPrisoners";
            this.lbPrisoners.Size = new System.Drawing.Size(120, 277);
            this.lbPrisoners.TabIndex = 0;
            this.lbPrisoners.SelectedIndexChanged += new System.EventHandler(this.lbPrisoners_SelectedIndexChanged);
            // 
            // tpResearch
            // 
            this.tpResearch.Controls.Add(this.clbResearch);
            this.tpResearch.Location = new System.Drawing.Point(4, 22);
            this.tpResearch.Name = "tpResearch";
            this.tpResearch.Size = new System.Drawing.Size(426, 312);
            this.tpResearch.TabIndex = 3;
            this.tpResearch.Text = "Research";
            this.tpResearch.UseVisualStyleBackColor = true;
            // 
            // clbResearch
            // 
            this.clbResearch.CheckOnClick = true;
            this.clbResearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbResearch.FormattingEnabled = true;
            this.clbResearch.Location = new System.Drawing.Point(0, 0);
            this.clbResearch.Name = "clbResearch";
            this.clbResearch.Size = new System.Drawing.Size(426, 312);
            this.clbResearch.TabIndex = 0;
            // 
            // Gang
            // 
            this.Gang.BackColor = System.Drawing.Color.DimGray;
            this.Gang.Controls.Add(this.button2);
            this.Gang.Location = new System.Drawing.Point(4, 22);
            this.Gang.Name = "Gang";
            this.Gang.Padding = new System.Windows.Forms.Padding(3);
            this.Gang.Size = new System.Drawing.Size(426, 312);
            this.Gang.TabIndex = 6;
            this.Gang.Text = "Gang Activity";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miShortcuts,
            this.miHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(434, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            sFileSeparator1,
            this.miFileSave,
            this.miFileSaveAs,
            sFileSeparator2,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miFileOpen
            // 
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.Size = new System.Drawing.Size(123, 22);
            this.miFileOpen.Text = "Open...";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSave
            // 
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.Size = new System.Drawing.Size(123, 22);
            this.miFileSave.Text = "Save";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.Size = new System.Drawing.Size(123, 22);
            this.miFileSaveAs.Text = "Save As...";
            this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(123, 22);
            this.miExit.Text = "Exit";
            // 
            // miShortcuts
            // 
            this.miShortcuts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReleasePrisoners,
            this.miEliminatePrisoners,
            this.miRevealReputations,
            sShortcutsSeparator,
            this.miUnlockAllResearch,
            this.miRemoveAllTrees,
            this.miRemoveTunnels,
            this.miRemoveAllContraband});
            this.miShortcuts.Name = "miShortcuts";
            this.miShortcuts.Size = new System.Drawing.Size(69, 20);
            this.miShortcuts.Text = "Shortcuts";
            // 
            // miReleasePrisoners
            // 
            this.miReleasePrisoners.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReleaseInsane,
            this.miReleaseProtected,
            this.miReleaseMinSec,
            this.miReleaseNormal,
            this.miReleaseMaxSec,
            this.miReleaseSuperMax,
            this.miReleaseDeathRow,
            sReleasePrisonersSeparator,
            this.miReleaseAll});
            this.miReleasePrisoners.Name = "miReleasePrisoners";
            this.miReleasePrisoners.Size = new System.Drawing.Size(196, 22);
            this.miReleasePrisoners.Text = "Release prisoners";
            // 
            // miReleaseInsane
            // 
            this.miReleaseInsane.Name = "miReleaseInsane";
            this.miReleaseInsane.Size = new System.Drawing.Size(174, 22);
            this.miReleaseInsane.Text = "Release Insane";
            // 
            // miReleaseProtected
            // 
            this.miReleaseProtected.Name = "miReleaseProtected";
            this.miReleaseProtected.Size = new System.Drawing.Size(174, 22);
            this.miReleaseProtected.Text = "Protective Custody";
            // 
            // miReleaseMinSec
            // 
            this.miReleaseMinSec.Name = "miReleaseMinSec";
            this.miReleaseMinSec.Size = new System.Drawing.Size(174, 22);
            this.miReleaseMinSec.Text = "Minimum Security";
            // 
            // miReleaseNormal
            // 
            this.miReleaseNormal.Name = "miReleaseNormal";
            this.miReleaseNormal.Size = new System.Drawing.Size(174, 22);
            this.miReleaseNormal.Text = "Normal Security";
            // 
            // miReleaseMaxSec
            // 
            this.miReleaseMaxSec.Name = "miReleaseMaxSec";
            this.miReleaseMaxSec.Size = new System.Drawing.Size(174, 22);
            this.miReleaseMaxSec.Text = "Maximum Security";
            // 
            // miReleaseSuperMax
            // 
            this.miReleaseSuperMax.Name = "miReleaseSuperMax";
            this.miReleaseSuperMax.Size = new System.Drawing.Size(174, 22);
            this.miReleaseSuperMax.Text = "SuperMax";
            // 
            // miReleaseDeathRow
            // 
            this.miReleaseDeathRow.Name = "miReleaseDeathRow";
            this.miReleaseDeathRow.Size = new System.Drawing.Size(174, 22);
            this.miReleaseDeathRow.Text = "Death Row";
            // 
            // miReleaseAll
            // 
            this.miReleaseAll.Name = "miReleaseAll";
            this.miReleaseAll.Size = new System.Drawing.Size(174, 22);
            this.miReleaseAll.Text = "All";
            // 
            // miEliminatePrisoners
            // 
            this.miEliminatePrisoners.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEliminateInsane,
            this.miEliminateProtected,
            this.miEliminateMinSec,
            this.miEliminateNormal,
            this.miEliminateMaxSec,
            this.miEliminateSuperMax,
            this.miEliminateDeathRow,
            this.sEliminatePrisonersSeparator,
            this.miEliminateAll});
            this.miEliminatePrisoners.Name = "miEliminatePrisoners";
            this.miEliminatePrisoners.Size = new System.Drawing.Size(196, 22);
            this.miEliminatePrisoners.Text = "Eliminate prisoners";
            // 
            // miEliminateInsane
            // 
            this.miEliminateInsane.Name = "miEliminateInsane";
            this.miEliminateInsane.Size = new System.Drawing.Size(174, 22);
            this.miEliminateInsane.Text = "Insane";
            // 
            // miEliminateProtected
            // 
            this.miEliminateProtected.Name = "miEliminateProtected";
            this.miEliminateProtected.Size = new System.Drawing.Size(174, 22);
            this.miEliminateProtected.Text = "Protective Custody";
            // 
            // miEliminateMinSec
            // 
            this.miEliminateMinSec.Name = "miEliminateMinSec";
            this.miEliminateMinSec.Size = new System.Drawing.Size(174, 22);
            this.miEliminateMinSec.Text = "Minimum Security";
            // 
            // miEliminateNormal
            // 
            this.miEliminateNormal.Name = "miEliminateNormal";
            this.miEliminateNormal.Size = new System.Drawing.Size(174, 22);
            this.miEliminateNormal.Text = "Normal Security";
            // 
            // miEliminateMaxSec
            // 
            this.miEliminateMaxSec.Name = "miEliminateMaxSec";
            this.miEliminateMaxSec.Size = new System.Drawing.Size(174, 22);
            this.miEliminateMaxSec.Text = "Maximum Security";
            // 
            // miEliminateSuperMax
            // 
            this.miEliminateSuperMax.Name = "miEliminateSuperMax";
            this.miEliminateSuperMax.Size = new System.Drawing.Size(174, 22);
            this.miEliminateSuperMax.Text = "SuperMax";
            // 
            // miEliminateDeathRow
            // 
            this.miEliminateDeathRow.Name = "miEliminateDeathRow";
            this.miEliminateDeathRow.Size = new System.Drawing.Size(174, 22);
            this.miEliminateDeathRow.Text = "Death Row";
            // 
            // sEliminatePrisonersSeparator
            // 
            this.sEliminatePrisonersSeparator.Name = "sEliminatePrisonersSeparator";
            this.sEliminatePrisonersSeparator.Size = new System.Drawing.Size(171, 6);
            // 
            // miEliminateAll
            // 
            this.miEliminateAll.Name = "miEliminateAll";
            this.miEliminateAll.Size = new System.Drawing.Size(174, 22);
            this.miEliminateAll.Text = "All";
            // 
            // miRevealReputations
            // 
            this.miRevealReputations.Name = "miRevealReputations";
            this.miRevealReputations.Size = new System.Drawing.Size(196, 22);
            this.miRevealReputations.Text = "Reveal reputations";
            this.miRevealReputations.Click += new System.EventHandler(this.miRevealReputations_Click);
            // 
            // miUnlockAllResearch
            // 
            this.miUnlockAllResearch.Name = "miUnlockAllResearch";
            this.miUnlockAllResearch.Size = new System.Drawing.Size(196, 22);
            this.miUnlockAllResearch.Text = "Unlock all research";
            this.miUnlockAllResearch.Click += new System.EventHandler(this.miUnlockAllResearch_Click);
            // 
            // miRemoveAllTrees
            // 
            this.miRemoveAllTrees.Name = "miRemoveAllTrees";
            this.miRemoveAllTrees.Size = new System.Drawing.Size(196, 22);
            this.miRemoveAllTrees.Text = "Remove all trees";
            this.miRemoveAllTrees.Click += new System.EventHandler(this.miRemoveAllTrees_Click);
            // 
            // miRemoveTunnels
            // 
            this.miRemoveTunnels.Name = "miRemoveTunnels";
            this.miRemoveTunnels.Size = new System.Drawing.Size(196, 22);
            this.miRemoveTunnels.Text = "Remove all tunnels";
            this.miRemoveTunnels.Click += new System.EventHandler(this.miRemoveTunnels_Click);
            // 
            // miRemoveAllContraband
            // 
            this.miRemoveAllContraband.Name = "miRemoveAllContraband";
            this.miRemoveAllContraband.Size = new System.Drawing.Size(196, 22);
            this.miRemoveAllContraband.Text = "Remove all contraband";
            this.miRemoveAllContraband.Click += new System.EventHandler(this.miRemoveAllContraband_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(107, 22);
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "GetGangMember";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "PSAE by Crypto";
            this.tabs.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).EndInit();
            this.tpFinance.ResumeLayout(false);
            this.tpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOwnership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBankLoanAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCreditRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).EndInit();
            this.tpPrisoners.ResumeLayout(false);
            this.tpPrisoners.PerformLayout();
            this.tpResearch.ResumeLayout(false);
            this.Gang.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpPrisoners;
        private System.Windows.Forms.TabPage tpResearch;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cAmPm;
        private System.Windows.Forms.MaskedTextBox tTime;
        private System.Windows.Forms.NumericUpDown nDay;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TabPage tpFinance;
        private System.Windows.Forms.NumericUpDown nOwnership;
        private System.Windows.Forms.CheckBox xUnlimitedFunds;
        private System.Windows.Forms.NumericUpDown nBankLoanAmount;
        private System.Windows.Forms.NumericUpDown nCreditRating;
        private System.Windows.Forms.NumericUpDown nBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox xFailureConditions;
        private System.Windows.Forms.CheckBox xContinuousIntake;
        private System.Windows.Forms.CheckBox xFogOfWar;
        private System.Windows.Forms.CheckBox xMisconduct;
        private System.Windows.Forms.ToolStripMenuItem miShortcuts;
        private System.Windows.Forms.ToolStripMenuItem miReleasePrisoners;
        private System.Windows.Forms.ToolStripMenuItem miReleaseProtected;
        private System.Windows.Forms.ToolStripMenuItem miReleaseMinSec;
        private System.Windows.Forms.ToolStripMenuItem miReleaseNormal;
        private System.Windows.Forms.ToolStripMenuItem miReleaseMaxSec;
        private System.Windows.Forms.ToolStripMenuItem miReleaseSuperMax;
        private System.Windows.Forms.ToolStripMenuItem miReleaseAll;
        private System.Windows.Forms.ToolStripMenuItem miRemoveTunnels;
        private System.Windows.Forms.ToolStripMenuItem miUnlockAllResearch;
        private System.Windows.Forms.ToolStripMenuItem miRemoveAllTrees;
        private System.Windows.Forms.CheckedListBox clbResearch;
        private System.Windows.Forms.TextBox tPrisonerSearch;
        private System.Windows.Forms.ListBox lbPrisoners;
        private System.Windows.Forms.Button bEliminate;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.ComboBox cCategory;
        private System.Windows.Forms.CheckBox xDecay;
        private System.Windows.Forms.ToolStripMenuItem miRemoveAllContraband;
        private System.Windows.Forms.ToolStripMenuItem miRevealReputations;
        private System.Windows.Forms.ToolStripMenuItem miEliminatePrisoners;
        private System.Windows.Forms.ToolStripMenuItem miEliminateProtected;
        private System.Windows.Forms.ToolStripMenuItem miEliminateMinSec;
        private System.Windows.Forms.ToolStripMenuItem miEliminateNormal;
        private System.Windows.Forms.ToolStripMenuItem miEliminateMaxSec;
        private System.Windows.Forms.ToolStripMenuItem miEliminateSuperMax;
        private System.Windows.Forms.ToolStripSeparator sEliminatePrisonersSeparator;
        private System.Windows.Forms.ToolStripMenuItem miEliminateAll;
        private System.Windows.Forms.Label lServedStats;
        private System.Windows.Forms.Label lServed;
        private System.Windows.Forms.ProgressBar pbServed;
        private System.Windows.Forms.Button bRelease;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miReleaseDeathRow;
        private System.Windows.Forms.ToolStripMenuItem miEliminateDeathRow;
        private System.Windows.Forms.TabPage Gang;
        private System.Windows.Forms.ToolStripMenuItem miEliminateInsane;
        private System.Windows.Forms.Button moveToPercentage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_BodyType;
        private System.Windows.Forms.TextBox m_Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miReleaseInsane;
        private System.Windows.Forms.Button button2;
    }
}

