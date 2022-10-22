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
    /// Логика взаимодействия для Task_three.xaml
    /// </summary>
    public partial class Task_three : Window
    {
        public Task_three()
        {
            InitializeComponent();
        }

        private void Button_raschet_Click(object sender, RoutedEventArgs e)
        {
            TextBox_mas.Clear(); //очистка текстбокса с выведенным массивом

            try
            {
                int N = Convert.ToInt32(Textbox_mas_Lenght.Text);
            }
            catch
            {
                Textbox_result.Text = "Массив должен состоять из чисел"; 
                return;
            }

            int N1 = Convert.ToInt32(Textbox_mas_Lenght.Text); 

            if (N1 <= 0)
            {
                Textbox_result.Text = "В массиве должен быть хотя-бы один элемент, при этом, массив не должен быть отрицательным";  
            }
            else
            {
                int[] mas = new int[N1];
                int count = 0;

                string str = "";
                Random rand = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(0, 15);
                    TextBox_mas.Text += (mas[i].ToString() + " ");
                }

                int number = mas[0];  //объявление переменной, с которой будут сравниваться элементы массива


                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == number)
                    {
                        count++;
                    }
                    else
                    {
                        str = str + $"Серия элемента {number} состоит из {count} элементов; ";

                        count = 1;
                        number = mas[i];
                    }
                }
                str = str + $"Серия элемента {number} состоит из {count} элементов; ";
                Textbox_result.Text = str;
            }                          
        }
    }
}
