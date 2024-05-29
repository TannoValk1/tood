using System;

namespace Homework_w14_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            manipulation("juhan.juurikas@company.eu");
            createMail("juhan mart juurikas", "Juhan juurikas Company");
        }

        static public void manipulation(string mail)
        {
            const int maxLength = 15;
            string sampleEmail = "juhan.juurikashruvhhre";

            if (sampleEmail.Length > maxLength)
            {
                sampleEmail = sampleEmail.Substring(0, maxLength);
            }

            string[] sampleParts = sampleEmail.Split(new[] { ".", "@" }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Max Length Name: ");
            foreach (string part in sampleParts)
            {
                Console.Write(part + " ");
            }
            Console.WriteLine();

            string[] nameParts = mail.Split(new[] { ".", "@company.eu" }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Name: ");
            foreach (string part in nameParts)
            {
                Console.Write(part.ToUpper() + " ");
            }
            Console.WriteLine();

            string[] domainParts = mail.Split(new[] { "juhan.juurikas@", ".eu" }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Domain: ");
            foreach (string part in domainParts)
            {
                Console.Write(part + " ");
            }
            Console.WriteLine();
        }

        static public void createMail(string name, string organization)
        {
            Console.Write("Name: ");
            Console.WriteLine(name);

            Console.Write("Mail: ");
            string formattedName = name.Replace(' ', '.').Replace(',', '.');
            Console.WriteLine(formattedName + "@Company.eu");

            Console.Write("Name: ");
            Console.WriteLine(organization);

            Console.Write("Mail: ");
            string formattedOrganization = organization.Replace(" ", "").Replace('.', ' ').Replace(':', '@');
            Console.WriteLine(formattedOrganization + ".eu");
        }
    }
}
