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
using Пример_таблицы_WPF;

namespace Task1_Practice
{
    /// <summary>
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }

        int[,] matr;
        int[] arr;
        // Создание таблицы
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                matr = new int[int.Parse(rows.Text), int.Parse(cols.Text)];
                dataGrid_matr.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Заполнение таблицы
        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (matr != null)
                {
                    Random rand = new Random();
                    int min = int.Parse(minNum.Text);
                    int max = int.Parse(maxNum.Text);

                    for (int i = 0; i < matr.GetLength(0); i++)
                        for (int j = 0; j < matr.GetLength(1); j++) matr[i, j] = rand.Next(min, max);

                    dataGrid_matr.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
                }
                else MessageBox.Show("Таблица не создана");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Расчёт
        private void Count_Click(object sender, RoutedEventArgs e)
        {
            arr = Class1.ColumnsSum(matr);
            dataGrid_arr.ItemsSource = VisualArray.ToDataTable(arr).DefaultView;
        }

        private void dataGrid_matr_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                int indexColumn = e.Column.DisplayIndex, indexRow = e.Row.GetIndex();
                matr[indexRow, indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Описание
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сформировать одномерный массив из сумм элементов столбцов матрицы");
        }

        // Выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            matr = null;
            arr = null;
        }
    }
}
