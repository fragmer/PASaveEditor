using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class ContrabandPrisoners : Node {
        public readonly Dictionary<int, Node> Prisoners = new Dictionary<int, Node>();


        public ContrabandPrisoners(string label)
            : base(label, true) {}


        public override Node CreateNode(string label) {
            if (Parser.IsId(label)) {
                int prisonerId = Parser.ParseId(label);
                var item = new Node(label);
                Prisoners.Add(prisonerId, item);
                return item;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteNodes(Writer writer) {
            foreach (var prisoner in Prisoners) {
                writer.WriteNode(prisoner.Value);
            }
        }
    }
}
