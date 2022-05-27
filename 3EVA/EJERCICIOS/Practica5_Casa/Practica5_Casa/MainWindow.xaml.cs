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
        Cliente listado;
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

            if (txtNombre.Text != "" && txtApellido.Text != "" && cbProvincia.SelectedItem != null)
            {
                listaClientes.Add(clientes);

                //listaClientes.Add(new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text));
                lbxClientes.Items.Add(clientes.infoLb());

                txtNombre.Clear();
                txtApellido.Clear();
            }
            else { MessageBox.Show("Por favor rellena los campos antes de añadir"); }

        }

       
        private void lbxClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxClientes.Items != null)
            {
                btnAnadir.IsEnabled = false;
            }

            //if (txtapellido.isselectionactive == true)
            //{
            //    btnanadir.isenabled = true;
            //}


            /* lbxClientes.SelectedItem = listado;
             listado.GetApellido();
             listaClientes[*/
            //istado.SetProvincia(cbProvincia.SelectedItem);
            //stado.SetApellido(txtApellido.Text);
        }

        private void txtNombre_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadir.IsEnabled = true;
        }

        private void txtApellido_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadir.IsEnabled = true;
        }
    }
}
