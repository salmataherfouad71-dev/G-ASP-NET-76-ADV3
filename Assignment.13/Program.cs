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
            #region Exercise3
            //1)
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    { "Ahmad","01111"},
            //    { "Mona","02222"},
            //    { "Salma","03333"},
            //    { "Omar","04444"}
            //};
            ////2)
            //phoneBook["Ali"]="05555";
            ////3)
            //try
            //{
            //    phoneBook.Add("Salma", "09878");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception!"+ex);
            //}
            ////4)
            //Console.WriteLine($"Is Adding To Ali Available? {phoneBook.TryAdd("Ali","0789")}");
            ////5)
            //Console.WriteLine($"Is Sarah exist? {phoneBook.ContainsKey("Sarah")}");
            ////6)
            //Console.Write("Is Sarah Found? ");
            //Console.WriteLine(phoneBook.TryGetValue("Sarah",out string phoneNumber)?phoneNumber: "Not Found");
            ////7)
            //foreach (KeyValuePair<string, string> item in phoneBook)
            //{
            //    Console.Write($"{item.Key} ");
            //}
            //Console.WriteLine();
            //foreach (KeyValuePair<string, string> item in phoneBook)
            //{
            //    Console.Write($"{item.Value} ");
            //}
            #endregion
            #region Exercise4
            ////1)
            //HashSet<string> emailAddresses = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            ////2)
            //{
            //    "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //};
            ////3)
            //Console.WriteLine($"{emailAddresses.Count}");
            ////It just two elements because we used case insensitive comparer, so there is 
            ////two elements repete and in HashSets when an element repete it just ignores it.
            ////4)
            //HashSet<int> A = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int>() { 4, 5, 6, 7, 8 };
            //HashSet<int> C = new HashSet<int>() { 1, 2 };
            ////5)
            //A.UnionWith( B );
            //PrintHashSet( A );
            //A.IntersectWith(B);
            //PrintHashSet(A);
            //A.ExceptWith(B);
            //PrintHashSet( A );
            ////6)
            //Console.WriteLine($"[1,2] is a subset of Set A?{A.IsSubsetOf(C)}");
            #endregion
            #region Exercise5
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");
            ////1)
            //foreach (string item in documents)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Count:{documents.Count}");
            ////2)
            //Console.WriteLine($"which document will print next? {documents.Peek()}");
            ////3)
            //for (int i = 0; i < 5; i++) 
            //{ 
            //    Console.WriteLine($"Printing: {documents.Dequeue()}");
            //}
            //Console.WriteLine($"Can I Dequeue? {documents.TryDequeue(out string result)}");
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
        static void PrintHashSet(HashSet<int>set)
        {
            foreach (int item in set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
