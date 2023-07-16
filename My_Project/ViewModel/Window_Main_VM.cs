using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using My_Project.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace My_Project.ViewModel
{
    public partial class Window_Main_VM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Male_Female_Student> users;
        [ObservableProperty]
        public Male_Female_Student selectedUser = null;


        [RelayCommand]
        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }
        
        [RelayCommand]
        public void Minimize_Button()
        {
            foreach (Window item in Application.Current.Windows)
                if (item.DataContext == this) item.WindowState = WindowState.Minimized;
        }
        [RelayCommand]
        public void Close_Button()
        {
            foreach (Window item in Application.Current.Windows)
                if (item.DataContext == this) item.Close();
        }




        [RelayCommand]
        public void messeag()
        {


            var msgwin = new Window_Massege_("ERROR !", "GPA value must be between 0 and 4.");
            msgwin.ShowDialog();

        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new Student_Add_VM();
            vm.title = "ADD USER";
            Student_Add_Window window = new Student_Add_Window(vm);

            window.ShowDialog();

            if (vm.student != null)
            {
                users.Add(vm.student);
            }
            else
            {
                return;
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                users.Remove(selectedUser);


                var msgwin = new Window_Massege_("DELETED !", "Deleted successfully.");
                msgwin.ShowDialog();

            }
            else
            {

                var msgwin = new Window_Massege_("WARNING !", "Please select Student");
                msgwin.ShowDialog();


            }

        }
        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedUser != null)
            {
                var vm = new Student_Add_VM(selectedUser);
                vm.title = "EDIT USER";
                var window = new Student_Add_Window(vm);

                window.ShowDialog();


                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, vm.student);



            }
            else
            {


                var msgwin = new Window_Massege_("WARNING !", "Please select Student");
                msgwin.ShowDialog();

            }
        }

        public Window_Main_VM()
        {
            users = new ObservableCollection<Male_Female_Student>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Pic_User/1.jpg", UriKind.Relative));
            users.Add(new Male_Female_Student(27, "Adrian ", "Holmes", "01/10/1996", image1, 3.12));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Pic_User/2.jpg", UriKind.Relative));
            users.Add(new Male_Female_Student(23, "Madhumita ", "Shenoy", "01/11/2000", image2, 2.544));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Pic_User/3.jpg", UriKind.Relative));
            users.Add(new Male_Female_Student(26, "Annette Lee", "Lee", "07/03/1997", image3, 2.28));
            BitmapImage image4 = new BitmapImage(new Uri("/Model/Pic_User/4.jpg", UriKind.Relative));
            users.Add(new Male_Female_Student(25, "August Rasmussen", "Rasmussen", "18/04/1998", image4, 3.11));

        }
    }
}

