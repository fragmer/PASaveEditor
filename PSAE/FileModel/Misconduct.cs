using System;

namespace PASaveEditor.FileModel {
    internal class Misconduct : Node {
        public MisconductReports Reports;
        public double TimeWithoutIncident;


        public Misconduct()
            : base("Misconduct", true) {}


        public override void ReadKey(string key, string value) {
            if ("TimeWithoutIncident".Equals(key)) {
                TimeWithoutIncident = Double.Parse(value);
            } else {
                base.ReadKey(key, value);
            }
        }


        public override Node CreateNode(string label) {
            if ("MisconductReports".Equals(label)) {
                return (Reports = new MisconductReports(label));
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("TimeWithoutIncident", TimeWithoutIncident);
        }


        public override void WriteNodes(Writer writer) {
            writer.WriteNode(Reports);
        }
    }
}
