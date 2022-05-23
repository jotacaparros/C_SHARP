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

namespace Practica_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Cliente> listaClientes = new List<Cliente>(); //Donde guardo la lista de objetos clientes? en el main o en el global?

        public MainWindow()
        {

            InitializeComponent();
            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Valencia");

           /* List<Provincias> listaProvincias = new List<Provincias>();
            listaProvincias.Add(new Provincias { NombreProvincia = "Alicante" });
            listaProvincias.Add(new Provincias { NombreProvincia = "Castellón" });
            listaProvincias.Add(new Provincias { NombreProvincia = "Valencia" });

            cbProvincia.ItemsSource = listaProvincias;

        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {

        }

        public void GuardarDatos(Cliente c)
        {
            // parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            //listaClientes.Add(new Cliente() { Cliente.SetNombre(txtNombre.Text), Cliente.SetApellido(txtApellido.Text), Cliente.SetProvincia(cbProvincia.SelectedItem)});
            // Cliente listaClientes = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
            //listaCliente.Add(cliente1);

            /*Cliente.nombre = txtNombre.Text;
            ape = txtApellido.Text;
            pro = lbProvincia.*/
        }

        private void cbProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        public class Provincias
        {
            public string NombreProvincia { get; set; }
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            Cliente clientes = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
            listaClientes.Add(clientes);
        }

        private void btnMostrarInfo_Click(object sender, RoutedEventArgs e)
        {
            lstListaClientes.ItemsSource = listaClientes;

        }
    }
}
