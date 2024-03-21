using System;

public class Pangakaart
{
    private double kontoSaldo;
    private string kaardiTüüp;
    private string kaardiNumber;

    public Pangakaart()
    {
        kontoSaldo = 0;
        kaardiTüüp = "Visa";
    }

    public void MääraKaardiNumber(string number)
    {
        if (number.Length != 8)
            Console.WriteLine("Vigane kaardi number!");
        else
        {
            kaardiNumber = number;
            Console.WriteLine("Kaardi number : " + kaardiNumber);
        }
    }

    public void PrindiKontoSaldo()
    {
        Console.WriteLine("Konto väärtus: " + kontoSaldo);
    }

    public void LisaRaha(double summa)
    {
        kontoSaldo += summa;
        Console.WriteLine("Lisatud " + summa + " eurot kontole. Uus konto väärtus: " + kontoSaldo);
    }

    public void VõtaRaha(double summa)
    {
        if (kontoSaldo - summa < 0)
            Console.WriteLine("Raha pole piisavalt");
        else
        {
            kontoSaldo -= summa;
            Console.WriteLine("Võetud " + summa + " eurot kontolt. Uus konto vääruts: " + kontoSaldo);
        }
    }
}
