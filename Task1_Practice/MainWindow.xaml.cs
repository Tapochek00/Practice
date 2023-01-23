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
using PracticeLib;

namespace Task1_Practice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Задание 1
        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            Task1 win = new Task1();
            win.Owner = this;
            win.ShowDialog();
        }

        // Задание 2
        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            Task2 win = new Task2();
            win.Owner = this;
            win.ShowDialog();
        }

        // Задание 3
        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            Task3 win = new Task3();
            win.Owner = this;
            win.ShowDialog();
        }

        // Задание 4
        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            Task4 win = new Task4();
            win.Owner = this;
            win.ShowDialog();
        }
    }
}
