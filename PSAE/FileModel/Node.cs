using System.Collections.Generic;
using System.Linq;

namespace PASaveEditor.FileModel {
    internal class Node {
        public Node(string label, bool doNotInline = false) {
            Label = label;
            DoNotInline = doNotInline;
        }


        public string Label;
        public Dictionary<string, List<string>> Properties;
        public Dictionary<string, List<Node>> Nodes;
        public bool DoNotInline;


        public virtual void ReadKey(string key, string value) {
            PushProperty(key, value);
        }


        public virtual Node CreateNode(string label) {
            var newNode = new Node(label);
            PushNode(label, newNode);
            return newNode;
        }


        public virtual void FinishedReadingNode(Node node) {}


        public void PushProperty(string key, string value) {
            if (Properties == null) {
                Properties = new Dictionary<string, List<string>>();
            }
            List<string> list;
            if (!Properties.TryGetValue(key, out list)) {
                list = new List<string>();
                Properties.Add(key, list);
            }
            list.Add(value);
        }


        public void PushNode(string key, Node value) {
            if (Nodes == null) {
                Nodes = new Dictionary<string, List<Node>>();
            }
            List<Node> list;
            if (!Nodes.TryGetValue(key, out list)) {
                list = new List<Node>();
                Nodes.Add(key, list);
            }
            list.Add(value);
        }


        public Node PopNode(string key) {
            List<Node> list = Nodes[key];
            Node nodeToRemove = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            if (list.Count == 0) {
                Nodes.Remove(key);
            }
            return nodeToRemove;
        }


        public void ReparseProperties(Node other) {
            foreach (var property in other.ListProperties()) {
                ReadKey(property.Key, property.Value);
            }
        }


        public void CopyNodes(Node other) {
            foreach (var property in other.ListNodes()) {
                PushNode(property.Label, property);
            }
        }


        public IEnumerable<KeyValuePair<string, string>> ListProperties() {
            return Properties.SelectMany(
                propList => propList.Value,
                (propList, propValue) => new KeyValuePair<string, string>(propList.Key, propValue));
        }


        public IEnumerable<Node> ListNodes() {
            return Nodes.SelectMany(
                nodeList => nodeList.Value,
                (nodeList, nodeValue) => nodeValue);
        }


        public virtual void WriteProperties(Writer writer) {}

        public virtual void WriteNodes(Writer writer) {}

        public override string ToString() {
            return "Node(" + Label + ")";
        }


        public Node TryGetNode(string label) {
            if (Nodes == null) return null;
            List<Node> list;
            if (!Nodes.TryGetValue(label, out list)) {
                return null;
            }
            if (list.Count == 0) return null;
            return list[0];
        }

        public string TryGetProperty(string key) {
            if (Properties == null) return null;
            List<string> list;
            if (!Properties.TryGetValue(key, out list)) {
                return null;
            }
            if (list.Count == 0) return null;
            return list[0];
        }
    }
}
