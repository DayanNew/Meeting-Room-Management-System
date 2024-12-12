using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeueProjektarbeit
{
    internal class Menu
    {
        public static void DMTUnternehmen()
        {
            List<string> cateringOrderList = new List<string>();
            List<string> techSupportList = new List<string>();

            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\t\tWillkommen im DMT Unternehmen!\n");
            Console.WriteLine("\t\t\t\tWas möchten Sie tun?\n\t\t\t\tBitte wählen Sie den gewünschten Vorgang.\n");
            Console.WriteLine("\t\t\t\t0 - Informationen über unsere Büroräume erhalten");
            Console.WriteLine("\t\t\t\t1 - Besprechungsraum mit Catering und Technik buchen");
            Console.WriteLine("\t\t\t\t2 - Besprechungsraum mit Technik buchen");
            Console.WriteLine("\t\t\t\t3 - Besprechungsraum ohne Technik und Catering");
            Console.WriteLine("\t\t\t\t4 - Beenden");

            Infotafel.Ausstattung();

            Console.ReadLine();


        }
    }
}
