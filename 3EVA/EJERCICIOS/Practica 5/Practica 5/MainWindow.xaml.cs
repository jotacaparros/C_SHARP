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
            
          
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {

        }

        public void GuardarDatos(Cliente c)
        {
            // parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            listaClientes.Add(new Cliente() { Cliente.SetNombre(txtNombre.Text), Cliente.SetApellido(txtApellido)  });


            /*Cliente.nombre = txtNombre.Text;
            ape = txtApellido.Text;
            pro = lbProvincia.*/
        }
    }
}
