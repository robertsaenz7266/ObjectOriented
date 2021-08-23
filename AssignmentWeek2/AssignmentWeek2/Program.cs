using System;

namespace AssignmentWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.Name = "Robert Saenz!";
            student1.Major = "Computer Information Systems Technology.";
            student1.Subjects = "Spreadsheets ,Intro to C#, OOP, HTML.";
            student1.PrintStudentInfo();
        }
    }
}
