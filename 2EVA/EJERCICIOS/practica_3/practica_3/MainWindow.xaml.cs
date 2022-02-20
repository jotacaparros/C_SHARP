// --------------------------------------------
// José Manuel Caparrós Ivorra
// Curso 1º DAW
// Modalidad Presencial
// Práctica nº 3
// --------------------------------------------
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

namespace practica_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static bool ok;
        static int progreso;
        public MainWindow()
        {
            InitializeComponent();
            cbProvincia.IsEnabled = false;
            btnAceptar.IsEnabled = false;


            progreso = 0;
           // progressbar();
            pbBarraProgreso.Value = progreso;

        }

        public bool validarCampo()
        {
            ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
            }
            if (txtPrimerApellido.Text == "")
            {
                ok = false;
            }
            if (txtTelefonoUno.Text == "")
            {
                ok = false;
            }
            if (txtCorreo.Text == "")
            {
                ok = false;
            }
            if (txtCp.Text == "")
            {
                ok = false;
            }
            if (txtPoblacion.Text == "")
            {
                ok = false;
            }
            if (cbProvincia.IsEnabled == false)
            {
                ok = false;
            }
            if (cbProvincia.Text == "")
            {
                ok = false;
            }
            return ok;
        }

       /* public void progressbar()
        {
            progreso = 0;

            if (txtPrimerApellido.Text != "")
            {
                progreso++;
            }
            if (txtTelefonoUno.Text != "")
            {
                progreso++;
            }
            if (txtCorreo.Text != "")
            {
                progreso++;
            }
            if (txtCp.Text != "")
            {
                progreso++;
            }
            if (txtPoblacion.Text != "")
            {
                progreso++;
            }
            if (cbProvincia.Text != "")
            {
                progreso++;
            }
        } */

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
                if (rbCliente.IsChecked == true)
                {
                    MessageBox.Show(" INSERT INTO clientes (...) VALUES (...)");
                }
                if (rbDistribuidor.IsChecked == true)
                {
                    MessageBox.Show(" INSERT INTO distribuidores (...) VALUES (...)");
                }
            }


        }
        public class Provincia
        {
            public string ProvinciasNombre { get; set; }
        }

        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            if (rbCliente.IsChecked == true)
            {
                cbProvincia.IsEnabled = true;
            }
            List<Provincia> ListaClientes = new List<Provincia>();

            ListaClientes.Add(new Provincia { ProvinciasNombre = "Albacete" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Alicante" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Castellón" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Cuenca" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Murcia" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Teruel" });
            ListaClientes.Add(new Provincia { ProvinciasNombre = "Valencia" });

            cbProvincia.ItemsSource = ListaClientes;
        }

        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.IsEnabled = true;
            }

            List<Provincia> ListaDistribuidores = new List<Provincia>();

            ListaDistribuidores.Add(new Provincia { ProvinciasNombre = "Alicante" });
            ListaDistribuidores.Add(new Provincia { ProvinciasNombre = "Castellón" });
            ListaDistribuidores.Add(new Provincia { ProvinciasNombre = "Valencia" });

            cbProvincia.ItemsSource = ListaDistribuidores;
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;

            }


        }

        private void txtPrimerApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }

        private void txtTelefonoUno_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }
        private void txtTelefonoUno_PreviewKeyDown(object sender, KeyEventArgs e)

        {
            
            TextBox txt = (TextBox)sender;
            
            if (e.Key == Key.Back || e.Key == Key.Delete)
                return;
            
            if ((int)e.Key < 74)
            {
                if (((int)e.Key < 34 || (int)e.Key > 43))
                    e.Handled = true;
            }
            else if ((int)e.Key > 83
                
                && !((e.Key == Key.OemPeriod || e.Key == Key.Decimal)
                
                && !txt.Text.Contains('.')))
                e.Handled = true;
        }

        private void txtTelefonoDos_PreviewKeyDown(object sender, KeyEventArgs e)

        {
            
            TextBox txt = (TextBox)sender;
            
            if (e.Key == Key.Back || e.Key == Key.Delete)
                return;
            
            if ((int)e.Key < 74)
            {
                if (((int)e.Key < 34 || (int)e.Key > 43))
                    e.Handled = true;
            }
            else if ((int)e.Key > 83
                
                && !((e.Key == Key.OemPeriod || e.Key == Key.Decimal)
           
                && !txt.Text.Contains('.')))
                e.Handled = true;
        }

        private void txtCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }

        private void txtCp_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }

        private void txtPoblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (validarCampo() == true)
            {
                btnAceptar.IsEnabled = true;
            }
        }
    }
}
