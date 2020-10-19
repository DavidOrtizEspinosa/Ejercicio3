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

namespace Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            altaRadioButton.IsChecked = true;
            rellenoRadioButton.IsChecked = true;
        }

        private void altaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            altaRadioButton.IsChecked = true;
            imagenImage.Opacity = 1;
        }

        private void mediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mediaRadioButton.IsChecked = true;
            imagenImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bajaRadioButton.IsChecked = true;
            imagenImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rellenoRadioButton.IsChecked = true;
            imagenImage.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            uniformeRadioButton.IsChecked = true;
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rellenoUniformeRadioButton.IsChecked = true;
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void noneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            noneRadioButton.IsChecked = true;
            imagenImage.Stretch = Stretch.None;
        }
    }
}
