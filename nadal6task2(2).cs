using System;

class Programm
{
    static void Main(string[] args)
    {
        Pangakaart kaart1 = new Pangakaart();
        Pangakaart kaart2 = new Pangakaart();

        kaart1.MääraKaardiNumber("12345678");
        kaart2.MääraKaardiNumber("123");

        kaart1.LisaRaha(50);
        kaart1.PrindiKontoSaldo();

        kaart2.VõtaRaha(30);
        kaart2.VõtaRaha(150);
    }
}
