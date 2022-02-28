using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Práctica3Solucion
{
    public partial class MainWindow : Window
    {
        public static bool existe = true;
        public static string tipo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Validation(object sender, TextCompositionEventArgs e)
        {
            // Expresión regular para solo permitir dígitos
            // pero dejaría introducir espacios en blanco
            Regex regex = new Regex("[^0-9]+");

            // Utilizamos los parámetros de la función para solo escribir
            // el texto si coincide con el patrón de la expresión regular
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ComprobarFormulario();
        }

        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            tipo = "Cliente";
            combo(0);
            
        }
        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            tipo = "Distribuidor";
            combo(1);
        }

        private void combo(int x)
        {
            if (existe)
            {
                ComboBox c = (ComboBox)primero.Children[22];

                if (x == 0)
                {
                    c.Items.Clear();
                    c.Items.Add("Alicante");
                }
                else
                {
                    c.Items.Clear();
                    c.Items.Add("Elche");
                }
            }
            else
            {
                ComboBox c = new ComboBox();
                c.HorizontalAlignment = HorizontalAlignment.Left;
                c.VerticalAlignment = VerticalAlignment.Top;
                c.Height = 20;
                c.Width = 120;
                c.Margin = new Thickness(471, 199, 0, 0);

                if (tipo == "Cliente")
                {
                    c.Items.Add("Alicante");
                }
                else
                {
                    c.Items.Add("Elche");
                }
                   

                primero.Children.Add(c);
                existe = true;
            }
        }

        public void ComprobarFormulario()
        {
            if (txtNombre.Text != ""
                && txtApellido1.Text != ""
                && (rbCliente.IsChecked == true
                || rbDistribuidor.IsChecked == true)
                && txtTelefono1.Text != ""
                && txtEmail.Text != ""
                && txtDireccion.Text != ""
                && txtPostal.Text != ""
                && txtPoblacion.Text != "")

                btnEnviar.IsEnabled = true;
            else
                btnEnviar.IsEnabled = false;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (rbCliente.IsChecked == true)
                MessageBox.Show("INSERT INTO clientes (....) VALUES (...)");
            else
                MessageBox.Show("INSERT INTO distribuidores (...) VALUES (...)");
        }


    }
}