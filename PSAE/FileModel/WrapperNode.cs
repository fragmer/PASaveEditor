using System;

namespace PASaveEditor.FileModel {
    internal class WrapperNode<T> : Node where T : Node {
        public T Child;
        readonly string wrappedNodeName;
        readonly Func<string, T> creationFunc;


        public WrapperNode(string label, string wrappedNodeName, Func<string, T> creationFunc)
            : base(label, true) {
            this.wrappedNodeName = wrappedNodeName;
            this.creationFunc = creationFunc;
        }


        public override Node CreateNode(string label) {
            if (wrappedNodeName.Equals(label)) {
                return (Child = creationFunc(label));
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteNodes(Writer writer) {
            writer.WriteNode(Child);
        }
    }
}
