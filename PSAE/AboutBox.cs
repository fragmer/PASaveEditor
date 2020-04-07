using System;
using System.Drawing;
using System.Windows.Forms;

namespace PASaveEditor {
    public partial class AboutBox : Form {
        public AboutBox() {
            InitializeComponent();
            richTextBox1.Text = String.Format(richTextBox1.Text, Program.Version, Parser.SupportedVersion);
            richTextBox1.Select(0, richTextBox1.Lines[0].Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
            bClose.Select();
        }

        private void bClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
