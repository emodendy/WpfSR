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

namespace WpfSR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            type.ItemsSource = new string[]
            {
                "Последовательное", "Параллельное"
            };
        }
        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (type.SelectedItem == "Последовательное")
            {
            posled.Visibility = Visibility.Visible;
            parallel.Visibility = Visibility.Hidden;
            }
            else if (type.SelectedItem == "Параллельное")
            {
                posled.Visibility = Visibility.Hidden;
                parallel.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            first
        }
    }
}
