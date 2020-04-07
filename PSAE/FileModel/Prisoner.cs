namespace PASaveEditor.FileModel {
    internal class Prisoner : ObjectBase {
        public string Category;
        public readonly PrisonerBio Bio;


        public Prisoner(ObjectBase baseObj)
            : base(baseObj.Label, true) {
            Id = baseObj.Id;
            Type = baseObj.Type;
            ReparseProperties(baseObj);
            CopyNodes(baseObj);
            Bio = (PrisonerBio)PopNode("Bio");
        }


        public override void ReadKey(string key, string value) {
            if ("Category".Equals(key)) {
                Category = value;
            } else {
                base.ReadKey(key, value);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Type", Type);
            writer.WriteProperty("Category", Category);
        }


        public override void WriteNodes(Writer writer) {
            writer.WriteNode(Bio);
        }
    }
}
