using System;

namespace PASaveEditor.FileModel {
    internal class Finance : Node {
        public int Balance;
        public int LastDay;
        public int LastHour;
        public int BankLoan;
        public double BankCreditRating;
        public int Ownership;
        public double WardensCut;
        public double DailyShopRevenue;

        public Finance()
            : base("Finance") {}


        public override void ReadKey(string key, string value) {
            switch (key) {
                case "Balance":
                    Balance = (int)Math.Round(Double.Parse(value));
                    break;
                case "LastDay":
                    LastDay = Int32.Parse(value);
                    break;
                case "LastHour":
                    LastHour = Int32.Parse(value);
                    break;
                case "BankLoan":
                    BankLoan = (int)Math.Round(Double.Parse(value));
                    break;
                case "BankCreditRating":
                    BankCreditRating = Double.Parse(value);
                    break;
                case "Ownership":
                    Ownership = Int32.Parse(value);
                    break;
                case "WardensCut":
                    WardensCut = double.Parse(value);
                    break;
                case "DailyShopRevenue":
                    DailyShopRevenue = double.Parse(value);
                    break;
                default:
                    base.ReadKey(key, value);
                    break;
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Balance", Balance);
            writer.WriteProperty("LastDay", LastDay);
            writer.WriteProperty("LastHour", LastHour);
            writer.WriteProperty("BankLoan", BankLoan);
            writer.WriteProperty("BankCreditRating", BankCreditRating);
            writer.WriteProperty("Ownership", Ownership);
            writer.WriteProperty("WardensCut", WardensCut);
            writer.WriteProperty("DailyShopRevenue", DailyShopRevenue);
        }
    }
}
