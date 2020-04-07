using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class Informants : Node {
        public readonly List<Informant> Prisoners = new List<Informant>();


        public Informants(string label)
            : base(label, true) {}


        public override void ReadKey(string key, string value) {
            if (!"Size".Equals(key)) {
                // do not store size -- it will be counted and written at save-time
                base.ReadKey(key, value);
            }
        }


        public override Node CreateNode(string label) {
            if (Parser.IsId(label)) {
                var informant = new Informant(label);
                Prisoners.Add(informant);
                return informant;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Size", Prisoners.Count);
        }


        public override void WriteNodes(Writer writer) {
            for (int i = 0; i < Prisoners.Count; i++) {
                Informant informant = Prisoners[i];
                informant.Label = "[i " + i + "]";
                writer.WriteNode(informant);
            }
        }
    }
}
