using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\kaankrckl\Desktop";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                linkFile.Text = ofd.FileName;
            }
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkFile.Text);
        }

        private void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure to delete the file?",
                                "Sure?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                File.Delete(linkFile.Text);
                linkFile.Text = "";
            }
        }

        private void linkRename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rename r = new Rename(linkFile.Text);
            r.ShowDialog();
            linkFile.Text = r.GetNewFileName();
        }
    }
}
