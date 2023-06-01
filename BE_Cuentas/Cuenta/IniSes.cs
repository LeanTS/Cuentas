using BE_Cuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta
{
    public partial class IniSes : Form
    {
        Cuentas cuentas = new Cuentas();
        public IniSes()
        {
            InitializeComponent();
        }

        private void linklb_crear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearCuenta crear = new CrearCuenta();
            crear.Show();

            this.Hide();

        }

        private void IniSes_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            string veringreso = cuentas.VerificaIngreso(txb_usuario.Text,txb_contraseña.Text);

            if (veringreso == "ingreso")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
            else if (veringreso == "contra incorrecta")
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else if (veringreso == "no existe")
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
