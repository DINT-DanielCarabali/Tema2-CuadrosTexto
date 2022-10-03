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
        }

        private void infoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.Key == Key.F1)
            {
                if (tb.Tag.ToString() == infoNombreTextBlock.Name)
                {
                    if (infoNombreTextBlock.Visibility == Visibility.Hidden)
                        infoNombreTextBlock.Visibility = Visibility.Visible;
                    else
                        infoNombreTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (infoApellidoTextBlock.Visibility == Visibility.Hidden)
                        infoApellidoTextBlock.Visibility = Visibility.Visible;
                    else
                        infoApellidoTextBlock.Visibility = Visibility.Hidden;
                }
            }
        }
        
        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (int.TryParse(edadTextBox.Text, out _))
                    comprobadorEdadTextBlock.Visibility = Visibility.Hidden;
                else
                    comprobadorEdadTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}