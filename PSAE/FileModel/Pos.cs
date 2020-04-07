using System;
using System.Text.RegularExpressions;

namespace PASaveEditor.FileModel {
    internal struct Pos {
        public int X, Y;


        public static Pos ParsePos(string str) {
            int spaceIdx = str.IndexOf(' ');
            var newPos = new Pos {
                X = Int32.Parse(str.Substring(0, spaceIdx)),
                Y = Int32.Parse(str.Substring(spaceIdx + 1))
            };
            return newPos;
        }


        static readonly Regex PosRegex = new Regex("^\\d+ \\d+$", RegexOptions.Compiled);


        public static bool IsPos(string str) {
            return PosRegex.IsMatch(str);
        }
    }
}
