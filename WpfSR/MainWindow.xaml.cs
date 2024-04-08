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
        double first_rez;
        double second_rez;
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
            first.Text = null;
            second.Text = null;
            result.Content = "Ваш результат";
        }

        private void first_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(first.Text) != 0 || Convert.ToDouble(first.Text) >= 0)
                {
                    first_rez = Convert.ToDouble(first.Text);
                }
                else
                {
                    MessageBox.Show("Введите число больше 0!!");
                }
            }
            catch (Exception ex)
            {
                first.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (type.SelectedItem == "Последовательное")
            {
                if (first_rez + second_rez < 10000)
                result.Content = $"Ваш результат {first_rez + second_rez} Ом";
                else
                {
                result.Content = $"Ваш результат {(first_rez + second_rez)/1000} КОм";
                }
            }
            else if (type.SelectedItem == "Параллельное")
            {
                if (first_rez * second_rez / (first_rez + second_rez) < 10000)
                {
                    result.Content = $"Ваш результат {first_rez * second_rez / (first_rez + second_rez)} Ом";
                }
                else
                {
                    result.Content = $"Ваш результат {(first_rez * second_rez / (first_rez + second_rez))/1000} КОм";
                }
            }else
            {
                MessageBox.Show("Выберите тип соединения!");
            }
        }

        private void second_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(second.Text) != 0 || Convert.ToDouble(second.Text) >= 0)
                {
                    second_rez = Convert.ToDouble(second.Text);
                }
                else
                {
                    MessageBox.Show("Введите число больше 0!!");
                }
            }
            catch (Exception ex)
            {
                second.Text = "";
            }
        }   
 
    }
}
