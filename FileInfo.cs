using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class FileInfo : UserControl
    {
        public FileInfo()
        {
            InitializeComponent();
        }

        //public void setFileName(String filename)
        //{
        //    linkLabel3.Text = filename;
        //}

        
        public String FILETEXT
        {
            get { return linkLabel3.Text; }
            set { linkLabel3.Text = value; }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel3.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.IO.File.Delete(linkLabel3.Text);
            linkLabel1.Enabled = linkLabel2.Enabled = linkLabel3.Enabled = false;
            linkLabel1.Font = linkLabel2.Font = linkLabel3.Font = 
                new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rename r = new Rename(linkLabel3.Text);
            r.ShowDialog();
            linkLabel3.Text = r.GetNewFileName();
        }
        
    }
}
