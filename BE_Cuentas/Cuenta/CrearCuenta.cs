using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Cuentas;

namespace Cuenta
{
    public partial class CrearCuenta : Form
    {
        Cuentas cuentas = new Cuentas();
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            IniSes iniSes = new IniSes();
            iniSes.Show();
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            DateTime fechaCreacion = DateTime.Now; //fecha del dia actual
            DateTime fechaNacimiento = new DateTime(mcal_fechnaci.SelectionStart.Year, mcal_fechnaci.SelectionStart.Month, mcal_fechnaci.SelectionStart.Day); //datos del calendario
            char id = cuentas.GenerarID(); //crea un ID

            int edad = fechaCreacion.Year - fechaNacimiento.Year;

            string verificacion = cuentas.Verifica_campos(txb_user.Text, txb_contraseña.Text, txb_nombre.Text, txb_apellido.Text, txb_email.Text, txb_telefono.Text, fechaNacimiento, fechaCreacion);

            if (verificacion == "Crear")
            { //envia datos para cargar usuario
                usuario.ID = id;
                usuario.User = txb_user.Text;
                usuario.Contraseña = txb_contraseña.Text;
                usuario.Nombre = txb_nombre.Text;
                usuario.Apellido = txb_apellido.Text;
                usuario.Edad = edad;
                usuario.Fecha_Nacimiento = fechaNacimiento;
                usuario.Telefono = Convert.ToInt32(txb_telefono.Text);
                usuario.Email = txb_email.Text;
                usuario.Creacion = fechaCreacion;

                MessageBox.Show("tu cuenta fue creada con exito");

                IniSes inises = new IniSes();
                inises.Show();
                this.Close();
            }

            else if (verificacion == "menor 16")
            { //verifica edad
                MessageBox.Show("Tienes que ser mayo de 16 para crear una cuenta");
            }

            else if (verificacion == "existe")
            { //Verifica usuario
                MessageBox.Show("Ese Usuario ya existe, pruebe cambiarlo");
            }

            else if (verificacion == "email existe")
            {//verifica email
                MessageBox.Show("Ya existe una cuenta con ese correo");
            }

            else if (verificacion == "incompleto")
            {//Verifica campos
                MessageBox.Show("Faltan campos por completar");
            }

        }

        private void txb_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
