namespace PASaveEditor.FileModel {
    internal class ObjectBase : Node {
        public ObjectBase(string label, bool doNotInline)
            : base(label, doNotInline) {
            Id = Parser.ParseId(label);
        }


        public int Id;
        public string Type;


        public override void ReadKey(string key, string value) {
            switch (key) {
                case "Type":
                    Type = value;
                    break;
                default:
                    base.ReadKey(key, value);
                    break;
            }
        }


        public override Node CreateNode(string label) {
            if (Type.Equals("Prisoner") && label.Equals("Bio")) {
                var bio = new PrisonerBio(label);
                PushNode(label, bio);
                return bio;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Type", Type);
        }
    }
}
