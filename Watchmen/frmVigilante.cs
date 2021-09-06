using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchmen
{
    public partial class frmVigilante : Form
    {
        public frmVigilante()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            if (fbFolder.ShowDialog(this) == DialogResult.OK) {
                txtFolder.Text = fbFolder.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
