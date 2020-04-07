using System.Collections.Generic;
using System.Linq;

namespace PASaveEditor {
    internal static class ResearchData {
        public static readonly List<string> AllResearch = new List<string> {
            "Warden",
            "Maintainance",
            "Security",
            "MentalHealth",
            "Finance",
            "Cctv",
            "RemoteAccess",
            "Health",
            "Cleaning",
            "GroundsKeeping",
            "Clone",
            "Deployment",
            "Patrols",
            "Dogs",
            "PrisonLabour",
            "Education",
            "LandExpansion",
            "Contraband",
            "Policy",
            "Armoury",
            "BodyArmour",
            "Tazers",
            "TazersForEveryone",
            "BankLoans",
            "LowerTaxes1",
            "LowerTaxes2",
            "ExtraGrant"
        };

        static readonly Dictionary<string, string> AltNames = new Dictionary<string, string> {
            { "MentalHealth", "Psychology" },
            { "Cctv", "CCTV" },
            { "RemoteAccess", "Remote Access" },
            { "GroundsKeeping", "Grounds Keeping" },
            { "PrisonLabour", "Prison Labour" },
            { "LandExpansion", "Land Expansion" },
            { "Policy", "Prison Policy" },
            { "BodyArmour", "Body Armour" },
            { "TazersForEveryone", "Tazer Rollout" },
            { "BankLoans", "Bank Loans" },
            { "LowerTaxes1", "Tax Relief" },
            { "LowerTaxes2", "Offshore Tax Haven" },
            { "ExtraGrant", "Extra Grant" },
        };


        public static string[] GetInGameNames() {
            return AllResearch.Select(name => {
                string altName;
                return AltNames.TryGetValue(name, out altName) ? altName : name;
            }).ToArray();
        }


        public static int GetIndex(string inFileName) {
            return AllResearch.IndexOf(inFileName);
        }


        public static int AddItem(string inFileName) {
            AllResearch.Add(inFileName);
            return AllResearch.Count - 1;
        }
    }
}
