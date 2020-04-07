using System;

namespace PASaveEditor.FileModel {
    internal class ReformStudent : Node {
        public int Id;


        public ReformStudent(string label)
            : base(label) {}


        public override void ReadKey(string key, string value) {
            if (key.Equals("Id.i")) {
                Id = Int32.Parse(value);
            } else {
                base.ReadKey(key, value);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Id.i", Id);
        }
    }
}
