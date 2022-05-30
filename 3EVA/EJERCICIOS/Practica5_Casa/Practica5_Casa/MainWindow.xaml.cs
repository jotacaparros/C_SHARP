// - - - - - - - - - - - - - - - - - - - - - -
// José M Caparrós Ivorra
// Curso 1º DAW
// Modalidad Presencial
// Práctica nº 5
// - - - - - - - - - - - - - - - - - - - - - -
using System;
using System.Collections.Generic;
using System.IO;
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
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Cliente> listaClientesAlicante = new List<Cliente>();
        public List<Cliente> listaClientesValencia = new List<Cliente>();
        public List<Cliente> listaClientesCastellon = new List<Cliente>();
        public MainWindow()
        {
            InitializeComponent();
            anadirProvinciasComboBox();
            guardarCambiosDeshabilitado();
            cbProvinciasDesactivadosYLimpios();
        }
        // - - - - - - - - - - - - - - - BOTONES AÑADIR - - - - - - - - - - - - - //
        private void btnAnadir_Click(object sender, RoutedEventArgs e)   //Creo un objeto cliente con los atributos del textbox y el combobox y los añado en dos listas
        {
            Cliente clientes = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);

            if (txtNombre.Text != "" && txtApellido.Text != "" && cbProvincia.SelectedItem != null)
            {
                listaClientes.Add(clientes);               //Aquí he vsito que se puede usar la misma lista, lincando la lista del ListBox con ItemSource pero no he encontrado cómo invocar luego las funciones  
                lbxClientes.Items.Add(clientes.infoLb()); // de cliente  que necesito para esribir los datos sin provincias. 

                txtNombre.Clear();
                txtApellido.Clear();
                cbProvincia.SelectedItem = null;
               
            }
            else { MessageBox.Show("Por favor rellena los campos antes de añadir"); }

        }
        private void btnAnadirA_Click(object sender, RoutedEventArgs e)
        {
            Cliente clientesA = new Cliente(txtNombreA.Text, txtApellidoA.Text,"Alicante");

            if (txtNombreA.Text != "" && txtApellidoA.Text != "")
            {
                listaClientesAlicante.Add(clientesA);
                lbxAlicante.Items.Add(clientesA.clienteEnFicheroProvincia());

                txtNombreA.Clear();
                txtApellidoA.Clear();
                btnEliminarA.IsEnabled = true;
            }
            else{MessageBox.Show("Por favor rellena los campos antes de añadir");}
        }
        private void btnAnadirV_Click(object sender, RoutedEventArgs e)
        {
            Cliente clientesV = new Cliente(txtNombreV.Text, txtApellidoV.Text, "Valencia");

            if (txtNombreV.Text != "" && txtApellidoV.Text != "")
            {
                listaClientesValencia.Add(clientesV);
                lbxValencia.Items.Add(clientesV.clienteEnFicheroProvincia());

                txtNombreV.Clear();
                txtApellidoV.Clear();
            }
            else { MessageBox.Show("Por favor rellena los campos antes de añadir"); }
        }
        private void btnAnadirC_Click(object sender, RoutedEventArgs e)
        {
            Cliente clientesC = new Cliente(txtNombreC.Text, txtApellidoC.Text, "Castellón");

            if (txtNombreC.Text != "" && txtApellidoC.Text != "")
            {
                listaClientesCastellon.Add(clientesC);
                lbxCastellon.Items.Add(clientesC.clienteEnFicheroProvincia());

                txtNombreC.Clear();
                txtApellidoC.Clear();
            }
            else { MessageBox.Show("Por favor rellena los campos antes de añadir"); }
        }
        // - - - - - - - - - - - - - - - BOTONES AÑADIR - - - - - - - - - - - - - //


        // - - - - - - - - - - - - - - - BOTONES ELIMINAR - - - - - - - - - - - - - //
        private void btnEliminar_Click(object sender, RoutedEventArgs e) // Elimino según la posicion del objeto tanto en la lista interna como la del listbox
        {
            int numeroPosicion;
            numeroPosicion = lbxClientes.SelectedIndex;

            if (lbxClientes.SelectedItem != null) 
            {
                listaClientes.RemoveAt(numeroPosicion);
                lbxClientes.Items.RemoveAt(numeroPosicion);
            }
            else { MessageBox.Show("Para elminar, primero selecciona un cliente de la lista"); }

        }
        private void btnEliminarA_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionA;
            numeroPosicionA = lbxAlicante.SelectedIndex;

            if (lbxAlicante.SelectedItem != null)
            {
                listaClientesAlicante.RemoveAt(numeroPosicionA);
                lbxAlicante.Items.RemoveAt(numeroPosicionA);
            }
            else { MessageBox.Show("Para elminar, primero selecciona un cliente de la lista"); }


        }
        private void btnEliminarV_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionV;
            numeroPosicionV = lbxValencia.SelectedIndex;

            if (lbxValencia.SelectedItem != null)
            {
                listaClientesValencia.RemoveAt(numeroPosicionV);
                lbxValencia.Items.RemoveAt(numeroPosicionV);
            }
            else { MessageBox.Show("Para elminar, primero selecciona un cliente de la lista"); }
        }
        private void btnEliminarC_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionC;
            numeroPosicionC = lbxCastellon.SelectedIndex;

            if (lbxCastellon.SelectedItem != null)
            {
                listaClientesCastellon.RemoveAt(numeroPosicionC);
                lbxCastellon.Items.RemoveAt(numeroPosicionC);
            }
            else { MessageBox.Show("Para elminar, primero selecciona un cliente de la lista"); }
        }

        // - - - - - - - - - - - - - - - BOTONES ELIMINAR - - - - - - - - - - - - - //


        // - - - - - - - - - - - - - - - SELECCIONES LISTBOX - - - - - - - - - - - - - //
        private void lbxClientes_SelectionChanged(object sender, SelectionChangedEventArgs e) // Estos eventos son para llevar un control a la hora de deshabilitar el boton añadir y habilitar el botón eliminar 
        {
            btnEliminar.IsEnabled = true;
            if (lbxClientes.Items != null)
            {
                btnAnadir.IsEnabled = false;
            }
        }  
        private void lbxAlicante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEliminarA.IsEnabled = true;
            if (lbxAlicante.Items != null)
            {
                btnAnadirA.IsEnabled = false;
            }
        }
        private void lbxValencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEliminarV.IsEnabled = true;
            if (lbxValencia.Items != null)
            {
                btnAnadirV.IsEnabled = false;
            }
        }
        private void lbxCastellon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEliminarC.IsEnabled = true;

            if (lbxCastellon.Items != null)
            {
                btnAnadirC.IsEnabled = false;
                
            }
        }
        // - - - - - - - - - - - - - - - SELECCIONES LISTBOX - - - - - - - - - - - - - //


        // - - - - - - - - - - - - - - - SELECCIONES TEXTBOX - - - - - - - - - - - - - //
        private void txtNombre_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadir.IsEnabled = true;
        }  // Estos eventos son para llevar un control a la hora de habilitar el boton añadir cuando marques el textbox para introducir un nuevo cliente
        private void txtApellido_SelectionChanged(object sender, RoutedEventArgs e)
        {
           btnAnadir.IsEnabled = true;
        }
        private void txtNombreA_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadirA.IsEnabled = true;
        }
        private void txtApellidoA_SelectionChanged(object sender, RoutedEventArgs e)
        {
           btnAnadirA.IsEnabled = true;
        }
        private void txtNombreV_SelectionChanged(object sender, RoutedEventArgs e)
        {
           btnAnadirV.IsEnabled = true;
        }
        private void txtApellidoV_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadirV.IsEnabled = true;
        }
        private void txtNombreC_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnAnadirC.IsEnabled = true;

        }
        private void txtApellidoC_TextChanged(object sender, TextChangedEventArgs e)
        {
           btnAnadirC.IsEnabled = true;
        }
        // - - - - - - - - - - - - - - - SELECCIONES TEXTBOX - - - - - - - - - - - - - //

        // - - - - - - - - - - - - - - - BOTONES MODIFICAR - - - - - - - - - - - - - //
        private void btnModificar_Click(object sender, RoutedEventArgs e)  // Muestra en el textbox y el cb. los datos de un cliente seleccionado del listbox para que puedas modificarlo
            {
                if (lbxClientes.SelectedItem != null) //Si hay algo seleccionado de la lista rellena los atributos del objeto con la posición exacta 
                {
                    txtNombre.Text = listaClientes[lbxClientes.SelectedIndex].GetNombre();
                    txtApellido.Text = listaClientes[lbxClientes.SelectedIndex].GetApellido();
                    cbProvincia.Text = listaClientes[lbxClientes.SelectedIndex].GetProvincia();

                    btnGuardarCambios.IsEnabled = true; //Mero control de botones para que guardar cambios se actrive y añadir y eliminar se desactiven
                    btnAnadirDeshabilitado();
                    btnEliminarDeshabilitado();

            }
                else { MessageBox.Show("Para modificar, primero selecciona un cliente de la lista"); }
            }
        private void btnModificarA_Click(object sender, RoutedEventArgs e)
        {
            if (lbxAlicante.SelectedItem != null)
            {
                //De la lista de clientes, selecciono la posición del objeto clientes y pongo la funcion dar nombre para que al igualarlo 
                //al text box te lo rellene.
                txtNombreA.Text = listaClientesAlicante[lbxAlicante.SelectedIndex].GetNombre();
                txtApellidoA.Text = listaClientesAlicante[lbxAlicante.SelectedIndex].GetApellido();
                cbProvinciaA.Text = listaClientesAlicante[lbxAlicante.SelectedIndex].GetProvincia();


                cbProvinciaA.IsEnabled = true;
                btnGuardarCambiosA.IsEnabled = true;
                btnAnadirDeshabilitado();
                btnEliminarDeshabilitado();

            }
            else { MessageBox.Show("Para modificar, primero selecciona un cliente de la lista"); }
        }
        private void btnModificarV_Click(object sender, RoutedEventArgs e)
        {
            if (lbxValencia.SelectedItem != null)
            {

                txtNombreV.Text = listaClientesValencia[lbxValencia.SelectedIndex].GetNombre();
                txtApellidoV.Text = listaClientesValencia[lbxValencia.SelectedIndex].GetApellido();
                cbProvinciaV.Text = listaClientesValencia[lbxValencia.SelectedIndex].GetProvincia();


                cbProvinciaV.IsEnabled = true;
                btnGuardarCambiosV.IsEnabled = true;
                btnAnadirDeshabilitado();
                btnEliminarDeshabilitado();

            }
            else { MessageBox.Show("Para modificar, primero selecciona un cliente de la lista"); }
        }
        private void btnModificarC_Click(object sender, RoutedEventArgs e)
        {
            if (lbxCastellon.SelectedItem != null)
            {

                txtNombreC.Text = listaClientesCastellon[lbxCastellon.SelectedIndex].GetNombre();
                txtApellidoC.Text = listaClientesCastellon[lbxCastellon.SelectedIndex].GetApellido();
                cbProvinciaC.Text = listaClientesCastellon[lbxCastellon.SelectedIndex].GetProvincia();


                cbProvinciaC.IsEnabled = true;
                btnGuardarCambiosC.IsEnabled = true;
                btnAnadirDeshabilitado();
                btnEliminarDeshabilitado();

            }
            else { MessageBox.Show("Para modificar, primero selecciona un cliente de la lista"); }
        }
        // - - - - - - - - - - - - - - - BOTONES MODIFICAR - - - - - - - - - - - - - //


        // - - - - - - - - - - - - - - - BOTONES GUARDAR CAMBIOS - - - - - - - - - - - - - //
        private void btnGuardarCambios_Click(object sender, RoutedEventArgs e)    //Guarda los cambios que editas añadiendo un nuevo objeto en la posición en la que estaba el orignal y luego elimino el original
        {                                                                        // contando que se ha desplazado una posición. Lo hago con las dos listas (listbox y lista que no se ve)                  
            int numeroPosicion;
                numeroPosicion = lbxClientes.SelectedIndex;

                Cliente clientes = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);

                if (txtNombre.Text != "" && txtApellido.Text != "" && cbProvincia.SelectedItem != null)
                {
                    listaClientes.Insert(numeroPosicion, clientes);
                    listaClientes.RemoveAt(numeroPosicion + 1);

                    lbxClientes.Items.Insert(numeroPosicion, clientes.infoLb());
                    lbxClientes.Items.RemoveAt(numeroPosicion + 1);
                }
            limpiarTextbox();
            btnAnadirDeshabilitado();
            btnEliminarDeshabilitado();
            guardarCambiosDeshabilitado();
            cbProvinciasDesactivadosYLimpios();         
        }
        private void btnGuardarCambiosA_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionA;
            numeroPosicionA = lbxAlicante.SelectedIndex;

            Cliente clientesA = new Cliente(txtNombreA.Text, txtApellidoA.Text, cbProvinciaA.Text);

            if (txtNombreA.Text != "" && txtApellidoA.Text != "" && cbProvinciaA.SelectedItem != null)
            {
                if(cbProvinciaA.Text == "Alicante")
                {
                    listaClientesAlicante.Insert(numeroPosicionA, clientesA);
                    listaClientesAlicante.RemoveAt(numeroPosicionA + 1);

                    lbxAlicante.Items.Insert(numeroPosicionA, clientesA.clienteEnFicheroProvincia());
                    lbxAlicante.Items.RemoveAt(numeroPosicionA + 1);

                }
                    else if(cbProvinciaA.Text == "Valencia")
                    {
                        listaClientesValencia.Add(clientesA);
                        listaClientesAlicante.RemoveAt(numeroPosicionA);

                        lbxValencia.Items.Add(clientesA.clienteEnFicheroProvincia());
                        lbxAlicante.Items.RemoveAt(numeroPosicionA);
                    }

                    else if(cbProvinciaA.Text == "Castellón") 
                    {
                        listaClientesCastellon.Add(clientesA);
                        listaClientesAlicante.RemoveAt(numeroPosicionA);

                        lbxCastellon.Items.Add(clientesA.clienteEnFicheroProvincia());
                        lbxAlicante.Items.RemoveAt(numeroPosicionA);
                    }
            }

            limpiarTextbox();
            btnEliminarDeshabilitado();
            guardarCambiosDeshabilitado();
            cbProvinciasDesactivadosYLimpios();
            btnAnadirDeshabilitado();
        }
        private void btnGuardarCambiosV_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionV;
            numeroPosicionV = lbxValencia.SelectedIndex;

            Cliente clientesV = new Cliente(txtNombreV.Text, txtApellidoV.Text, cbProvinciaV.Text);

            if (txtNombreV.Text != "" && txtApellidoV.Text != "" && cbProvinciaV.SelectedItem != null)
            {
                if (cbProvinciaV.Text == "Alicante")
                {
                    listaClientesAlicante.Add(clientesV);
                    listaClientesValencia.RemoveAt(numeroPosicionV);

                    lbxAlicante.Items.Add(clientesV.clienteEnFicheroProvincia());
                    lbxValencia.Items.RemoveAt(numeroPosicionV);

                }
                else if (cbProvinciaV.Text == "Valencia")
                {
                    listaClientesValencia.Insert(numeroPosicionV, clientesV);
                    listaClientesValencia.RemoveAt(numeroPosicionV + 1);

                    lbxValencia.Items.Insert(numeroPosicionV, clientesV.clienteEnFicheroProvincia());
                    lbxValencia.Items.RemoveAt(numeroPosicionV + 1);
                }

                else if (cbProvinciaV.Text == "Castellón")
                {
                    listaClientesCastellon.Add(clientesV);
                    listaClientesValencia.RemoveAt(numeroPosicionV);

                    lbxCastellon.Items.Add(clientesV.clienteEnFicheroProvincia());
                    lbxValencia.Items.RemoveAt(numeroPosicionV);
                }
            }

            limpiarTextbox();
            btnEliminarDeshabilitado();
            guardarCambiosDeshabilitado();
            cbProvinciasDesactivadosYLimpios();
            btnAnadirDeshabilitado();
        }
        private void btnGuardarCambiosC_Click(object sender, RoutedEventArgs e)
        {
            int numeroPosicionC;
            numeroPosicionC = lbxCastellon.SelectedIndex;

            Cliente clientesC = new Cliente(txtNombreC.Text, txtApellidoC.Text, cbProvinciaC.Text);

            if (txtNombreC.Text != "" && txtApellidoC.Text != "" && cbProvinciaC.SelectedItem != null)
            {
                if (cbProvinciaC.Text == "Alicante")
                {
                    listaClientesAlicante.Add(clientesC);
                    listaClientesCastellon.RemoveAt(numeroPosicionC);

                    lbxAlicante.Items.Add(clientesC.clienteEnFicheroProvincia());
                    lbxCastellon.Items.RemoveAt(numeroPosicionC);

                }
                else if (cbProvinciaC.Text == "Valencia")
                {
                    listaClientesValencia.Add(clientesC);
                    listaClientesCastellon.RemoveAt(numeroPosicionC);

                    lbxValencia.Items.Add(clientesC.clienteEnFicheroProvincia());
                    lbxCastellon.Items.RemoveAt(numeroPosicionC);
                }

                else if (cbProvinciaC.Text == "Castellón")
                {
                    listaClientesCastellon.Insert(numeroPosicionC, clientesC);
                    listaClientesCastellon.RemoveAt(numeroPosicionC + 1);

                    lbxCastellon.Items.Insert(numeroPosicionC, clientesC.clienteEnFicheroProvincia());
                    lbxCastellon.Items.RemoveAt(numeroPosicionC + 1);
                }
            }

            limpiarTextbox();
            guardarCambiosDeshabilitado();
            cbProvinciasDesactivadosYLimpios();
            btnAnadirDeshabilitado();
            btnEliminarDeshabilitado();
        }
        // - - - - - - - - - - - - - - - BOTONES GUARDAR CAMBIOS - - - - - - - - - - - - - //     

        // - - - - - - - - - - - - - - - FUNCIONES EXTRAS - - - - - - - - - - - - - //   
        private void btnCrearFichero_Click(object sender, RoutedEventArgs e)
            {
                using (StreamWriter fichero = new StreamWriter("clientes.txt"))      //Paso con un bucle lo que tengo la lista clientes a un archivo txt
                {
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        fichero.WriteLine(listaClientes[i].clienteEnFichero());
                    }
                }
                escribirClientesAProvincias();                                      //En esta función sucede la magia de pasarla información a los txt de provincias
              
                MessageBox.Show("¡Ficheros creados!");
            }
        private void anadirProvinciasComboBox()
            {
                cbProvincia.Items.Add("Alicante");
                cbProvincia.Items.Add("Castellón");
                cbProvincia.Items.Add("Valencia");

                cbProvinciaA.Items.Add("Alicante");
                cbProvinciaA.Items.Add("Castellón");
                cbProvinciaA.Items.Add("Valencia");

                cbProvinciaV.Items.Add("Alicante");
                cbProvinciaV.Items.Add("Castellón");
                cbProvinciaV.Items.Add("Valencia");

                cbProvinciaC.Items.Add("Alicante");
                cbProvinciaC.Items.Add("Castellón");
                cbProvinciaC.Items.Add("Valencia");
            } //Para tener las provincias en el combobox
        private void cbProvinciasDesactivadosYLimpios()
            {
                cbProvinciaA.IsEnabled = false;
                cbProvinciaV.IsEnabled = false;
                cbProvinciaC.IsEnabled = false;

                cbProvinciaA.SelectedItem = null;
                cbProvinciaV.SelectedItem = null;
                cbProvinciaC.SelectedItem = null;
                cbProvincia.SelectedItem = null;
            }  //Control de los botones cb de las provincias para  que se limpien y para que se deshabiliten en el caso de los de provincias
        private void guardarCambiosDeshabilitado()
            {
                btnGuardarCambios.IsEnabled = false;
                btnGuardarCambiosA.IsEnabled = false;
                btnGuardarCambiosV.IsEnabled = false;
                btnGuardarCambiosC.IsEnabled = false;

            } 
        private void limpiarTextbox() 
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtNombreA.Clear();
                txtApellidoA.Clear();
                txtNombreV.Clear();
                txtApellidoV.Clear();
                txtNombreC.Clear();
                txtApellidoC.Clear();
        }           
        private void btnEliminarDeshabilitado()
            {
                btnEliminar.IsEnabled = false;
                btnEliminarA.IsEnabled = false;
                btnEliminarV.IsEnabled = false;
                btnEliminarC.IsEnabled = false;
            }
        private void btnAnadirDeshabilitado()
        {
            btnAnadir.IsEnabled = !btnAnadir.IsEnabled;
            btnAnadirA.IsEnabled = !btnAnadirA.IsEnabled;
            btnAnadirV.IsEnabled = !btnAnadirV.IsEnabled;
            btnAnadirC.IsEnabled = !btnAnadirC.IsEnabled;
        }
        private void escribirClientesAProvincias() // Esta función lee el archivo cliente.txt, comprueba y escribe los correspondientes ficheros txt. 
        {
            listaClientesAlicante.Clear();                              // Primero limpio las listas para prepar la lectura del fichero cliente.txt
            listaClientesCastellon.Clear();
            listaClientesValencia.Clear();
            lbxCastellon.Items.Clear();
            lbxAlicante.Items.Clear();
            lbxValencia.Items.Clear();

            using (StreamReader ficheroLectura = new StreamReader("clientes.txt"))   //Entro a leer cliente.txt
            {
                string linea = "";                                                      
                char delimitador = '#';                                              
                do                                                                  //Hago un do while para que lea linea por linea
                {
                    linea = ficheroLectura.ReadLine();
                    
                    if (linea == null)                                              //Este if es para cuando acabe de leer el archivo y compruebe que si no hay nada en las listas elimine los txt de provincias sin datos y finalmente salga de la función con el return
                    {
                        if(listaClientesAlicante.Count == 0)
                        {
                            File.Delete("./alicante.txt");  
                        }
                        if (listaClientesValencia.Count == 0)
                        {
                            File.Delete("./valencia.txt");                            
                        }
                        if (listaClientesCastellon.Count == 0)
                        {
                            File.Delete("./castellon.txt");                            
                        }
                        return;
                    }

                    string[] clientetxt = linea.Split(delimitador);             //El splita para separa los datos        

                    if (clientetxt[2] == "Alicante")                            //Compruebo la provincia
                    {
                        if (File.Exists("alicante.txt"))                        //Compruebo si el fichero existe
                        {
                            using (StreamWriter fichero = new StreamWriter("alicante.txt", true))   //Si existe añado más info
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);
                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesAlicante.Add(nuevoCliente);
                            lbxAlicante.Items.Add(nuevoCliente.clienteEnFicheroProvincia());

                        }
                        else
                        {
                            using (StreamWriter fichero = new StreamWriter("alicante.txt", false))      //Si no existe creo el fichero y repito todo el proceso para cada provincia
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);
                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesAlicante.Add(nuevoCliente);
                            lbxAlicante.Items.Add(nuevoCliente.clienteEnFicheroProvincia());
                        }
                    }

                    if (clientetxt[2] == "Valencia")
                    {
                        if (File.Exists("valencia.txt"))
                        {
                            using (StreamWriter fichero = new StreamWriter("valencia.txt", true))
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);
                           
                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesValencia.Add(nuevoCliente);
                            lbxValencia.Items.Add(nuevoCliente.clienteEnFicheroProvincia());
                           
                        }
                        else
                        {
                            using (StreamWriter fichero = new StreamWriter("valencia.txt", false))
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);

                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesValencia.Add(nuevoCliente);
                            lbxValencia.Items.Add(nuevoCliente.clienteEnFicheroProvincia());
                        }
                    }

                    if (clientetxt[2] == "Castellón")
                    {
                        if (File.Exists("castellon.txt"))
                        {
                            using (StreamWriter fichero = new StreamWriter("castellon.txt", true))
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);
                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesCastellon.Add(nuevoCliente);
                            lbxCastellon.Items.Add(nuevoCliente.clienteEnFicheroProvincia());
                        }
                        else 
                        {
                            using (StreamWriter fichero = new StreamWriter("castellon.txt", false))
                            {
                                fichero.WriteLine(clientetxt[0] + " " + clientetxt[1]);
                            }
                            Cliente nuevoCliente = new Cliente(clientetxt[0], clientetxt[1], clientetxt[2]);
                            listaClientesCastellon.Add(nuevoCliente);
                            lbxCastellon.Items.Add(nuevoCliente.clienteEnFicheroProvincia());                        
                        }
                        

                    }

                    
                } while (linea != null);  //El motivo de salir de la funcion con un return es porque cuando acaba de leer y linea se hacia null, se quedaba al principio del bucle y daba un error de que linea no estaba declarada


            }           




          
        }
        //Para esta vaina el evento es previwe text input
        //private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    char caracter = Convert.ToChar(e.Text);

        //    if (caracter >= '0' && caracter <= '9')
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        // - - - - - - - - - - - - - - - FUNCIONES EXTRAS - - - - - - - - - - - - - //   
    }
}
