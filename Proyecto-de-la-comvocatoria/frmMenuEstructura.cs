using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_la_comvocatoria
{
    public partial class frmMenuEstructura : Form
    {
        public frmMenuEstructura()
        {
            InitializeComponent();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            using (var form = new frmPila())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            using (var form = new frmCola())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }
    }
}
