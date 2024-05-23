using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;


namespace homework_w14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List1();
        }

        static void List1()
        {
            Dictionary<int, int> accidentsByYear = new Dictionary<int, int>();
            Dictionary<string, int> deathsByMonth = new Dictionary<string, int>();
            List<string> listforaccidents = new List<string>();
            List<string> listforDeaths = new List<string>();

            // 1999_acitents_Deaths
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\1999_accidents_Deaths.txt"))
            {
                Console.WriteLine($"Deaths % in 1999");
                string line;
                double deathCount = 0;
                double p = 0;
                double avergepros = 0;
                int index = 0;
                int index1 = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforDeaths.Add(line);
                    string month = GetMonthNameFromIndex(index % 12);
                    double Sum = deathCount + Convert.ToInt32(line);
                    deathCount = Sum;
                    double pros = (Convert.ToInt32(line) * 100.0) / 199.0;
                    index1++;
                    double s = p + pros;
                    p = s;
                    double roundedNumber = Math.Round(pros, 2);
                    string roundedNumberString = roundedNumber.ToString();
                    int length = roundedNumberString.Length;
                    avergepros = p / 12;
                    Console.WriteLine($"1999 {month}:{roundedNumberString}%");
                    string mon = GetMonthNameFromIndex(index % 12);
                    if (!deathsByMonth.ContainsKey(mon))
                    {
                        deathsByMonth.Add(mon, 0);
                    }
                    deathsByMonth[mon] += Convert.ToInt32(line);
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine($"All deaths is: {deathCount}");
                Console.WriteLine($"Averge pros is : {avergepros}%");
            }

            // 1999_accidents
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\1999_accidents.txt"))
            {
                string line;
                int Count = 0;
                int Counts = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforaccidents.Add(line);
                    int Sum = Counts + Convert.ToInt32(line);
                    Counts = Sum;
                    int accidents = Convert.ToInt32(line);
                    Count += accidents;
                }
                accidentsByYear.Add(1999, Count);
                Console.WriteLine($"1999: {Counts} accidents");
            }

            // 2009_acitents_Deaths
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\2009_accidents_Deaths.txt"))
            {
                Console.WriteLine();
                Console.WriteLine($"Deaths % in 2009");
                string line;
                double deathCount = 0;
                double p = 0;
                double avergepros = 0;
                int index = 0;
                int index1 = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforDeaths.Add(line);
                    string month = GetMonthNameFromIndex(index % 12);
                    double Sum = deathCount + Convert.ToInt32(line);
                    deathCount = Sum;
                    double pros = (Convert.ToInt32(line) * 100.0) / 85.0;
                    double s = p + pros;
                    p = s;
                    double roundedNumber = Math.Round(pros, 2);
                    string roundedNumberString = roundedNumber.ToString();
                    int length = roundedNumberString.Length;
                    avergepros = p / 12;
                    index1++;
                    Console.WriteLine($"2009 {month}:{roundedNumberString}%");
                    string mon = GetMonthNameFromIndex(index % 12);
                    if (!deathsByMonth.ContainsKey(mon))
                    {
                        deathsByMonth.Add(mon, 0);
                    }
                    deathsByMonth[mon] += Convert.ToInt32(line);
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine($"All deaths is: {deathCount}");
                Console.WriteLine($"Averge pros is : {avergepros}%");
            }

            // 2009_accidents
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\2009_accidents.txt"))
            {
                string line;
                int Count = 0;
                int Counts = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforaccidents.Add(line);
                    int Sum = Counts + Convert.ToInt32(line);
                    Counts = Sum;
                    int accidents = Convert.ToInt32(line);
                    Count += accidents;
                }
                accidentsByYear.Add(2009, Count);
                Console.WriteLine($"2009: {Counts} accidents");
            }

            // 2019_acitents_Deaths
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\2019_accidents_Deaths.txt"))
            {
                Console.WriteLine();
                Console.WriteLine($"Deaths % in 2019");
                string line;
                double deathCount = 0;
                double p = 0;
                double avergepros = 0;
                int index = 0;
                int index1 = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforDeaths.Add(line);
                    string month = GetMonthNameFromIndex(index % 12);
                    double Sum = deathCount + Convert.ToInt32(line);
                    deathCount = Sum;
                    double pros = (Convert.ToInt32(line) * 100.0) / 51.0;
                    double s = p + pros;
                    p = s;
                    double roundedNumber = Math.Round(pros, 2);
                    string roundedNumberString = roundedNumber.ToString();
                    int length = roundedNumberString.Length;
                    avergepros = p / 12;
                    index1++;
                    Console.WriteLine($"2019 {month}:{roundedNumberString}%");
                    string mon = GetMonthNameFromIndex(index % 12);
                    if (!deathsByMonth.ContainsKey(mon))
                    {
                        deathsByMonth.Add(mon, 0);
                    }
                    deathsByMonth[mon] += Convert.ToInt32(line);
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine($"All deaths is: {deathCount}");
                Console.WriteLine($"Averge pros is : {avergepros}%");
            }

            // 2019_accidents
            using (StreamReader reader = new StreamReader("C:\\Users\\tanno\\Downloads\\TARpe23ProgNädal14TaskZip\\2019_accidents.txt"))
            {
                string line;
                int Counts = 0;
                int Count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    listforaccidents.Add(line);
                    int Sum = Counts + Convert.ToInt32(line);
                    Counts = Sum;
                    int accidents = Convert.ToInt32(line);
                    Count += accidents;
                }
                accidentsByYear.Add(2019, Count);
                Console.WriteLine($"2019: {Counts} accidents");
                Console.WriteLine();
                var maxDeaths = deathsByMonth.OrderByDescending(kv => kv.Value).First();

                // Highlight the month with the most deaths
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Month with most deaths: {maxDeaths.Key}, Deaths: {maxDeaths.Value}");
                Console.ResetColor();
                Console.WriteLine();

                var sortedAccidents = accidentsByYear.OrderByDescending(kv => kv.Value);
                Console.WriteLine("Accidents by year (decreasing order):");
                foreach (var kvp in sortedAccidents)
                {
                    // Highlight the year and the number of accidents
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} accidents");
                    Console.ResetColor();
                }
            }
        }

        static string GetMonthNameFromIndex(int index)
        {
            switch (index)
            {
                case 0: return "January";
                case 1: return "February";
                case 2: return "March";
                case 3: return "April";
                case 4: return "May";
                case 5: return "June";
                case 6: return "July";
                case 7: return "August";
                case 8: return "September";
                case 9: return "October";
                case 10: return "November";
                case 11: return "December";
                default: return "";
            }
        }
    }
}
