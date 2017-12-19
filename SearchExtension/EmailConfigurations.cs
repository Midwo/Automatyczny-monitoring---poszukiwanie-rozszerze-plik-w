using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchExtension
{
    public partial class EmailConfigurations : Form
    {
        public EmailConfigurations()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPort.Text = "587";
            tbSmtp.Text = "smtp.gmail.com";
        }
    }
}
