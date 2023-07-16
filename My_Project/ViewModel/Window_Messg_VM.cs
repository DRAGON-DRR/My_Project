using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project.ViewModel
{
    public partial class Window_Messg_VM : ObservableObject
    {
        [ObservableProperty]
        public string topic_M;
        [ObservableProperty]
        public string massege_;

        public Window_Messg_VM(string topic_M, string massege_)
        {
            Topic_M = topic_M;
            Massege_ = massege_;
        }
        public Window_Messg_VM()
        {
            
        }

    }
}
