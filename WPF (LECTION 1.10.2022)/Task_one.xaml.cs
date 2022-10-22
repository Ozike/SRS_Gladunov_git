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
    /// Логика взаимодействия для Task_one.xaml
    /// </summary>
    public partial class Task_one : Window
    {
        public Task_one()
        {
            InitializeComponent();
        }

        private void Button_raschet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TextBox_Enter.Text);                
            }
            catch
            {
                TextBox_result.Text = "Введите ЧИСЛО";        
                return;
            }

            if (TextBox_Enter.Text.Length != 6)
            {
               TextBox_result.Text = "Должно быть ТОЛЬКО 6 цифр";     
            }
            else
            {
                string Number = TextBox_Enter.Text;

                if (Convert.ToInt32(Number[0] + Number[1] + Number[2]) == Convert.ToInt32(Number[3] + Number[4] + Number[5]))
                {
                    TextBox_result.Text = "Сумма первых трёх десятичных цифр равна сумме трёх последних десятичных цифр";
                }
                else
                {
                    TextBox_result.Text = "Сумма первых трёх десятичных цифр НЕ равна сумме трёх последних десятичных цифр";
                }

            }
            
        }
    }
}
