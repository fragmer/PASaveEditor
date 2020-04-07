using System;

namespace PASaveEditor.FileModel
{
    internal class Gang : Node
    {
        public int gangId;
        public String gangRank;
        public double recruitment;

        public Gang(string label)
            : base(label) { }

        
        public override void ReadKey(string key, string value)
        {
            switch (key)
            {
                case "Gang.Id":
                    gangId = Int32.Parse(value);
                    break;
                case "Gang.Rank":
                    gangRank = value;
                    break;
                case "Gang.Recruitment":
                    recruitment = Double.Parse(value);
                    break;
                default:
                    base.ReadKey(key, value);
                    break;
            }
        }


        public override void WriteProperties(Writer writer)
        {
            writer.WriteProperty("Prisoner.i", gangId);
            writer.WriteProperty("Coverage", gangRank);
            writer.WriteProperty("Suspicion", recruitment);
        }
    }
}
