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
    /// Interaction logic for Window_Massege_.xaml
    /// </summary>
    public partial class Window_Massege_ : Window
    {
        public Window_Massege_()
        {
            InitializeComponent();
        }
        public Window_Massege_(string topic_M, string Massege_)
        {
            InitializeComponent();
            DataContext = new Window_Messg_VM(topic_M, Massege_);
        }

        private void WinClose(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}