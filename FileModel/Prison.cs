using System;
using System.Linq;

namespace PASaveEditor.FileModel {
    internal class Prison : Node {
        public string Version;
        public double TimeIndex;
        public bool EnabledMisconduct;
        public bool FailureConditions;
        public bool EnabledVisibility;
        public bool EnabledDecay;
        public bool UnlimitedFunds;
        public bool EnabledIntake;

        public readonly WrapperNode<ContrabandPrisoners> Contraband =
            new WrapperNode<ContrabandPrisoners>("Contraband", "Prisoners", l => new ContrabandPrisoners(l));

        public readonly Finance Finance = new Finance();

        public readonly WrapperNode<Informants> Informants
            = new WrapperNode<Informants>("Informants", "Informants", l => new Informants(l));

        public readonly Misconduct Misconduct = new Misconduct();

        public readonly Objects Objects = new Objects();

        public readonly WrapperNode<Penalties> Penalties
            = new WrapperNode<Penalties>("Penalties", "Penalties", l => new Penalties(l));

        public readonly Reform Reform = new Reform();

        public readonly Research Research = new Research();

        public readonly Tunnels Tunnels = new Tunnels();

        public readonly WrapperNode<VictoryLog> Victory
            = new WrapperNode<VictoryLog>("Victory", "Log", l => new VictoryLog(l));


        public Prison()
            : base("Prison", true) {}


        public override void ReadKey(string key, string value) {
            switch (key) {
                case "Version":
                    Version = value;
                    break;
                case "TimeIndex":
                    TimeIndex = Double.Parse(value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                    break;
                case "EnabledMisconduct":
                    EnabledMisconduct = Boolean.Parse(value);
                    break;
                case "FailureConditions":
                    FailureConditions = Boolean.Parse(value);
                    break;
                case "EnabledVisibility":
                    EnabledVisibility = Boolean.Parse(value);
                    break;
                case "EnabledDecay":
                    EnabledDecay = Boolean.Parse(value);
                    break;
                case "UnlimitedFunds":
                    UnlimitedFunds = Boolean.Parse(value);
                    break;
                case "EnabledIntake":
                    EnabledIntake = Boolean.Parse(value);
                    break;
                default:
                    base.ReadKey(key, value);
                    break;
            }
        }


        public override Node CreateNode(string label) {
            switch (label) {
                case "Contraband":
                    return Contraband;
                case "Finance":
                    return Finance;
                case "Informants":
                    return Informants;
                case "Misconduct":
                    return Misconduct;
                case "Objects":
                    return Objects;
                case "Penalties":
                    return Penalties;
                case "Reform":
                    return Reform;
                case "Research":
                    return Research;
                case "Tunnels":
                    return Tunnels;
                case "Victory":
                    return Victory;
                default:
                    return base.CreateNode(label);
            }
        }


        public override void WriteProperties(Writer writer) {
            writer.WriteProperty("Version", Version);
            writer.WriteProperty("TimeIndex", TimeIndex);
            if (EnabledMisconduct) {
                writer.WriteProperty("EnabledMisconduct", EnabledMisconduct);
            }
            if (FailureConditions) {
                writer.WriteProperty("FailureConditions", FailureConditions);
            }
            if (EnabledVisibility) {
                writer.WriteProperty("EnabledVisibility", EnabledVisibility);
            } else {
                Nodes.Remove("Visibility");
            }
            if (EnabledDecay) {
                writer.WriteProperty("EnabledDecay", EnabledDecay);
            } else {
                // erase all dirt
                var cellNodes = Nodes["Cells"][0].ListNodes().ToList();
                cellNodes.ForEach(node => node.Properties.Remove("Con"));
            }
            if (UnlimitedFunds) {
                writer.WriteProperty("UnlimitedFunds", UnlimitedFunds);
            }
            if (EnabledIntake) {
                writer.WriteProperty("EnabledIntake", EnabledIntake);
            }
        }


        public override void WriteNodes(Writer writer) {
            writer.WriteNode(Objects);
            writer.WriteNode(Finance);
            writer.WriteNode(Research);
            writer.WriteNode(Penalties);
            writer.WriteNode(Misconduct);
            writer.WriteNode(Contraband);
            writer.WriteNode(Tunnels);
            writer.WriteNode(Reform);
            writer.WriteNode(Victory);
            writer.WriteNode(Informants);
        }
    }
}
