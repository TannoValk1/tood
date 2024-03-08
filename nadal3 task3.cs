using System.IO;
class Program
{
    static void Main()
    {
        KirjutaNumbriteRuut(4);
    }
    static void KirjutaNumbriteRuut(int suurus)
    {
        using (StreamWriter kirjutaja = new StreamWriter("ruut.txt"))
        {
            for (int i = 0; i < suurus; i++)
            {
                kirjutaja.WriteLine(new string((char)(suurus + '0'), suurus));
            }
        }
    }
}
