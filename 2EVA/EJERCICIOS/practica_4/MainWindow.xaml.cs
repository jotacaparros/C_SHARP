//---------------------------------------------------------------------
// José Manuel Caparrós Ivorra
// Curso DAW
// Modalidad Presencial
// Práctica nº 4
//---------------------------------------------------------------------


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

namespace practica_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickarBotonBanco(object sender, RoutedEventArgs e)
        {
            Banco MiVentanaBanco = new Banco();
            MiVentanaBanco.Owner = this;
            MiVentanaBanco.Show();
        }

        private void ClickarBotonFormulario(object sender, RoutedEventArgs e)
        {
            Formulario MiVentanaFormulario = new Formulario();
            MiVentanaFormulario.Owner = this;
            MiVentanaFormulario.Show();
        }

        private void ClickarBotonSucursal(object sender, RoutedEventArgs e)
        {
            Sucursal MiVentanaSucursal = new Sucursal();
            MiVentanaSucursal.Owner = this;
            MiVentanaSucursal.Show();
        }
    }
}
