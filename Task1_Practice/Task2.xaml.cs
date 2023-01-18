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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        // Кнопка решение
        private void Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Вводим три целых числа и определяем сумму двух наименьших из них
                int a = int.Parse(num1.Text);
                int b = int.Parse(num2.Text);
                int c = int.Parse(num3.Text);
                result.Text = Class1.SmallerNumbersSum(a, b, c).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Описание
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести три целых числа. Найти сумму двух наименьших из них");
        }

        // Выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Изменение текста в num1, num2, num3
        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            result.Text = "";
        }
    }
}
