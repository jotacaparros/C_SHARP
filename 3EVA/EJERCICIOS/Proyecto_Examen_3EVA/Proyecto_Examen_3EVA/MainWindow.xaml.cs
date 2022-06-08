// - - - - - - - - - - - - - - - - - - 
// José Manuel Caparrós Ivorra
// Curso DAW
// Modalidad Presencial
// Examen Tercera Evaluación
// - - - - - - - - - - - - - - - - - - 
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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace JoseM_Caparros_Examen3EVA
{
   
    public partial class MainWindow : Window
    {
       
        /* SOLO FUNCIONA CON CLIENTES  */
        public MainWindow()
        {     
            InitializeComponent();
            listasEnComboBox();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            string direccionFicheroCliente = "./../../../files/clientes.txt";
            string direccionFicheroDistribuidor = "./../../../files/distribuidores.txt";

            if (cbArchivosListas.Text == "Clientes")
            {
                MessageBox.Show("Has elegido clientes");
                
                if(File.Exists(direccionFicheroCliente))
                {
                    MessageBox.Show("Existe clientes!");
                    StreamReader ficheroCliente;
                    string linea;

                    ficheroCliente = File.OpenText(direccionFicheroCliente);
                    do 
                    { 
                        linea = ficheroCliente.ReadLine();                        
                        
                        if (linea != null)
                        {
                            listBoxListaEnPantalla.Items.Add(linea);
                        }
                    } while (linea != null);
                    
                    ficheroCliente.Close();


                }
                else
                {
                    MessageBox.Show("No existe clientes!");
                }

            }
            else if (cbArchivosListas.Text == "Distribuidores")
            {
                MessageBox.Show("Has elegido Distribuidores");
                if (File.Exists("./../../../files/distribuidores.txt"))
                {
                    MessageBox.Show("Existe distribuidores!");
                }
                else
                {
                    MessageBox.Show("No existe distribuidores!");
                }
            }
            else
            {
                MessageBox.Show("No se puede mostrar lista. Selecciona una lista antes de mostrarla");
            }

        } // SOLO FUNCIONA CON CLIENTES

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
         string direccionFicheroCliente = "./../../../files/clientes.txt";
         string direccionFicheroDistribuidor = "./../../../files/distribuidores.txt";
         
            if (cbArchivosListas.Text == "Clientes")
            {
                Cliente anadirCliente = new Cliente(txtCodigoProvisional.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text);
                MessageBox.Show("Has elegido clientes");

                if (File.Exists(direccionFicheroCliente))
                {
                    MessageBox.Show("Existe clientes!");
                    
                    StreamWriter ficheroClientes;
                    ficheroClientes = File.AppendText(direccionFicheroCliente);
                    ficheroClientes.WriteLine(anadirCliente.ImprimirCliente());
                    ficheroClientes.Close();

                }
                else
                {
                    MessageBox.Show("No existe clientes!");
                }

            }
            else if (cbArchivosListas.Text == "Distribuidores")
            {
                MessageBox.Show("Has elegido Distribuidores");
                if (File.Exists(direccionFicheroDistribuidor))
                {
                    MessageBox.Show("Existe distribuidores!");
                }
                else
                {
                    MessageBox.Show("No existe distribuidores!");
                }
            }
            else
            {
                MessageBox.Show("No se puede mostrar lista. Selecciona una lista antes de mostrarla");
            }
        } // SOLO FUNCIONA CON CLIENTES

        private void btnEliminar_Click(object sender, RoutedEventArgs e) // SOLO EN LA LISTBOX
        {
           if(listBoxListaEnPantalla.SelectedItem != null)
            {
            
                listBoxListaEnPantalla.Items.Remove(listBoxListaEnPantalla.SelectedItem);
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e) // NO FUNCIONA
        {

        }

        private void btnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {

        }  // NO FUNCIONA

        private void btnExportarPdf_Click(object sender, RoutedEventArgs e)
        {
            string direccionFicheroCliente = "./../../../files/clientes.txt";
            string direccionFicheroPDF = "./../../../files/Datos.pdf";

            Document documentoEditable = new Document();
            FileStream ficheroPdf = new FileStream(direccionFicheroPDF, FileMode.Create);

            PdfWriter.GetInstance(documentoEditable, ficheroPdf);
            
            documentoEditable.Open();

            Font fuenteTitulo = FontFactory.GetFont("Arial", 14, Font.BOLD, BaseColor.BLACK);
            Font fuenteCursiva = FontFactory.GetFont("Arial", 12, Font.ITALIC, BaseColor.BLACK);
           
            PdfPTable tablaDatosCliente = new PdfPTable(5);
            PdfPCell celdaTitulo = new PdfPCell(new Phrase("Clientes", fuenteTitulo));
            celdaTitulo.Colspan = 5;
            celdaTitulo.HorizontalAlignment = 1;

            tablaDatosCliente.AddCell(celdaTitulo);

            PdfPCell celdaSubTitulo = new PdfPCell(new Phrase("Código", fuenteCursiva));

            tablaDatosCliente.AddCell(celdaSubTitulo);
            tablaDatosCliente.AddCell(celdaSubTitulo);
            tablaDatosCliente.AddCell(celdaSubTitulo);
            tablaDatosCliente.AddCell(celdaSubTitulo);
            tablaDatosCliente.AddCell(celdaSubTitulo);


            if (File.Exists(direccionFicheroCliente))
            {
                MessageBox.Show("Existe clientes!");
                StreamReader ficheroCliente;
                string linea;

                ficheroCliente = File.OpenText(direccionFicheroCliente);
                do
                {
                    linea = ficheroCliente.ReadLine();

                    if (linea != null)
                    {
                        char delimitador = '#';
                        int i;

                        string[] trozos = linea.Split(delimitador);
                        for (i = 0; i < trozos.Length; i++)
                        {
                            PdfPCell celdaDato = new PdfPCell(new Phrase(trozos[i]));
                            tablaDatosCliente.AddCell(celdaDato);
                        }                       
                    }
                } while (linea != null);

                ficheroCliente.Close();


            }

            documentoEditable.Add(tablaDatosCliente);
            documentoEditable.Close();

            MessageBox.Show("Archivo pdf creado!");
        } // SOLO FUNCIONA CON CLIENTES

        private void btnGenerarJSON_Click(object sender, RoutedEventArgs e)
        {
            string direccionFicheroCliente = "./../../../files/clientes.txt";
           
            if (File.Exists(direccionFicheroCliente))
            {
                MessageBox.Show("Existe clientes!");
                StreamReader ficheroCliente;
                string linea;

                ficheroCliente = File.OpenText(direccionFicheroCliente);
                do
                {
                    linea = ficheroCliente.ReadLine();

                    if (linea != null)
                    {
                        char delimitador = '#';
                        int i;

                        string[] trozos = linea.Split(delimitador);

                        string json = "{\"Codigo\" : \"" + trozos[0].ToString() + "\", \"Nombre\" : \"" + trozos[1].ToString() + "\", \"Apellidos\" : \"" + trozos[2].ToString() + "\", \"Teléfono\" : \"" + trozos[3].ToString() + "\", \"Dirección\" : \"" + trozos[4].ToString() + "\" }";

                        string direccionFicheroClienteJSON = "./../../../files/clientesJSON.txt";
                        StreamWriter ficheroClientesJSON;
                        ficheroClientesJSON = File.AppendText(direccionFicheroClienteJSON);
                        ficheroClientesJSON.WriteLine(json);
                        ficheroClientesJSON.Close();

                    }
                } while (linea != null);

                ficheroCliente.Close();


            }
        } // SOLO FUNCIONA CON CLIENTES
        private void listasEnComboBox()
        {
            cbArchivosListas.Items.Add("Clientes");
            cbArchivosListas.Items.Add("Distribuidores");
        }


      

    }

}
