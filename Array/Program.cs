namespace ArrayandMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../results.txt"; 
            string[] fileContents = File.ReadAllLines(path);

            int totalpoints = CalculatePoints(fileContents);

            Console.WriteLine($"The total points are {totalpoints}.");


            Console.ReadLine();

        }

        private static int CalculatePoints(string[] data)
        {
            int[] gradeBound = new int[8] { 90 ,80 ,70 ,60, 50 ,40, 30, 0 };
            int[] higherPoints = new int[8] {100, 88 ,77, 66 ,56 ,46 ,37 ,0 };

            int totalpoints = 0, points = 0, result = 0 ;

            for (int i = 0; i < data.Length; i++)
            {
                result = int.Parse(data[i]);

                for (int j = 0; j < gradeBound.Length; j++)
                {
                    if (result >= gradeBound[j])
                    {
                        points = higherPoints[j];
                        break;
                    }
                }
                totalpoints += points;
            }
            return totalpoints;
        }
    }
}
