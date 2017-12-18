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
using static SearchExtension.Program;

namespace SearchExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring plikow");
            if (key.GetValue("Path") == null)
            {
                tBPath.Text = "";
            }
            else
            {
                tBPath.Text = key.GetValue("Path").ToString();
                string[] files = Directory.GetFiles(key.GetValue("Path").ToString());
                string[] dirs = Directory.GetDirectories(key.GetValue("Path").ToString());

                foreach (string item2 in dirs)
                {

                    FileInfo f = new FileInfo(item2);


                    DirectoryInfo dir = new DirectoryInfo(item2);

                    var x = dir.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);


                    listBox1.Items.Add(f.Name + " waga profilu: " + x / 1024 / 1024 + "MB");

                    using (var db = new ExtensionContext())
                    {

                        var query = from c in db.ExtensionDB
                                 
                                    select new { c.ListId, c.Extension };

                        var listWithQuery = query.ToList();

                        dataGridView1.DataSource = listWithQuery;
                       
                    }
                }
            }
        }

       string StringExtension;




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
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring plikow");
            string path = key.GetValue("Path").ToString();

            using (var db = new ExtensionContext())
            {
                var query = from c in db.ExtensionDB

                            select new { c.Extension };

                foreach (var item in query)
                {
                    StringExtension += "|*." + item.Extension + "";
                }
            }

            StringExtension = StringExtension.Substring(1, StringExtension.Length -1);
                Array files = GetFiles(@"" + path + "", ""+StringExtension+"", SearchOption.AllDirectories);
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

        private void bLoadPath_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {

                tBPath.Text = fbd.SelectedPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

                foreach (string item2 in dirs)
                {

                    FileInfo f = new FileInfo(item2);


                    DirectoryInfo dir = new DirectoryInfo(item2);

                    var x = dir.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);


                    listBox1.Items.Add(f.Name + " waga profilu: " + x / 1024 / 1024 + "MB");
                    //using (var db = new UsersContext())
                    //{

                    //    var query = from c in db.UserInformation
                    //                where c.Name == f.Name
                    //                select new { c.Name, c.Email, c.UsersInformationsId };

                    //    if (query.ToList().Count < 1)
                    //    {
                    //        var UserFolderSave = new UsersInformations { Name = f.Name };

                    //        db.UserInformation.Add(UserFolderSave);
                    //        db.SaveChanges();
                    //    }
                    //    else
                    //    {
                    //        // rekordy już są - nie trzeba nic robić
                    //    }


                    //}

                }
                //   MessageBox.Show("" + fbd.SelectedPath + "");

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring plikow");
                key.SetValue("Path", "" + fbd.SelectedPath + "");
                key.Close();

                // wypisanie plików
                //foreach (string item in files)
                //{
                //    FileInfo f = new FileInfo(item);

                //    listBox1.Items.Add(f.Name + "i waży plik:" +f.Length/1024/1024 + " MB");

                //}
            }
            else
            {
                MessageBox.Show("Musisz wskazać ścieżkę - nie wolno anulować", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbWybranaOpcjaSprawdzania_SelectedIndexChanged(object sender, EventArgs e)
        {
            // wyłączenie / włączenie opcji sprawdzania o danej godznie albo co jakiś czas
            if (cbWybranaOpcjaSprawdzania.SelectedIndex == 0)
            {
                cBGodzina.Enabled = true;
                cBMinuta.Enabled = true;
                cBSekunda.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                nUDCoIleMinut.Enabled = false;
                lWykonujCo.Enabled = false;
                lMinuty.Enabled = false;

            }
            else if (cbWybranaOpcjaSprawdzania.SelectedIndex == 1)
            {
                cBGodzina.Enabled = false;
                cBMinuta.Enabled = false;
                cBSekunda.Enabled = false;
                nUDCoIleMinut.Enabled = true;
                lWykonujCo.Enabled = true;
                lMinuty.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
            }
        }

        private void bEditEmail_Click(object sender, EventArgs e)
        {
            using (var db = new ExtensionContext())
            {

                var Record = new ListExtension.List { Extension = tBEditEmail.Text.Trim() };

                db.ExtensionDB.Add(Record);
                db.SaveChanges();

            }


            using (var db = new ExtensionContext())
            {
                var query = from c in db.ExtensionDB

                            select new { Id = c.ListId, c.Extension };

                var results = query.ToList();

                dataGridView1.DataSource = results;


            }
        }

        public void RefleshDataGrid()
        {
            using (var db = new ExtensionContext())
            {
                var query = from c in db.ExtensionDB

                            select new { Id = c.ListId, c.Extension };

                var results = query.ToList();

                dataGridView1.DataSource = results;


            }
        }


        private void tBEditEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bEditEmail_Click(sender, null);
            }
        }

        private void bDeleteRecords_Click(object sender, EventArgs e)
        {
     
            using (var db = new ExtensionContext())
            {

                var query = from c in db.ExtensionDB

                            select new { c.ListId };
               
                if (query.ToList().Count >= 1)
                {
                    foreach (var item in query)
                    {
                        using (var dbx = new ExtensionContext())
                        {
                            int x = Convert.ToInt32(item.ListId.ToString());
                            var delete = new ListExtension.List { ListId = x };
                            dbx.ExtensionDB.Attach(delete);
                            dbx.ExtensionDB.Remove(delete);
                            dbx.SaveChanges();
                        }
                    }
                }
                RefleshDataGrid();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
