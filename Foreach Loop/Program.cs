namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0 , i = 0;
            int grade = 0;
            int total = 0;
            string path = "../../../../results.txt";

            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);


           // string lineIn = sr.ReadLine();

            try
            {
                string[] fileContents = File.ReadAllLines(path);


                foreach (string line in fileContents)
                {

                    Console.WriteLine(fileContents[i]);


                    grade = int.Parse(line);


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

                    i++;



                    //lineIn = sr.ReadLine();

                }



                Console.WriteLine($"You got {total} points total.");

               // sr.Close();
                File.AppendAllText(path, Environment.NewLine + "Total Points : " + total.ToString());

               


            }
            catch (IOException ex) { Console.WriteLine(ex); };
        }
    }
}
