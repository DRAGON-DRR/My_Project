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
    /// Interaction logic for Window_Main_.xaml
    /// </summary>
    public partial class Window_Main_ : Window
    {
        public Window_Main_()
        {
            //InitializeComponent();
            DataContext = new Window_Main_VM();
            
        }

       
        private void WinMinimiz(object sender, RoutedEventArgs e)
        {

            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void WinClose(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        
    }
}
