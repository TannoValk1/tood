using System;

class Program
{
    static void Main(string[] args)
    {
        string[] isikukoodid = {
            "61107121760",
        };
        foreach (var kood in isikukoodid)
        {
            string isikukoodValue = kood;
            if (isikukoodValue.Length != 11)
            {
                Console.WriteLine("Isikukood peab olema 11 numbrit!!!");
                continue;
            }
            string sünnikuupäev = $"{isikukoodValue[5]}{isikukoodValue[6]}.{isikukoodValue[3]}{isikukoodValue[4]}.{isikukoodValue[1]}{isikukoodValue[2]}";
            char suguChar = isikukoodValue[0];
            string sugu = (suguChar % 2 == 0) ? "naine" : "mees";
            string sünnikoht = GetSünnikoht(isikukoodValue.Substring(7, 3));
            int sünnijärjekorranumber = int.Parse(isikukoodValue.Substring(9, 2));
            int kontrollnumber = isikukoodValue[10] - '0';
            Console.WriteLine($"Isikukood: {isikukoodValue}");
            Console.WriteLine($"Sünnikuupäev: {sünnikuupäev}");
            Console.WriteLine($"Sugu: {sugu}");
            Console.WriteLine($"Sünnikoht: {sünnikoht}");
            Console.WriteLine($"Sünnijärjekorranumber: {sünnijärjekorranumber}");
            Console.WriteLine($"Kontrollnumber: {kontrollnumber}");
        }
    }
    static string GetSünnikoht(string sünnikohaKood)
    {
        int kodinumber = int.Parse(sünnikohaKood);
        if (kodinumber >= 1 && kodinumber <= 10)
            return "Kuressaare haigla";
        else if (kodinumber >= 11 && kodinumber <= 19)
            return "Tartu Ülikooli Naistekliinik";
        else if (kodinumber >= 21 && kodinumber <= 150)
            return "Ida-Tallinna keskhaigla, Pelgulinna sünnitusmaja (Tallinn)";
        else if (kodinumber >= 151 && kodinumber <= 160)
            return "Keila haigla";
        else if (kodinumber >= 161 && kodinumber <= 220)
            return "Rapla haigla, Loksa haigla, Hiiumaa haigla (Kärdla)";
        else if (kodinumber >= 221 && kodinumber <= 270)
            return "Ida-Viru keskhaigla (Kohtla-Järve, endine Jõhvi)";
        else if (kodinumber >= 271 && kodinumber <= 370)
            return "Maarjamõisa kliinikum (Tartu), Jõgeva haigla";
        else if (kodinumber >= 371 && kodinumber <= 420)
            return "Narva haigla";
        else if (kodinumber >= 421 && kodinumber <= 470)
            return "Pärnu haigla";
        else if (kodinumber >= 471 && kodinumber <= 490)
            return "Haapsalu haigla";
        else if (kodinumber >= 491 && kodinumber <= 520)
            return "Järvamaa haigla (Paide)";
        else if (kodinumber >= 521 && kodinumber <= 570)
            return "Rakvere haigla, Tapa haigla";
        else if (kodinumber >= 571 && kodinumber <= 600)
            return "Valga haigla";
        else if (kodinumber >= 601 && kodinumber <= 650)
            return "Viljandi haigla";
        else if (kodinumber >= 651 && kodinumber <= 700)
            return "Lõuna-Eesti haigla (Võru), Põlva haigla";
        else
            return "Kontrolli kas sisestasid oma isikukoodi õigesti";
    }
}
