using System.Collections.Generic;

namespace PASaveEditor.FileModel {
    internal class Tunnels : Node {
        public readonly List<TunnelCell> TunnelCells = new List<TunnelCell>();
        public readonly Diggers Diggers = new Diggers();


        public Tunnels()
            : base("Tunnels", true) {}


        public override Node CreateNode(string label) {
            if (Pos.IsPos(label)) {
                var cell = new TunnelCell(label);
                TunnelCells.Add(cell);
                return cell;
            } else if ("Diggers".Equals(label)) {
                return Diggers;
            } else {
                return base.CreateNode(label);
            }
            // TODO Diggers
        }


        public override void WriteNodes(Writer writer) {
            foreach (TunnelCell cell in TunnelCells) {
                writer.WriteNode(cell);
            }
            writer.WriteNode(Diggers);
        }
    }
}
