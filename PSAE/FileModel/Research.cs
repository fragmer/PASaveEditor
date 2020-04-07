using System.Collections.Generic;
using System.Linq;

namespace PASaveEditor.FileModel {
    internal class Research : Node {
        public readonly List<ResearchItem> Items = new List<ResearchItem>();


        public Research()
            : base("Research", true) {}


        public override Node CreateNode(string label) {
            var newItem = new ResearchItem(label);
            Items.Add(newItem);
            return newItem;
        }


        public override void WriteNodes(Writer writer) {
            foreach (ResearchItem item in Items) {
                writer.WriteNode(item);
            }
        }


        public void Unlock(string itemName) {
            ResearchItem researchedItem = Items.FirstOrDefault(item => item.Label == itemName);
            if (researchedItem == null) {
                researchedItem = new ResearchItem(itemName);
                researchedItem.PushProperty("Desired", "false");
            }
            researchedItem.Progress = 1;
        }


        public void Lock(string itemName) {
            ResearchItem researchedItem = Items.FirstOrDefault(item => item.Label == itemName);
            if (researchedItem != null && researchedItem.Progress > .999) {
                Items.RemoveAll(item => item.Label == itemName);
            }
        }
    }
}
