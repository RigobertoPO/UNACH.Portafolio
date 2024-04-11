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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UNACH.Portafolio.Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Usuarios.WLogin login = new Usuarios.WLogin();
            login.ShowDialog();
            //UNACH.Portafolio.Logica.AreasMetodos area =
            //    new Logica.AreasMetodos();
            //dtgAreas.ItemsSource = area.ObtenerAreas();
        }

        private void btnAreas_Click(object sender, RoutedEventArgs e)
        {
            Areas.UCAreas _areas = new Areas.UCAreas();
            EspacioTrabajo.Children.Clear();
            EspacioTrabajo.Children.Add(_areas);
                
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Usuarios.UCUsuarios _usuarios = new Usuarios.UCUsuarios();
            EspacioTrabajo.Children.Clear();
            EspacioTrabajo.Children.Add(_usuarios);
        }
    }
}
