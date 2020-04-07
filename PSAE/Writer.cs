using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using PASaveEditor.FileModel;

namespace PASaveEditor {
    internal class Writer : IDisposable {
        int indent;
        readonly TextWriter writer;
        bool isInline;
        readonly Stack<bool> inlineStack = new Stack<bool>();


        public Writer(FileStream fs) {
            writer = new StreamWriter(fs, Encoding.ASCII);
        }


        public void WritePrison(Prison prison) {
            writer.Write('\n');
            WriteNodeData(prison);
        }


        public void WriteProperty(string key, double value) {
            WriteProperty(key, value.ToString("#.0####", CultureInfo.InvariantCulture));
        }


        public void WriteProperty(string key, int value) {
            WriteProperty(key, value.ToString(CultureInfo.InvariantCulture));
        }


        public void WriteProperty(string key, bool value) {
            WriteProperty(key, value ? "true" : "false");
        }


        public void WriteProperty(string key, string value) {
            if (value == null) return;
            if (!isInline) {
                for (int i = 0; i < indent; i++) {
                    writer.Write("    ");
                }
            }
            WriteValue(key);
            writer.Write(' ');
            WriteValue(value);
            if (isInline) {
                writer.Write("  ");
            } else {
                writer.Write("\n");
            }
        }


        public void WriteNode(Node node) {
            if (node == null) return;
            inlineStack.Push(isInline);
            isInline = (node.Nodes == null) &&
                       (node.Properties == null || node.Properties.Count < 6) &&
                       !node.DoNotInline;

            for (int i = 0; i < indent; i++) {
                writer.Write("    ");
            }
            indent++;

            writer.Write("BEGIN ");
            WriteValue(node.Label);
            if (isInline) {
                writer.Write("  ");
            } else {
                writer.Write("\n");
            }

            WriteNodeData(node);

            indent--;
            if (!isInline) {
                for (int i = 0; i < indent; i++) {
                    writer.Write("    ");
                }
            }
            writer.Write("END\n");

            isInline = inlineStack.Pop();
        }


        void WriteNodeData(Node node) {
            node.WriteProperties(this);
            if (node.Properties != null) {
                foreach (var property in node.Properties) {
                    foreach (string value in property.Value) {
                        WriteProperty(property.Key, value);
                    }
                }
            }
            node.WriteNodes(this);
            if (node.Nodes != null) {
                foreach (var nodeSet in node.Nodes) {
                    foreach (Node value in nodeSet.Value) {
                        WriteNode(value);
                    }
                }
            }
        }


        void WriteValue(string value) {
            bool doQuote = (value.IndexOf(' ') >= 0);
            if (doQuote) {
                writer.Write('"');
            }
            writer.Write(value);
            if (doQuote) {
                writer.Write('"');
            }
        }


        public void Dispose() {
            if (writer != null) {
                writer.Close();
                writer.Dispose();
            }
        }
    }
}
