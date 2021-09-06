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

namespace Watchmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoVigilanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVigilante frmVigilante = new frmVigilante();
            frmVigilante.ShowDialog(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmVigilante frmVigilante = new frmVigilante();
            if (frmVigilante.ShowDialog(this) == DialogResult.OK)
            {
                ListViewItem itm = new ListViewItem();

                itm.Text = (lst.Items.Count + 1).ToString();

                FileSystemWatcher fs = new FileSystemWatcher();
                fs.IncludeSubdirectories = false;

                lst.Items.Add(itm);
            };
        }
    }
}
