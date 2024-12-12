using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeueProjektarbeit
{
    internal class Räume
    {
        bool istVerfuegbar;
        public string name;

        public Räume(string name)
        {
            IstVerfuegbar = true;
            Name = name;

        }
        public bool IstVerfuegbar { get => istVerfuegbar; set => istVerfuegbar = value; }
        public string Name { get => name; set => name = value; }

        
            


            //public class Raum
            //{
            //    public int RaumNr { get; set; }
            //    public Dictionary<DateTime, DateTime> Buchungen { get; set; }

            //    public Raum(int raumNr)
            //    {
            //        this.RaumNr = raumNr;
            //        this.Buchungen = new Dictionary<DateTime, DateTime>();
            //    }

            //    public bool IstVerfügbar(DateTime startZeit, DateTime endZeit)
            //    {
            //        foreach (KeyValuePair<DateTime, DateTime> buchung in this.Buchungen)
            //        {
            //            if (startZeit < buchung.Value && endZeit > buchung.Key)
            //            {
            //                return false;
            //            }
            //        }
            //        return true;
            //    }


            //public void Buchen(DateTime startZeit, DateTime endZeit)
            //{
            //    if (this.istVerfügbar1(startZeit, endZeit))
            //    {
            //        this.Buchungen.Add(startZeit, endZeit);
            //        Console.WriteLine("Raum {0} wurde für den Zeitraum von {1} bis {2} gebucht.",
            //            this.startZeit.ToString(), endZeit.ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Raum {0} ist für den Zeitraum von {1} bis {2} nicht verfügbar.",
            //            this.RaumNr, startZeit.ToString(), endZeit.ToString());
            //    }
            //}




        
    }
}
    


