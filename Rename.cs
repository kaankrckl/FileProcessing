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
    public partial class Rename : Form
    {
        public Rename(String filename)
        {
            InitializeComponent();
            linkFileName.Text = filename;
            txtNewFileName.Text = Path.GetFileName(filename);
        }

        public String GetNewFileName()
        {
            return Path.GetDirectoryName(linkFileName.Text) + "\\" + txtNewFileName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Move(linkFileName.Text,
                Path.GetDirectoryName(linkFileName.Text) + "\\" + txtNewFileName.Text);
            Close();
        }
    }
}
