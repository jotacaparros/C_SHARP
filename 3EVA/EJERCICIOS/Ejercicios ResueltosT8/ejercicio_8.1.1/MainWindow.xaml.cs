﻿using System;
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

namespace ejercicio_8._1._1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter fichero;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamWriter("registroDeUsuario.txt");
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btGrabar_Click(object sender, RoutedEventArgs e)
        {
            if (txtTexto.Text.ToLower() == "fin")
            {
                Close();
                return;
            }

            fichero.WriteLine(txtTexto.Text);

            txtTexto.Text = "";
            txtTexto.Focus();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            fichero.Close();

            using (StreamReader ficheroReader = new StreamReader("registroDeUsuario.txt"))
            {
                string cadena = "";
                string linea = "";

                while ((linea = ficheroReader.ReadLine()) != null)
                {
                    cadena += linea + "\n";
                }

                MessageBox.Show(cadena);
            }

            fichero = new StreamWriter("registroDeUsuario.txt", true);
        }
    }
}
