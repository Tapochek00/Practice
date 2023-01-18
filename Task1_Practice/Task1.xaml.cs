using PracticeLib;
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
using System.Windows.Shapes;

namespace Task1_Practice
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        // Кнопка решение
        private void Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Используем функцию IsEven и выводим результат в TextBox result
                bool res = Class1.IsEven(int.Parse(num.Text));
                if (res) result.Text = "Все цифры чётные";
                else result.Text = "Не все цифры чётные";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Описание
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести двузначное число. Определить: состоит ли оно только из нечетных цифр.");
        }

        // Изменение текста в num
        private void num_TextChanged(object sender, TextChangedEventArgs e)
        {
            result.Text = "";
        }
    }
}
