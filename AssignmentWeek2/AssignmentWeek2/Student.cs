using System;
namespace AssignmentWeek2
{
    class Student
    {
        public string Name;
        public string Major;
        public string Subjects;
        
            
            
        


        public void PrintStudentInfo()
        {
            Console.WriteLine("Hello my Name is {0}", Name);
            Console.WriteLine("My major is {0}", Major);
            Console.WriteLine("My subjects are {0}", Subjects);
            Console.ReadLine();
        }

        Subject subjects = new Subject();
        
        
    }
}
