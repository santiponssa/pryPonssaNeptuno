using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaNeptuno
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength > 0 & txtContraseña.TextLength > 0)
            {
                FrmBD frm = new FrmBD();
                this.Hide();
                frm.ShowDialog();
                
            }
        }
    }
}
