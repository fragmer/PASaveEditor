using System;
using System.Collections.Generic;
using System.Linq;
using PASaveEditor.FileModel;

namespace PASaveEditor {
    internal static class PrisonerUtil {
        // Names as they appear in the savegame are different from displayed names.
        static readonly Dictionary<string, string> CategoryNames = new Dictionary<string, string> {
            { "Protected", "Protective Custody" },
            { "MinSec", "Minimum Security" },
            { "Normal", "Normal Security" },
            { "MaxSec", "Maximum Security" },
            { "SuperMax", "SuperMax" },
            { "DeathRow", "Death Row" },
            {"Insane", "Insane" }
        };

        // Converts short in-savegame name to index (0-5)
        public static string CategoryIndexToName(int index) {
            return CategoryNames.Keys.ToArray()[index];
        }


        public static string InternalToInGameCatName(string catName) {
            return CategoryNames[catName];
        }


        // Converts index (0-5) to short in-savegame name
        public static int CategoryNameToIndex(string catName) {
            return Array.IndexOf(CategoryNames.Keys.ToArray(), catName);
        }


        // Returns a list of IDs of all prisoners who match the given predicate
        public static int[] FindPrisoners(Prison prison, Predicate<Prisoner> predicate) {
            return prison.Objects.Prisoners.Values
                         .Where(prisoner => predicate(prisoner))
                         .Select(prisoner => prisoner.Id)
                         .ToArray();
        }


        public static int CountPrisoners(Prison prison, Predicate<Prisoner> predicate) {
            return prison.Objects.Prisoners.Values
                         .Count(prisoner => predicate(prisoner));
        }


        // Eliminates all prisoners who match the given predicate
        public static int Eliminate(Prison prison, Predicate<Prisoner> predicate) {
            int[] idsToRemove = FindPrisoners(prison, predicate);
            foreach (int id in idsToRemove) {
                EliminatePrisoner(prison, id);
            }
            return idsToRemove.Length;
        }


        // Schedules all prisoners who match the given predicate for release
        public static int Release(Prison prison, Predicate<Prisoner> predicate) {
            int[] idsToRemove = FindPrisoners(prison, predicate);
            foreach (int id in idsToRemove) {
                ReleasePrisoner(prison, id);
            }
            return idsToRemove.Length;
        }


        // Eliminates a single prisoner, by ID. Erases all traces of their existence.
        public static void EliminatePrisoner(Prison prison, int id) {
            prison.Objects.Prisoners.Remove(id);
            prison.Contraband.Child.Prisoners.Remove(id);
            prison.Informants.Child.Prisoners.RemoveAll(informant => informant.PrisonerId == id);
            prison.Misconduct.Reports.Reports.Remove(id);
            prison.Penalties.Child.PenaltyList.Remove(id);
            foreach (ReformProgram program in prison.Reform.Programs.Programs) {
                program.Students.Students.Remove(id);
            }
            prison.Tunnels.Diggers.Prisoners.RemoveAll(p => p.PrisonerId == id);
            prison.Victory.Child.Log.RemoveAll(entry => entry.PrisonerId == id);
        }


        // Schedules a single prisoner for release, by ID.
        public static void ReleasePrisoner(Prison prison, int id) {
            PrisonerBio bio = prison.Objects.Prisoners[id].Bio;
            bio.Served = bio.Sentence;
        }


        static readonly Dictionary<int, string> UnnamedPrisoners = new Dictionary<int, string> {
            { 93446, "SoulCake" },
            { 94805, "BrawnyFanta" },
            { 95177, "Neotin" },
            { 111475, "Squirrel" },
            { 114697, "DarkKnightPyro" },
            { 114969, "The Kracksquatch" },
            { 118793, "The Joker" },
            { 124835, "Heisenberg" },
            { 127230, "TotmasterT" },
            { 136059, "konflakes" }
        };


        public static string NamePrisoner(Prisoner prisoner) {
            string nickName;
            if (UnnamedPrisoners.TryGetValue(prisoner.Bio.Nitg, out nickName)) {
                // Fix for nameless prisoners
                return '"' + nickName + '"';
            } else {
                return prisoner.Bio.Forname + " " + prisoner.Bio.Surname;
            }
        }
    }
}
