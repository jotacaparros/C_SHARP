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
    { //Donde guardo la lista de objetos clientes? en el main o en el global?
        public List<Cliente> listaClientes = new List<Cliente>();
        public MainWindow()
        {
           

            InitializeComponent();

           

            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Valencia");

        }

       

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            //Cómo paso los datos a una lista clientes y que se vea en listbox?
            Cliente clientes = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
            listaClientes.Add(clientes);

            //listaClientes.Add(new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text));
            lbxClientes.Items.Add(clientes.infoLb());

            
        }

       
    }
}
