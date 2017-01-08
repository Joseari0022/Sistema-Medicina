using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace SistemaJGMedicina.Registros
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Idbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void LlenarUsuario(Usuarios usuario)
        {
            IdtextBox.Text = usuario.UsuarioId.ToString();
            NombretextBox.Text = usuario.Nombres;
            ContrasenatextBox.Text = usuario.Contrasena;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            LlenarClase(usuario);
            //UsuarioBll
        }

        private void LlenarClase(Usuarios u)
        {
            u.Nombres = NombretextBox.Text;
            u.Contrasena = ContrasenatextBox.Text;
        }
    }
}
