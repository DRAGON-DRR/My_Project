using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace My_Project.Model
{
    public class Male_Female_Student
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BitmapImage Image { get; set; }

        public string DateOfBirth { get; set; }
        public double GPA { get; set; }

        public String ImagePath
        {
            get { return $"/Model/Pic_User/{Image}"; }
        }

        public Male_Female_Student(int age, string firstName, string lastName, string dateOfBirth, BitmapImage image, double gpa)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
            GPA = gpa;

        }

        public Male_Female_Student()
        {


        }
    }

}

