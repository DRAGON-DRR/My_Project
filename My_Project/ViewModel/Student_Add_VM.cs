using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using My_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace My_Project.ViewModel
{
    public partial class Student_Add_VM : ObservableObject
    {


        [ObservableProperty]
        public string firstname;


        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;







        [ObservableProperty]
        public string title = "ADD STUDENT";

        [ObservableProperty]
        public BitmapImage selectedImage;



        public Student_Add_VM(Male_Female_Student My_)
        {
            title = "EDIT STUDENT";
            student = My_;

            firstname = student.FirstName;
            lastname = student.LastName;
            age = student.Age;
            gpa = student.GPA;
            dateofbirth = student.DateOfBirth;
            selectedImage = student.Image;

        }
        public Student_Add_VM()
        {

        }



        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));


                var msgwin = new Window_Massege_("SUCCESSFULL !", "Imgae successfuly uploded!");
                msgwin.ShowDialog();

            }
        }






        public Male_Female_Student student { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {



            if (gpa < 0 || gpa > 4)
            {


                var msgwin = new Window_Massege_("WARNING !", "GPA value must be between 0 and 4");
                msgwin.ShowDialog();


                return;
            }
            if (student == null)
            {

                student = new Male_Female_Student()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,

                    GPA = gpa

                };


            }
            else
            {

                student.FirstName = firstname;
                student.LastName = lastname;
                student.Age = age;
                student.GPA = gpa;
                student.Image = selectedImage;
                student.DateOfBirth = dateofbirth;



            }

            if (student.FirstName != null)
            {

                this.CloseAction();
            }
            Application.Current.MainWindow.Show();




        }


    }
}