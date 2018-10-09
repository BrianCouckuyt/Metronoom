using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MetronoomAPI
{
    public class Metronoom
    {
        public event MetronoomTiktHandler Getikt;

        private Timer timer;
        public Metronoom()
        {
            timer = new Timer();
            timer.Interval = 3000;
            // Om de 3 seconden wordt een event geraised
            timer.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Getikt != null)
            {
                // Maak een instantie en vul deze op
                MetronoomTiktEventArgs args = new MetronoomTiktEventArgs();
                args.TijdstipVanTik = DateTime.Now;
                // Voer het event(delegate) uit met de vereiste argumenten
                Getikt(this, args);
            }
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
