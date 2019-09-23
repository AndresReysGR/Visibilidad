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

namespace Vicibilidad
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

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbFigura.SelectedIndex)
            {
                case 0://circulo
                    txtRadio.Visibility = Visibility.Visible;
                    lblRadio.Visibility = Visibility.Visible;

                    lblBase.Visibility = Visibility.Hidden;
                    txtBase.Visibility = Visibility.Hidden;

                    lblAltura.Visibility = Visibility.Hidden;
                    txtAltura.Visibility = Visibility.Hidden;
                    break;
                case 1: //triangulo
                    lblBase.Visibility = Visibility.Visible;
                    txtBase.Visibility = Visibility.Visible;

                    lblAltura.Visibility = Visibility.Visible;
                    txtAltura.Visibility = Visibility.Visible;
                    txtRadio.Visibility = Visibility.Hidden;
                    lblRadio.Visibility = Visibility.Hidden;


                    break;
                default:
                    break;
            }

        }
    }
}
