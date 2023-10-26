using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pROOVEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProovedor proovedor = new frmProovedor();
            proovedor.ShowDialog();         

        }

        private void aRTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos articulos = new frmArticulos();
            articulos.ShowDialog(); 
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
