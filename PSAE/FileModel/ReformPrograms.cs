using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class ReformPrograms : Node {
        public readonly List<ReformProgram> Programs = new List<ReformProgram>();


        public ReformPrograms(string label)
            : base(label, true) {}


        public override void ReadKey(string key, string value) {
            if (!key.Equals("Size")) {
                base.ReadKey(key, value);
            }
        }


        public override Node CreateNode(string label) {
            if (Parser.IsId(label)) {
                var program = new ReformProgram(label);
                Programs.Add(program);
                return program;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Size", Programs.Count);
        }


        public override void WriteNodes(Writer writer) {
            foreach (ReformProgram program in Programs) {
                writer.WriteNode(program);
            }
        }
    }
}
