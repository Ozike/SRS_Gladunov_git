using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Task_four.xaml
    /// </summary>
    public partial class Task_four : Window
    {
        public Task_four()
        {
            InitializeComponent();
        }

        private void Button_mas_elements_Click(object sender, RoutedEventArgs e)
        {
            TextBox_First_mas.Clear();
            TextBox_Mas_Two.Clear();

            try
            {
                int razmer_mas = Convert.ToInt32(TextBox_Razmer_mas.Text);
            }
            catch
            {
                TextBox_First_mas.Text = "Массив должен состоять из чисел";
                TextBox_Mas_Two.Text = "Массив должен состоять из чисел";
                return;
            }

            int Razmer_mas = Convert.ToInt32(TextBox_Razmer_mas.Text);

            if (Razmer_mas <= 1)
            {
                TextBox_First_mas.Text = "Массив не должен быть отрицательным";
                TextBox_Mas_Two.Text = "Массив должен иметь хотя-бы два элемента для перестановки";

            }
            else
            {
                int[] mas = new int[Razmer_mas];
                Random rand = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(-10, 10);
                    TextBox_First_mas.Text += mas[i].ToString() + " ";
                }
                int elem_one = int.MaxValue;
                int elem_two = int.MaxValue;
                int ind_one = 0;
                int ind_two = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0 && mas[i] <= elem_one)
                    {
                        elem_one = mas[i];
                        ind_one = i;
                    }
                    if (mas[i] > 0 && mas[i] <= elem_two)
                    {
                        elem_two = mas[i];
                        ind_two = i;
                    }
                }
                if (elem_one == int.MaxValue || elem_two == int.MaxValue)
                {
                    elem_one = 0;
                    elem_two = 0;
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == elem_one)
                    {
                        if(ind_one == i)
                        {
                            mas[i] = elem_two;
                        }                      
                    }
                    else if (mas[i] == elem_two)
                    {
                        if (ind_two == i)
                        {
                            mas[i] = elem_one;
                        }                       
                    }
                }

                for (int i = 0; i < mas.Length; i++)
                {
                    TextBox_Mas_Two.Text += mas[i].ToString() + " ";
                }
                if ((elem_one <= 0 && elem_two <= 0) || elem_one > 0 || elem_two < 0)
                {
                    TextBox_Mas_Two.Text = "Ошибка, попробуйте увеличить количество элементов массива";
                }
                else if (elem_one == elem_two)
                {
                    TextBox_Mas_Two.Text = "Ошибка, попробуйте увеличить количество элементов массива";
                }

            }
        }
    }
}
