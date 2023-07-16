using My_Project.ViewModel;
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

namespace My_Project
{
    /// <summary>
    /// Interaction logic for Student_Add_Window.xaml
    /// </summary>
    public partial class Student_Add_Window : Window
    {
        public Student_Add_Window(Student_Add_VM Vm_)
        {
            InitializeComponent();
            DataContext = Vm_;
            Vm_.CloseAction = () => Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }
        private void WinMinimiz(object sender, RoutedEventArgs e)
        {

            this.WindowState = WindowState.Minimized;
        }
        private void WinClose(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
