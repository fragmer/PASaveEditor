using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class MisconductReports : Node {
        public readonly Dictionary<int, Node> Reports = new Dictionary<int, Node>();


        public MisconductReports(string label)
            : base(label, true) {}


        public override Node CreateNode(string label) {
            if (Parser.IsId(label)) {
                var report = new Node(label);
                int prisonerId = Parser.ParseId(label);
                Reports.Add(prisonerId, report);
                return report;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteNodes(Writer writer) {
            foreach (Node report in Reports.Values) {
                writer.WriteNode(report);
            }
        }
    }
}
