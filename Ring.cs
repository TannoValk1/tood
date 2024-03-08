using System;

public class Ring {
    private double _raadius;
    private double _läbimõõt;

    public Ring() {
        _raadius = 0;
        _läbimõõt = 0;
    }

    public Ring(double raadius) {
        _raadius = raadius;
        _läbimõõt = raadius * 2;
    }

    public void PrindiInfo() {
        if (_raadius == 0 || _läbimõõt == 0) {
            Console.WriteLine("ring moodud pole sisestatud!");
        } else {
            Console.WriteLine($"ringi raadius: {_raadius}läbimõõt:{_läbimõõt}");
        }
    }

    public void MääraRaadius(double raadius) {
        _raadius = raadius;
        _läbimõõt = raadius * 2;
        PrindiInfo();
    }

    public void MääraLäbimõõt(double läbimõõt) {
        _raadius = läbimõõt / 2;
        _läbimõõt = läbimõõt;
        PrindiInfo();
    }

    public void ArvutaPindala() {
        double pindala = Math.PI * _raadius * _raadius;
        Console.WriteLine($"ringi pindala:{Math.Round(pindala, 2)}");
    }

    public void ArvutaÜmbermõõt() {
        double ümbermõõt = 2 * Math.PI * _raadius;
        Console.WriteLine($"ringi ümbermõõt:{Math.Round(ümbermõõt, 2)}");
    }
}
