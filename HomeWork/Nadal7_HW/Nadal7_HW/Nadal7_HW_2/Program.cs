using System;

namespace Nadal7_HW_2
{
    enum ProgramType
    {
        Linen,
        Cotton,
        Silk,
        Synthetics
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegularIron MyRegularIron = new RegularIron();
            PremiumIron MyPremiumIron = new PremiumIron();
            LinenIron MyLinenIron = new LinenIron();
            MyRegularIron.UseSteam();
            MyRegularIron.DoIroning(170);
            MyRegularIron.DoIroning(160);
            MyRegularIron.Clean();

            MyPremiumIron.UseSteam();
            MyPremiumIron.DoIroning(ProgramType.Cotton);
            MyPremiumIron.DoIroning(ProgramType.Silk);
            MyPremiumIron.Clean();

            MyLinenIron.UseSteam();
            MyLinenIron.DoIroning(ProgramType.Linen);
            MyLinenIron.DoIroning(ProgramType.Cotton);
            MyLinenIron.Clean();
        }
    }

    class RegularIron
    {
        private int usageCount;
        private bool isSteamUsed;

        public string Descale()
        {
            usageCount = 0;
            return "Machine is cleaned.";
        }

        public string DoIroning(int temperature)
        {
            usageCount++;
            if (usageCount >= 3)
            {
                return Descale();
            }
            if (isSteamUsed)
            {
                isSteamUsed = false;
                return $"Regular machine is ironing with {temperature} degrees without steam.";
            }
            return $"Regular machine is ironing with {temperature} degrees.";
        }

        public void UseSteam()
        {
            isSteamUsed = true;
            Console.WriteLine("Steam used in regular iron.");
        }

        public void Clean()
        {
            Console.WriteLine(Descale());
        }

        public string TurnOn()
        {
            return "Regular iron turned on.";
        }

        public string TurnOff()
        {
            return "Regular iron turned off.";
        }
    }

    class PremiumIron
    {
        private int usageCount;
        private bool isSteamUsed;

        public string Descale()
        {
            usageCount = 0;
            return "Machine is cleaned.";
        }

        public string DoIroning(ProgramType programType)
        {
            usageCount++;
            if (usageCount >= 3)
            {
                return Descale();
            }
            if (isSteamUsed)
            {
                isSteamUsed = false;
                return $"Premium machine is ironing with {programType} program without steam.";
            }
            return $"Premium machine is ironing with {programType} program.";
        }

        public void UseSteam()
        {
            isSteamUsed = true;
            Console.WriteLine("Steam used in premium iron.");
        }

        public void Clean()
        {
            Console.WriteLine(Descale());
        }

        public string TurnOn()
        {
            return "Premium iron turned on.";
        }

        public string TurnOff()
        {
            return "Premium iron turned off.";
        }
    }

    class LinenIron
    {
        private int usageCount;
        private bool isSteamUsed;

        public string Descale()
        {
            usageCount = 0;
            return "Machine is cleaned.";
        }

        public string DoIroning(ProgramType programType)
        {
            usageCount++;
            if (usageCount >= 3)
            {
                return Descale();
            }
            if (isSteamUsed)
            {
                isSteamUsed = false;
                return $"Linen machine is ironing with {programType} program without steam.";
            }
            return $"Linen machine is ironing with {programType} program.";
        }

        public void UseSteam()
        {
            isSteamUsed = true;
            Console.WriteLine("Steam used in linen iron.");
        }

        public void Clean()
        {
            Console.WriteLine(Descale());
        }

        public string TurnOn()
        {
            return "Linen iron turned on.";
        }

        public string TurnOff()
        {
            return "Linen iron turned off.";
        }
    }
}