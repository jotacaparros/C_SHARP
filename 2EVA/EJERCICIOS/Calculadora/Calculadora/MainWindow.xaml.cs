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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numeroAnterior;
        public MainWindow()
        {
            InitializeComponent();
            acBoton.Click += AcBoton_Click;
            negativoBoton.Click += NegativoBoton_Click;


        }
        private void NumeroBoton_Click(object sender, RoutedEventArgs e)
        {
            int valorSelecionado = int.Parse((sender as Button).Content.ToString());

            if(resultadoLabel.Content.ToString() == "0")
            {
                resultadoLabel.Content = $"{valorSelecionado}"; 
            }
            else
            {
                resultadoLabel.Content = $"{resultadoLabel.Content}{valorSelecionado}";   
            }
        }
        private void NegativoBoton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultadoLabel.Content.ToString(), out numeroAnterior))
            {
                numeroAnterior = numeroAnterior * -1;
                resultadoLabel.Content = $"{numeroAnterior}";

            }
        }

        private void AcBoton_Click(object sender, RoutedEventArgs e)
        {
            resultadoLabel.Content = "0";
        }
    }
}
