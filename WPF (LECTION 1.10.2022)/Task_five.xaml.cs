using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF__LECTION_1._10._2022_
{
    /// <summary>
    /// Логика взаимодействия для Task_five.xaml
    /// </summary>
    /// 
    public partial class Task_five : Window
    {
        public static class ArrExtension
        {
            public static DataTable ToDataTable(int[,] array)
            {
                var res = new DataTable();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    res.Columns.Add("col" + j);
                }

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    var row = res.NewRow();

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        row[j] = array[i, j];
                    }

                    res.Rows.Add(row);
                }

                return res;
            }
        }
        public Task_five()
        {
            InitializeComponent();
        }
        public void Button_mas_first_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TextBox_stroks.Text);
                int M = Convert.ToInt32(TextBox_columns.Text);
            }
            catch
            {
                TextBox_stroks.Text = "Массив должен состоять из чисел";
                TextBox_columns.Text = "Массив должен состоять из чисел";
                return;
            }

            int stroks = Convert.ToInt32(TextBox_stroks.Text);
            int Columns = Convert.ToInt32(TextBox_columns.Text);

            if (stroks <= 0 || Columns <=0)
            {
                TextBox_stroks.Text = "Массив не должен быть отрицательным";
                TextBox_columns.Text = "массив должен иметь минимум 2 элемента";
            }
            else
            {
                int[,] mas = new int[Columns, stroks];
                Random rand = new Random();
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i, j] = rand.Next(-10, 10);   

                    }
                }
                dg_mas_vivod.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;

                int[] vector = MatrixToVector(mas, stroks, Columns);
                int min = vector.Min();
                int max = vector.Max();
                TextBox_Max_elem.Text = Convert.ToString(max);
                TextBox_Min.Text = Convert.ToString(min);

                Sort(vector);
                mas = VectorToMatrix(vector, stroks, Columns);
                DataGrid_Mas_two.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
                Sort(vector);
                Array.Reverse(vector);
                mas = VectorToMatrix(vector, stroks, Columns);
                DataGrid_Mas_first.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
            }
        }
        public int[,] VectorToMatrix(int[] arr, int N, int M)
        {
            int[,] mas = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = arr[j + i * M];
                }
            }
            return mas;
        }
        public int[] MatrixToVector(int[,] arr, int N, int M)
        {
            int[] mas = new int[M * N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mas[j + i * M] = arr[i, j];
                }
            }
            return mas;
        }
        static int[] Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

    }
}
