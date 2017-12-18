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

namespace SearchExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    // Only get files that begin with the letter "c."
            //    string[] dirs = Directory.GetFiles(@"C:\Users\micha\Downloads", "*.mp4|*.jpg");
            //    string x = String.Format("The number of files starting with c is {0}.", dirs.Length);
            //    MessageBox.Show(x);
            //    foreach (string dir in dirs)
            //    {
            //        MessageBox.Show(dir);
            //    }
            //}
            //catch (Exception x)
            //{
            //    string y = String.Format("The process failed: {0}", x.ToString());
            //    MessageBox.Show(y);
            //}

            Array files =  GetFiles(@"C:\Users\micha\Downloads", "*.jpg|*.mp4", SearchOption.AllDirectories);
            MessageBox.Show(files.Length.ToString());
            foreach (var item in files)
            {
                MessageBox.Show(item.ToString());
            }
        }


        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] searchPatterns = searchPattern.Split('|');
            List<string> files = new List<string>();
            foreach (string sp in searchPatterns)
                files.AddRange(System.IO.Directory.GetFiles(path, sp, searchOption));
            files.Sort();
            return files.ToArray();
          
        }
    }
}
