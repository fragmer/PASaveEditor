using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class Diggers : Node {
        public readonly List<Digger> Prisoners = new List<Digger>();


        public Diggers()
            : base("Diggers", true) {}


        public override void ReadKey(string key, string value) {
            if (!"Size".Equals(key)) {
                // do not store size -- it will be counted and written at save-time
                base.ReadKey(key, value);
            }
        }


        public override Node CreateNode(string label) {
            if (Parser.IsId(label)) {
                var digger = new Digger(label);
                Prisoners.Add(digger);
                return digger;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Size", Prisoners.Count);
        }


        public override void WriteNodes(Writer writer) {
            for (int i = 0; i < Prisoners.Count; i++) {
                Digger digger = Prisoners[i];
                digger.Label = "[i " + i + "]";
                writer.WriteNode(digger);
            }
        }
    }
}
