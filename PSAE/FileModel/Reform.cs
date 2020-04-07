namespace PASaveEditor.FileModel {
    internal class Reform : Node {
        public ReformPrograms Programs;


        public Reform()
            : base("Reform", true) {}


        public override Node CreateNode(string label) {
            if (label.Equals("Programs")) {
                return (Programs = new ReformPrograms(label));
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteNodes(Writer writer) {
            writer.WriteNode(Programs);
        }
    }
}
