using PracticeLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
            list.ItemsSource = nums;
        }

        ObservableCollection<int> nums = new ObservableCollection<int>();

        // Кнопка добавить
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                nums.Add(int.Parse(addNum.Text));
                result.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Заполнить
        private void Fill_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = int.Parse(quantity.Text);
                int min = int.Parse(minNum.Text);
                int max = int.Parse(maxNum.Text);
                Random rand = new Random();

                for(int i = 0; i < size; i++)
                    nums.Add(rand.Next(min, max));

                result.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Очистить
        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            nums.Clear();
        }

        // Решение
        private void Count_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int res = Class1.FirstOddElement(nums.ToArray());
                if (res == -1)
                    result.Text = "В массиве нет нечётных элементов";
                else
                    result.Text = (res + 1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Описание
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дан массив целых чисел. Найти номер первого нечётного элемента." +
                "Если нечётных элементов в массиве нет, то сообщить об этом.");
        }

        // Выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
