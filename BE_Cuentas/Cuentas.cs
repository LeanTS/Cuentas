using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Cuentas
{
    public class Cuentas
    {
        public int ID;
        public DataTable DTusuarios { get; set; } = new DataTable();

        public Cuentas()
        {
            DTusuarios.TableName = "Cuentas";
            DTusuarios.Columns.Add("ID", typeof(int));
            DTusuarios.Columns.Add("Usuario", typeof(string));
            DTusuarios.Columns.Add("Contraseña", typeof(string));
            DTusuarios.Columns.Add("Nombre", typeof(string));
            DTusuarios.Columns.Add("Apellido", typeof(string));
            DTusuarios.Columns.Add("Edad", typeof(int));
            DTusuarios.Columns.Add("Fecha_de_nacimiento", typeof(DateTime));
            DTusuarios.Columns.Add("Telefono", typeof(string));
            DTusuarios.Columns.Add("Email", typeof(string));
            DTusuarios.Columns.Add("Creacion", typeof(DateTime));

            Leer_DTusuarios();
        }

        private void Leer_DTusuarios()
        {
            if (File.Exists(@"D:\ProgramasVS2022\BE_Cuentas\TablaUsers.xml") == true)
            {
                DTusuarios.ReadXml(@"D:\ProgramasVS2022\BE_Cuentas\TablaUsers.xml");
            }
        }

        public string Verifica_campos(string user, string pass, string nom, string ape, string email, string tel, DateTime nacim, DateTime hoy)
        {//verifica email y fecha de nacimiento
            for (int i = 0;DTusuarios.Rows.Count > i; i++)
            {
                string veremail = DTusuarios.Rows[i]["Email"].ToString();
                string veruser = DTusuarios.Rows[i]["Usuario"].ToString();
                if (veruser == user)
                {
                    return "existe";
                }
                else if (veremail == email)
                {
                    return "email existe";
                }
                else if (nacim.Year >= 2007)
                {
                    return "menor 16";
                }
            }
            if (user != "" &&  pass !="" &&  nom != "" &&  ape != "" && email != "" && tel != "" && nacim != hoy)
            {
                return "Crear";
            }
            else
            {
                return "incompleto";
            }

        }

        public int GenerarID()
        {//genera un ID
            ID = DTusuarios.Rows.Count;

            return ID;
        }

        public bool CargarUsuario(Usuario usuario)
        {
            //carga la cuenta nueva
            DTusuarios.Rows.Add();
            int i = DTusuarios.Rows.Count - 1;
            DTusuarios.Rows[i]["ID"] = usuario.ID;
            DTusuarios.Rows[i]["Usuario"] = usuario.User;
            DTusuarios.Rows[i]["Contraseña"] = usuario.Contraseña;
            DTusuarios.Rows[i]["Nombre"] = usuario.Nombre;
            DTusuarios.Rows[i]["Apellido"] = usuario.Apellido;
            DTusuarios.Rows[i]["Edad"] = usuario.Edad;
            DTusuarios.Rows[i]["Fecha_de_nacimiento"] = usuario.Fecha_Nacimiento;
            DTusuarios.Rows[i]["Telefono"] = usuario.Telefono;
            DTusuarios.Rows[i]["Email"] = usuario.Email;
            DTusuarios.Rows[i]["Creacion"] = usuario.Creacion;

            DTusuarios.WriteXml(@"D:\ProgramasVS2022\BE_Cuentas\TablaUsers.xml");

            return true;
        }


        public string VerificaIngreso(string user, string contra)
        {//verifica usuario y contraseña
            for (int i = 0; i < DTusuarios.Rows.Count; i++)
            {
                string userver = DTusuarios.Rows[i]["Usuario"].ToString();
                string contraver = DTusuarios.Rows[i]["Contraseña"].ToString();

                if (user == userver && contra == contraver)
                {
                    return "ingreso";
                }
                else if (user == userver && contra != contraver)
                {
                    return "contra incorrecta";
                }
            }
            return "no existe";
        }
    }
}
