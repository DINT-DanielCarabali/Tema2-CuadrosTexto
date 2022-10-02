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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            infoNombreTextBlock.Visibility = Visibility.Hidden;
            infoApellidoTextBlock.Visibility = Visibility.Hidden;
            comprobadorEdadTextBlock.Visibility = Visibility.Hidden;
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == (Key)ConsoleKey.F2)
            {
                if (int.TryParse(edadTextBox.Text, out _))
                    comprobadorEdadTextBlock.Visibility = Visibility.Hidden;
                else
                    comprobadorEdadTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}