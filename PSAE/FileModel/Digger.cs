using System;

namespace PASaveEditor.FileModel {
    internal class Digger : Node {
        public int PrisonerId;


        public Digger(string label)
            : base(label) {}


        public override void ReadKey(string key, string value) {
            if ("Id.i".Equals(key)) {
                PrisonerId = Int32.Parse(value);
            } else {
                base.ReadKey(key, value);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Id.i", PrisonerId);
        }
    }
}
