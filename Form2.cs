using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pnl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }
        int counter = 0;
        private void pnl1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            /*{ @"C:\Users\kaankrckl\Desktop\myNewFile..txt", 
                                 @"C:\Users\kaankrckl\Desktop\my meetings - Copy.txt",
                                 @"C:\Users\kaankrckl\Desktop\asdasd.txt", 
                                @"C:\Users\kaankrckl\Desktop\my meetings.txt"};
            */

            for (int i = 0; i < filenames.Length; i++)
            {
                FileInfo f = new FileInfo();
                f.Location = new Point(0, 30 * counter);
                //f.linkLabel3.Text = filenames[i];
                //f.setFileName(filenames[i]);
                f.FILETEXT = filenames[i];
                pnl2.Controls.Add(f);
                counter++;
            }
        }
    }
}
