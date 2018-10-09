using MetronoomAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetronoomConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronoom metro = new Metronoom();
            // Toevoegen van Handler aan event Metro.getikt
            metro.Getikt += Metro_Getikt; // of new MetroNoomHandler(Metro_Getikt)
            metro.Start();
            // Om de Console te laten openstaan
            Console.ReadKey();
            metro.Stop();
        }

        private static void Metro_Getikt(object sender, MetronoomTiktEventArgs e)
        {
            Console.WriteLine(e.TijdstipVanTik + ": TIK");
        }
    }
}
