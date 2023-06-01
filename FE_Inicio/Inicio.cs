using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Cuentas;

namespace Cuenta
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Cuentas cuentas = new Cuentas();
            dtgv_datos.DataSource = cuentas.DTusuarios;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            IniSes inises = new IniSes();
            inises.Show();
            this.Close();
        }
    }
}
