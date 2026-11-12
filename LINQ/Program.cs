using static System.Console;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = list.Where(n => n > 5);// 6, 7, 8, 9, 10
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("////////////////////////////////////");
            var result2 = list.Select(n => n * 2);
            foreach (int n in result2)
            {
                Console.WriteLine(n);
            }

            // сортування - ASC - за зростанням, DESC - за спаданням
            var result3 = list.OrderBy(n => n); //ASC
            var result4 = list.OrderByDescending(n => n); //DESC
            Console.WriteLine("Sort by ASC");
            foreach (int n in result3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Sort by DESC");
            foreach (int n in result4)
            {
                Console.WriteLine(n);
            }

            //var first = list.First(n => n > 10);
            var firstOrDef = list.FirstOrDefault(n => n > 10);
            // Console.WriteLine(first);
            Console.WriteLine(firstOrDef);

            int count = list.Count();
            int sum = list.Sum();
            double avg = list.Average();

            var groups = list.GroupBy(n => n % 2);

            foreach (var group in groups)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var val in group)
                {
                    Console.WriteLine($"Value: {val}");
                }
            }


            Console.WriteLine("Filtering: ");
            var result5 = list.Where(n => n > 5)
                .OrderByDescending(n => n)
                .Select(n => n * 2);//Method style

            foreach (var n in result5)
            {
                Console.WriteLine(n);
            }

            //Query(SQL) style
            var result6 =
                from n in list
                where n > 5
                orderby n descending
                select n * 2;*/

            /* List<Student> students = new()
             {
                 new Student { Name = "Tom", Age = 10, Grade = 7 },
                 new Student { Name = "Jerry", Age = 9, Grade = 8 },
                 new Student { Name = "Harry Potter", Age = 10, Grade = 6 }
             };

             var result = students
                 .Where(s => s.Age > 10)
                 .OrderByDescending(s => s.Age)
                 .Select(s => s.Name);

             foreach (var student in result)
             {
                 Console.WriteLine(student.ToList());
             }
         */

            /*int[] numbers = { 5, 14, 7, 21, 8, 16, 24, 35, 42, 3, 10, 56 };

            var allNumbers = numbers;

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var oddNumbers = numbers.Where(n => n % 2 == 0);

            int num = 15;
            var graterThan = numbers.Where(n => n > num);

            int min = 10, max = 30;
            var niRange = numbers.Where(n => n >= min && n <= max);

            var divBy7 = numbers.Where(n => n % 7 == 0).OrderBy(n => n);

            var divBy8 = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n);

            WriteLine($"1. allNumbers: {string.Join(", ", allNumbers)}");
            WriteLine();
            WriteLine($"2. evenNumbers: {string.Join(", ", evenNumbers)}");
            WriteLine();
            WriteLine($"3. evenNumbers: {string.Join(", ", evenNumbers)}");
            WriteLine();
            WriteLine($"4. graterThan ({num}): {string.Join(", ", graterThan)}");
            WriteLine();
            WriteLine($"5. niRange ({min} <= x <= {max}): {string.Join(", ", niRange)}");
            WriteLine();
            WriteLine($"6. divBy7: {string.Join(", ", divBy7)}");
            WriteLine();
            WriteLine($"7. divBy8: {string.Join(", ", divBy8)}");*/

            string[] cities = { "Odessa", "Kiyev", "London", "Paris", "Berlin", "Rome", "Madrid", "Ajfdskhbfds", "sjhM", "NfhegeyK", "Neuftsd"};

            var allCities = cities;

            int len = 6;
            var citiesByLen = cities.Where(c => c.Length == len);

            var startWithA = cities.Where(c => c.StartsWith("A"));

            var endWithM = cities.Where(c => c.EndsWith("M"));

            var startNEndK = cities.Where(c => c.StartsWith("N") && c.EndsWith("K"));

            var startWithNeDesc = cities.Where(c=>c.StartsWith("Ne")).OrderByDescending(c => c.Length);

            WriteLine($"1. allCities: {string.Join(", ", allCities)}");
            WriteLine();
            WriteLine($"2. allCities(len:{len}): {string.Join(", ", allCities)}");
            WriteLine();
            WriteLine($"3. startWithA: {string.Join(", ", startWithA)}");
            WriteLine();
            WriteLine($"4. endWithM: {string.Join(", ", endWithM)}");
            WriteLine();
            WriteLine($"5. startNEndK: {string.Join(", ", startNEndK)}");
            WriteLine();
            WriteLine($"6. startWithNeDesc: {string.Join(", ", startWithNeDesc)}");
            WriteLine();


        }

    }
}
