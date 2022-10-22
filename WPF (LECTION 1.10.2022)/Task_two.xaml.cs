using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Task_two.xaml
    /// </summary>
    public partial class Task_two : Window
    {
        public Task_two()
        {
            InitializeComponent();
        }

        private void Button_raschet_Click(object sender, RoutedEventArgs e)
        {
            string str = Convert.ToString(TextBox_Enter.Text);  

            string pattern = @"\s+";   // шаблон для поиска подряд идущих пробелов

            string probel = " ";  // пробел, на который мы будем заменять наши длинные пробелы

            Regex regex = new Regex(pattern); // по какому шаблону должно действовать регулярное выражение

            string result_str = regex.Replace(str, probel); // поиск и замена пробелов

            TextBox_result.Text = result_str;  
        }
    }
}
