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

namespace Ejercicios_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

      
        }
        public class persona
        {
            private string nombre;
            private int edad; 
            public persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public Grid Mostrar()
            {
                Label l = new Label();
                l.Content = "Nombre: " + nombre;

                Label edad = new Label();
                l.Content = this.edad;

                Grid g = new Grid();
                g.Children.Add(l);
                g.Children.Add(edad);
            }

        }
    }
}
