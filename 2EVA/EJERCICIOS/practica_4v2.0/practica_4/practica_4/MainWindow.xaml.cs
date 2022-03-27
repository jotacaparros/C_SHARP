//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// José Manuel Caparrós Ivorra
// Curso DAW
// Modalidad Presencial
// Práctica nº 4
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //Declaro arrays de tipo cliente y sucursal, con un delimitador para controlar las posiciones 
        Sucursal[] sucursales = new Sucursal[10];
        int ultimaPosicionSucursal = 0;
        Cliente[] clientes = new Cliente[10];
        int ultimaPosicionCliente = 0;
        Random generadorRandom = new Random();

        public MainWindow()
        {
            InitializeComponent();
            tabBanco.Visibility = Visibility.Hidden;
            tabFormulario.Visibility = Visibility.Hidden;
            
            //Inicio los array de objetos para que no me den problemas en las comprobaciones
            sucursales[0] = new Sucursal();
            clientes[0] = new Cliente();

        }


        /*- - - - - - - - - - - - - - Botones y eventos Click - - - - - - - - - - - - - -*/
        private void Banco_Click(object sender, RoutedEventArgs e)
        {
            tabFormulario.Visibility = Visibility.Hidden;
            tabBanco.Visibility = Visibility.Visible;
        }

        private void Formulario_Click(object sender, RoutedEventArgs e)
        {
            tabBanco.Visibility = Visibility.Hidden;
            tabFormulario.Visibility = Visibility.Visible;
        }
        
        private void btnCrearAltaSucursal_Click(object sender, RoutedEventArgs e)
        {
            // Si pasa la comprobación das de alta y limpias los campos
            if(comprobarFormularioSucursal())
            {
                darAltaSucursal();
                txtCiudadSucursalAlta.Clear();
                txtUbicacionSucursalAlta.Clear();
                txtCpSucursalAlta.Clear();
                tabFormulario_SelectionChanged(null, null);
            }
            else
            {
                MessageBox.Show("Por favor rellena todos los campos");
            }

          
        }

        private void btnCrearAltaCliente_Click(object sender, RoutedEventArgs e)
        {
            // Si pasa la comprobación das de alta y limpias los campos
            if (comprobarFormularioCliente())
            {
                darAltaCliente();
                txtDniClienteAlta.Clear();
                txtNombreClienteAlta.Clear();
                txtApellidoClienteAlta.Clear();
                cbSucursalesAltaCliente.SelectedItem = null;
                tabFormulario_SelectionChanged(null, null);
            }
            else
            {
                MessageBox.Show("Por favor rellena todos los campos y comprueba que el DNI sea correcto (8 números y 1 letra en mayúscula)");
            }

        }

        private void btnCrearIBAN_Click(object sender, RoutedEventArgs e)
        {
            if(comprobarIbanCliente())
            {
                //El cliente que esta seleccionado navega a sus atributos de clase cuenta y con los setters invocan la función creadora y la guardan en el atributo iban
                try
                {
                    (lbCliente.SelectedItem as Cliente).GetCuentaCliente().SetIbanCuenta(generarIban(lbCliente.SelectedItem as Cliente));
                    lbCliente.Items.Refresh();
                }
                catch
                {
                    MessageBox.Show("Selecciona una cuenta antes de generar IBAN");
                }
            }
            else
            {
                MessageBox.Show("Seleccióna una cuenta de la lista antes de generar un IBAN");
            }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if(comprobarImporteIngreso())
            {
                try
                {
                    ingresarDinero();
                    lbCuenta.Items.Refresh();
                    txtIngresaCuenta.Clear();
                }
                catch
                {
                    txtIngresaCuenta.Clear();
                    MessageBox.Show("Introduce un número y solo dígitos");
                }
               
                
            }
            else
            {
                MessageBox.Show("Seleccióna una cuenta antes de ingresar e introduce un importe a ingresar(SOLO DÍGITOS)");
            }
        }

        private void btnRetirar_Click(object sender, RoutedEventArgs e)
        {
            if (comprobarImporteRetira())
            {
                try
                {
                retirarDinero();
                lbCuenta.Items.Refresh();
                txtRetirarCuenta.Clear();
                }
                catch
                {
                    txtRetirarCuenta.Clear();
                    MessageBox.Show("Introduce un número y solo dígitos");
                }
            }
            else
            {
                MessageBox.Show("Seleccióna una cuenta antes de ingresar e introduce un importe a retirar (SOLO DÍGITOS)");
            }
        }

        /*- - - - - - - - - - - - - - Métodos alta - - - - - - - - - - - - - -*/
        private void darAltaSucursal()
        {
            sucursales[ultimaPosicionSucursal] = new Sucursal();

            //Segun la posicion del array inserto los valores y paso a string los codigos generados automaticamente
            sucursales[ultimaPosicionSucursal].SetCodigoSucursal(lblGenerarCodigoSucursalAlta.Content.ToString());
            sucursales[ultimaPosicionSucursal].SetCiudadSucursal(txtCiudadSucursalAlta.Text);
            sucursales[ultimaPosicionSucursal].SetUbicacionSucursal(txtUbicacionSucursalAlta.Text);
            sucursales[ultimaPosicionSucursal].SetCpSucursal(txtCpSucursalAlta.Text);
            
            //Los añado a la lista de sucursales
            lbSucursal.Items.Add(sucursales[ultimaPosicionSucursal]);
            //Los añado al combo box del formulario Alta Cliente
            cbSucursalesAltaCliente.Items.Add(sucursales[ultimaPosicionSucursal]);

            //Sumo uno más al contador para que la proxima alta ocupe otra posición del array 
            ultimaPosicionSucursal++;
            
        }

        private void darAltaCliente()
        {
            clientes[ultimaPosicionCliente] = new Cliente();

            clientes[ultimaPosicionCliente].SetDniCliente(txtDniClienteAlta.Text);
            clientes[ultimaPosicionCliente].SetNombreCliente(txtNombreClienteAlta.Text);
            clientes[ultimaPosicionCliente].SetApellidoCliente(txtApellidoClienteAlta.Text);
            clientes[ultimaPosicionCliente].SetCuentaCliente(new Cuenta(lblGenerarCuentaClienteAlta.Content.ToString(), clientes[ultimaPosicionCliente], cbSucursalesAltaCliente.SelectedItem as Sucursal));

            lbCliente.Items.Add(clientes[ultimaPosicionCliente]);
            //Como ya he creado el cliente con la cuenta, simplemente añado todo a la lista cuentas
            lbCuenta.Items.Add(clientes[ultimaPosicionCliente].GetCuentaCliente());

            ultimaPosicionCliente++;

            
        }

        /*- - - - - - - - - - - - - - Métodos comprobar - - - - - - - - - - - - - -*/
        private bool comprobarFormularioSucursal()
        {
            //Compruebo que los campos no estan vacios
            if (txtCiudadSucursalAlta.Text != "" && txtUbicacionSucursalAlta.Text != "" && txtCpSucursalAlta.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool comprobarFormularioCliente()
        {
            // El return ya me acuta como un if comprobando que es verdadero, porque es una expresión booleana asi que no tengo poner if como en comprobarFormularioSucursal
            //El Regex es para cumplir la condición del DNI "8" letras y 1 "número"
            Regex regex = new Regex("^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$");
            return txtDniClienteAlta.Text != "" && txtNombreClienteAlta.Text != "" && txtApellidoClienteAlta.Text != "" && cbSucursalesAltaCliente.SelectedItem.ToString() != "" && regex.IsMatch(txtDniClienteAlta.Text) ;
        }

        private bool comprobarIbanCliente()
        {
            return lbCliente.SelectedItem != null;
           
        }

        private bool comprobarImporteIngreso()
        {
            return txtIngresaCuenta.Text != "" && lbCuenta.SelectedItem != null;
        }

        private bool comprobarImporteRetira()
        {
            return txtRetirarCuenta.Text != "" && lbCuenta.SelectedItem != null;
        }

        private bool codigoExisteCuenta(string codigo)
        {
            bool encontrado = false;

            //Creo un buicle que me recorre todos los códigos  y me compruieba de que no se repiten y con un bool le doy luz verde a la comprobación
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    if (codigo == clientes[i].GetCuentaCliente().GetCodigoCuenta())
                    {
                        encontrado = true;
                    }

                }
            }



            return encontrado;
        }

        private bool codigoExisteSucursal(string codigo)
        {
            //igual que el anterior
            bool encontrado = false;

            for (int i = 0; i < sucursales.Length; i++)
            {
                if (sucursales[i] != null)
                {
                    if (codigo == sucursales[i].GetCodigoSucursal())
                    {
                        encontrado = true;
                    }

                }
            }

            return encontrado;
        }

        /*- - - - - - - - - - - - - - Métodos generar - - - - - - - - - - - - - -*/
        private string generarIban(Cliente cliente) 
        {
            //Creo 3 variables para separar las partes del IBAN
            //Con un substring le quito la letra al dni y me quedo los numeros
            string dni = cliente.GetDniCliente().Substring(0,8);
            //navego por los getters y los guardo en las variables
            string codigoCuenta = cliente.GetCuentaCliente().GetCodigoCuenta();
            string codigoSucursal = cliente.GetCuentaCliente().GetSucursalCuenta().GetCodigoSucursal();

            //Concateno los 3 para tener el IBAN 
            return $"{codigoSucursal} {codigoCuenta} {dni}";




        }
        private int generarCodigoCuenta()
        {
            //Uso el random y le doy 10000 del limite para que vaya del 0 al 9999
            int codigo = generadorRandom.Next(10000);
            
            //Separo el caso de si cuenta es null porque al principio no hay ninguna hasta que no la generas y sino daría error
            if (clientes[0].GetCuentaCliente() == null)
                return codigo;

            if (codigoExisteCuenta(codigo.ToString()))
            {
                return generarCodigoCuenta();
            }
            else
                return codigo;

          
        }

        private int generarCodigoSucursal()
        {
            int codigo = generadorRandom.Next(10000);

            if (codigoExisteSucursal(codigo.ToString()))
            {
                return generarCodigoSucursal();
            }
            else
                return codigo;


        }
        private void tabFormulario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabAltaSucursal.IsSelected)
            {
                //Lo del PadLeft no sé si lo disteis en clase pero entiendo perfectamente que hace.
                //Determina cuantas posiciones va tener mi generador de código, 4 en este caso, y rellena
                //con el char que tu quieras los "huecos" que dejan las posiones vacias hacia la izquiera.
                //Rollo mi generador crea un numero random de solo 2 números, ejemplo: 33, pero claro es condición
                //que sean 4 dígitos, pues le mete, en este caso los 0 a la izquierda hasta que cumpla, ejemplo: 0033.  
                lblGenerarCodigoSucursalAlta.Content = generarCodigoSucursal().ToString().PadLeft(4, '0');
            }

            else if(tabAltaCliente.IsSelected)
            {
                lblGenerarCuentaClienteAlta.Content = generarCodigoCuenta().ToString().PadLeft(4, '0');
            }


        }

        /*- - - - - - - - - - - - - - Métodos dinero - - - - - - - - - - - - - -*/

        private void ingresarDinero()
        {
            try
            {
                //Convierto a int para poder operar los digitos
                int ingreso = Int32.Parse(txtIngresaCuenta.Text);

                //Esto es para que no puedas operar con número negativos, porque me fastidiarías la suma que viene 
                if (ingreso < 0)
                    ingreso = ingreso * -1;


               //y sumo las cantidad qeu habia con la que le metes
               (lbCuenta.SelectedItem as Cuenta).SetDineroCuenta((lbCuenta.SelectedItem as Cuenta).GetDineroCuenta() + ingreso);
            }
            catch
            {
                throw;
            }
        }

       private void retirarDinero()
        {
            try
            {
                //Lo mismo que ingresar pero ahora restando
                int retiro = Int32.Parse(txtRetirarCuenta.Text);

                if (retiro < 0)
                    retiro = retiro * -1;

                (lbCuenta.SelectedItem as Cuenta).SetDineroCuenta((lbCuenta.SelectedItem as Cuenta).GetDineroCuenta() - retiro);
            }
            catch
            {
                throw;
            }
        }





    }
}
