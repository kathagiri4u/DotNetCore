using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq{
    public class Student
    {
        #region data

        public enum GradeLevel{FirstYear = 1, SecondYear, ThirdYear, FourthYear};
        public string FirstName{get;set;}
        public string LastName{get; set;}
        public int Id {get; set;}
        public GradeLevel Year;

        public List<int> ExamScores;

        protected static List<Student> students = new List<Student>{
            new Student {FirstName = "Terry", LastName = "Adams", Id = 120,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 99, 82, 81, 79}},
        new Student {FirstName = "Fadi", LastName = "Fakhouri", Id = 116,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 99, 86, 90, 94}},
        new Student {FirstName = "Hanying", LastName = "Feng", Id = 117,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 93, 92, 80, 87}},
        new Student {FirstName = "Cesar", LastName = "Garcia", Id = 114,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 97, 89, 85, 82}},
        new Student {FirstName = "Debra", LastName = "Garcia", Id = 115,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 35, 72, 91, 70}},
        new Student {FirstName = "Hugo", LastName = "Garcia", Id = 118,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 92, 90, 83, 78}},
        new Student {FirstName = "Sven", LastName = "Mortensen", Id = 113,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 88, 94, 65, 91}},
        new Student {FirstName = "Claire", LastName = "O'Donnell", Id = 112,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 75, 84, 91, 39}},
        new Student {FirstName = "Svetlana", LastName = "Omelchenko", Id = 111,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 97, 92, 81, 60}},
        new Student {FirstName = "Lance", LastName = "Tucker", Id = 119,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 68, 79, 88, 92}},
        new Student {FirstName = "Michael", LastName = "Tucker", Id = 122,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 94, 92, 91, 91}},
        new Student {FirstName = "Eugene", LastName = "Zabokritski", Id = 121,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 96, 85, 91, 60}}

        };

        #endregion

        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();

            return avg > 0 ? (int)avg/10:0;

        }


        public static void QueryHighScores(int exam, int score)
        {
            var highScore = from student in students
                            where student.ExamScores[exam] > score
                            select new {Name = student.FirstName, score = student.ExamScores};   

            foreach(var i in highScore)
            {
                Console.WriteLine("Student Name is - {0} and the score is - {1}", i.Name, i.score);

            }


        }
        
        public static void GroupBySingleProperty()
        {
            Console.WriteLine("Grouping by Single Property");

            var queryLastNames = from Student in students
                                 group Student by Student.LastName into newgroup
                                 orderby newgroup.Key
                                 select newgroup;

            foreach(var group in queryLastNames)
            {
                Console.WriteLine($"key : {group.Key}");

                foreach(var student in group)
                {

                    Console.WriteLine($"\t {student.LastName}, {student.FirstName}");
                }
            }
        }
        
    }
}