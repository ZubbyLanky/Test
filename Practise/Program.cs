using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int numberOfCourses = 5;


            int[] studentA = { 36, 3, 100, 13, 92, 94, 90 };
            int[] studentB = { 35, 190, 77, 29, 16, 89 };
            int[] studentC = { 36, 144, 19, 29, 88,89, 89, 89 };
            int[] studentD = { 42, 74, 45, 100, 63, 06 };


            //Student Names
            string[] studentsNames = new string[] { "studentA", "studentB", "studentC", "studentD" };

            int[] studentsAverage = new int[4];

            string studentGradeLetter = "";

            Console.WriteLine($"Student \t\tGrade\n");


            foreach (string name in studentsNames)
            {
                string currentName = name;

                if (currentName == "studentA")
                    studentsAverage = studentA;

                else if (currentName == "studentB")
                    studentsAverage = studentB;

                else if (currentName == "studentC")
                    studentsAverage = studentC;

                else if (currentName == "studentD")
                    studentsAverage = studentD;

                int sumScores = 0;
                double studentAverage;


                foreach (int score in studentsAverage)
                {
                    sumScores += score;
                }

                studentAverage = (double)sumScores / (int)numberOfCourses;

                if (studentAverage >= 97)
                    studentGradeLetter = "A+";

                else if (studentAverage >= 93)
                    studentGradeLetter = "A";

                else if (studentAverage >= 90)
                    studentGradeLetter = "A-";

                else if (studentAverage >= 87)
                    studentGradeLetter = "B+";

                else if (studentAverage >= 83)
                    studentGradeLetter = "B";

                else if (studentAverage >= 80)
                    studentGradeLetter = "B-";

                else if (studentAverage >= 77)
                    studentGradeLetter = "C+";

                else if (studentAverage >= 73)
                    studentGradeLetter = "C";

                else if (studentAverage >= 70)
                    studentGradeLetter = "C-";

                else if (studentAverage >= 67)
                    studentGradeLetter = "D+";

                else if (studentAverage >= 63)
                    studentGradeLetter = "D";

                else if (studentAverage >= 60)
                    studentGradeLetter = "D-";

                else
                    studentGradeLetter = "F";


                //Will be using the value of score to access the value of each element in the array.
                Console.WriteLine($"{name}:\t\t {studentAverage} \t {studentGradeLetter}");

            }
            Console.WriteLine("\nPlease press the enter key to continue");

            Console.ReadLine();
            // System.Console.ReadKey();
        }
    }
}
