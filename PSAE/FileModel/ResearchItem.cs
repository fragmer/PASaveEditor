using System;

namespace PASaveEditor.FileModel {
    internal class ResearchItem : Node {
        public double Progress;


        public ResearchItem(string label)
            : base(label) {}


        public override void ReadKey(string key, string value) {
            if ("Progress".Equals(key)) {
                Progress = Double.Parse(value);
            } else {
                base.ReadKey(key, value);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Progress", Progress);
        }
    }
}
