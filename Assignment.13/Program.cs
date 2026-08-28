using System.ComponentModel;

namespace Assignment._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise1
            ////1)
            //List<double> grades = new List<double>()
            //{ 85, 92, 78, 95, 88, 70, 100, 65};
            ////2)
            //Print(grades);
            //Console.WriteLine();
            //Console.WriteLine($"Count:{grades.Count}");
            //Console.WriteLine($"First Grade:{grades[0]}");
            //Console.WriteLine($"Last Grade:{grades[grades.Count-1]}");
            //Console.WriteLine();
            ////3)
            //grades.Sort();
            //Console.Write("After Sorting:");
            //Print(grades);
            //Console.WriteLine();
            ////4)
            //Console.WriteLine($"First Grade Above 90:{grades.Find((double grade)=>grade>90)}");
            ////5)
            //Console.Write($"Failing Grades:");
            //Print(grades.FindAll((double grade) => grade < 75));
            ////6)
            //Console.WriteLine("After Removing Failing Grades:");
            //grades.RemoveAll((double grade) => grade < 75);
            //Print(grades);
            ////7)
            //Console.WriteLine($"Is there is a grade equals 100? {grades.Contains(100)}");
            //Console.WriteLine();
            ////8)
            //List<string> stringGrades = new List<string>();
            //foreach (double grade in grades)
            //{
            //    stringGrades.Add($"Grade: {grade}");
            //}
            //Print (stringGrades);
            #endregion
            #region Exercise2
            ////1)
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>(new KeyCompare());
            //leaderboard.Add(500 , "Ahmed");
            //leaderboard.Add(200 , "Sara");
            //leaderboard.Add(800 , "Ali");
            //leaderboard.Add(350 , "Mona");
            ////2)
            //foreach (KeyValuePair<int, string> entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Value}:{entry.Key}");
            //}
            ////3)
            //Console.WriteLine($"First Key:{leaderboard.Keys.First()}");
            //Console.WriteLine($"First value:{leaderboard.Values.First()}");
            ////4)
            //Console.WriteLine($"Is key 500 exists?{leaderboard.TryGetValue(500,out string value)}");
            ////5)
            //Console.WriteLine($"Is Key 999 exists?{leaderboard.TryGetValue(999, out string value1)}\n999:{value1}");
            ////6)
            //Console.WriteLine("After Removing Key 200:");
            //leaderboard.Remove(200);
            //foreach (KeyValuePair<int, string> entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Value}:{entry.Key}");
            //}
            #endregion
        }
        static void Print<T>(List<T>list)
        {
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
