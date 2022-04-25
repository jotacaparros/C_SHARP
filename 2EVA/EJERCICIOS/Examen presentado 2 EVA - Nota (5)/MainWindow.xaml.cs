//- - - - - - - - - - - - - - - - - - - - -  
// José Manuel Caparrós Ivorra
// Curso DAW
// Modalidad Presencial
// Examen Segunda Evaluación
//- - - - - - - - - - - - - - - - - - - - -
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

namespace Examen_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ultimaPosicionCliente = 0;
        int ultimaPosicionDistribuidor = 0;
        Distribuidor[] distribuidores = new Distribuidor[10];
        Cliente[] clientes = new Cliente[10];
        Random generadorRandom = new Random();

        String[] provinciasDistribuidor = new String[7];
        String[] provinciasCliente = new String[3];
        public MainWindow()
        {
            InitializeComponent();


          
            clientes[ultimaPosicionCliente] = new Cliente();
            distribuidores[ultimaPosicionDistribuidor] = new Distribuidor();

        }

        public bool ComprobarFormulario()
        {
            if( txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtTelefono2.Text != "" && txtDireccion.Text != "" && txtCorreo.Text != "" && ComprobarRadioButton() != false )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ComprobarRadioButton()
        {
            if (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if(ComprobarFormulario())
            {
                if(rbCliente.IsChecked == true)
                {
                    altaCliente();
                }
                else
                {
                                  
                }

            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {

            rbCliente.IsChecked = true;
            lblCodigoIdentificador.Content = codigoRandom();
            
             
            // Aqui meteria las provincias al combobox de cliente  de cbProvincia.Items.Add()
        }

        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            rbDistribuidor.IsChecked = true;
            //aqui haria el codigo con el regex
        }

        private void altaCliente()
        {
            // haria try catch para que no diera error con un el tema de meter caracters en el telefono
            clientes[ultimaPosicionCliente].SetNombreCliente(txtNombre.Text);
            clientes[ultimaPosicionCliente].SetApellidoCliente(txtApellido.Text);
            clientes[ultimaPosicionCliente].SetTelefono1Cliente(Convert.ToInt32(txtTelefono.Text));
            clientes[ultimaPosicionCliente].SetTelefono2Cliente(Convert.ToInt32(txtTelefono2.Text));
            clientes[ultimaPosicionCliente].SetCorreoCliente(txtCorreo.Text);
            clientes[ultimaPosicionCliente].SetDireccionCliente(txtDireccion.Text);
            clientes[ultimaPosicionCliente].SetCodigoCliente(codigoRandom());

          
        }

        private string codigoRandom()
        {
            int codigo;
            string codigoDef;
            codigo = generadorRandom.Next(10000);
            
            if(codigo < 1000)
            {
               codigoDef = codigo.ToString().PadLeft(4, '0');
                return codigoDef;
            }
            else
            {
                codigoDef = codigo.ToString();
                return codigoDef;
            }
            
        }




    }
}
