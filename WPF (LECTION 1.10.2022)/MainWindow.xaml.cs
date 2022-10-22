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

namespace WPF__LECTION_1._10._2022_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_task_one_Click(object sender, RoutedEventArgs e)
        {
            Task_one taskWindow = new Task_one();
            taskWindow.Show();
        }

        private void Button_task_two_Click(object sender, RoutedEventArgs e)
        {
            Task_two taskWindow = new Task_two();
            taskWindow.Show();
        }

        private void Button_Task_three_Click(object sender, RoutedEventArgs e)
        {
            Task_three taskWindow = new Task_three();
            taskWindow.Show();
        }

        private void Button_task_four_Click(object sender, RoutedEventArgs e)
        {
            Task_four taskWindow = new Task_four();
            taskWindow.Show();
        }

        private void Button_task_five_Click_1(object sender, RoutedEventArgs e)
        {
            Task_five taskWindow = new Task_five();
            taskWindow.Show();
        }
    }
}
