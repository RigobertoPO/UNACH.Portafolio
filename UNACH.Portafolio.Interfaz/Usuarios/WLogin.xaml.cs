using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UNACH.Portafolio.Logica;

namespace UNACH.Portafolio.Interfaz.Usuarios
{
    /// <summary>
    /// Lógica de interacción para WLogin.xaml
    /// </summary>
    public partial class WLogin : Window
    {
        public WLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            UsuariosMetodos usuario = new UsuariosMetodos();
            var resultado = usuario.ValidarUsuario(txtUsuario.Text,
                pwbPassword.Password);
            if (resultado != null)
            {
                this.Hide();
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
