using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace User_Input
{
    internal class Program
    {
        static int[] gradeStore = new int [7];
        static void Main(string[] args)
        {
            int points = 0;
            int grade = 0;
            int total = 0;
            string path = "../../../../grade.txt";

            






            GetsGrade(path, grade , points , total );

        }       
        static private void GetsGrade(string path , int grade , int points , int total)
        {
            for (int i = 0; i < gradeStore.Length; i++)
            {
                Console.Write("Enter Grade :");
                grade = int.Parse(Console.ReadLine());


                if (grade >= 0 && grade < 30)
                {
                    points = 0;
                }
                else if (grade >= 30 && grade < 40)
                {
                    points = 37;
                }
                else if (grade >= 40 && grade < 50)
                {
                    points = 46;
                }
                else if (grade >= 50 && grade < 60)
                {
                    points = 56;
                }
                else if (grade >= 60 && grade < 70)
                {
                    points = 66;
                }
                else if (grade >= 70 && grade < 80)
                {
                    points = 77;
                }
                else if (grade >= 80 && grade < 90)
                {
                    points = 88;
                }
                else if (grade >= 90 && grade <= 100)
                {
                    points = 100;
                }

                total += points;


            }
            File.AppendAllText(path, Environment.NewLine + "Total Points : " + total.ToString());
            File.AppendAllText(path, Environment.NewLine + "Total Points : " + total.ToString());
            File.AppendAllText(path, Environment.NewLine + "Total Points : " + total.ToString());
        }
        


    }
}
