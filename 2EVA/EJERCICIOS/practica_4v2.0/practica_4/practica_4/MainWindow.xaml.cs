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

namespace practica_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tabBanco.Visibility = Visibility.Hidden;
           // tabFormulario.Visibility = Visibility.Hidden;

           

            
        }

        private void Banco_Click(object sender, RoutedEventArgs e)
        {
           // tabFormulario.Visibility = Visibility.Hidden;
            tabBanco.Visibility = Visibility.Visible;
        }

        private void Formulario_Click(object sender, RoutedEventArgs e)
        {
            tabBanco.Visibility = Visibility.Hidden;
           // tabFormulario.Visibility = Visibility.Visible;
        }

        private void tabBanco_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
