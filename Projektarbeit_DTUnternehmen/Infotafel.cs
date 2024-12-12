using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeueProjektarbeit
{
    public class Infotafel
    {
        public static void Ausstattung()
        {

            bool roomBooked = true;
            //Objekte für mein Menu.
            Räume Gebäude0 = new Räume("Informationen über unsere Büroräume");
            Räume Raum1 = new Räume ( "Besprechungsraum mit Catering und Technik");
            Räume Raum2 = new Räume("Besprechungsraum mit Technik ");
            Räume Raum3 = new Räume("Besprechungsraum ohne Technik und Catering");



            do
            {

                Int32.TryParse(Console.ReadLine(), out int auswahl);

                if (auswahl == 0)
                {

                    Console.Clear();
                    Console.WriteLine("\n\t\t================================== DMT Unternehmen ==================================\n");
                    Console.WriteLine($"\n\t\t\t\tHier erhalten Sie{Gebäude0.name}:\n");
                    Console.WriteLine("\t1. OG Raum 123 befinden sich die Besprechungsräume");
                    Console.WriteLine("\t2. OG Raum 234 befindet sich die Vertriebsabteilung");
                    Console.WriteLine("\t3. OG Raum 345 befindet sich die Buchhaltung");
                    Console.WriteLine("\t4. OG Raum 456 befindet sich die Personalabteilung");
                    Console.WriteLine("\t5. OG Raum 567 sitzt die Geschäftsführung");
                    Console.WriteLine("\t6. Dachterasse: Auf unserer Dachteresse finden Sie unsere Cafeteria\n");
                    Hauptmenu();
                }

                else if (auswahl == 1)
                {

                    if (Raum1.IstVerfuegbar == true)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t\t================================== DMT Unternehmen ==================================\n");
                        Console.WriteLine($"\n\tSie haben sich für die Buchung eines {Raum1.name}entschieden.\n");
                        Console.WriteLine("\tBitte geben Sie das Datum der Buchung im Format 'ddMMyyyy' ohne Punkt ein:");
                        Datum();
                        Console.WriteLine("\n\tBitte geben Sie die Startzeit der Buchung im Format hh:mm ein:");
                        Uhrzeit();
                        Console.WriteLine("\n\tBitte geben Sie die Endzeit der Buchung im Format hh:mm ein:");
                        Uhrzeit();
                        Console.WriteLine("\n\tHier ist die Cateringorderliste.");
                        CateringMenu();
                        Console.WriteLine("\n\tBitte wählen Sie die Technik Items aus.\n\tWenn Sie fertig sind geben Sie 4 für Exit ein um die Eingabe abzuschließen:");
                        TechnikMenu();

                        Console.WriteLine("\n\tWir haben für Sie den Raum Nr. 001 gebucht und ein Auftrag wurde an die Cateringabteilung und\n\tTechnikabteilung weitergegeben. Da Sie einen Raum mit Catering und Technik gebucht haben,\n\twird der Raum für Sie vor und nach dem Meeting eine 0,5 Std. für Auf- und Abbauarbeiten geblockt.\n");
                        Raum1.IstVerfuegbar = false;
                        Hauptmenu();
                    }
                    else
                    {
                        Console.WriteLine("Der Besprechungsraum 001 ist leider nicht verfügbar. Bitte wählen Sie einen anderen aus.");
                        Hauptmenu();
                    }
 

                }
                else if (auswahl == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t================================== DMT Unternehmen ==================================\n");
                    Console.WriteLine($"\n\tSie haben sich für die Buchung eines {Raum2.name}entschieden.\n");

                    Console.WriteLine("\tBitte geben Sie das Datum der Buchung im Format 'ddMMyyyy' ein:");
                    Datum();
                    Console.WriteLine("\n\tBitte geben Sie die Startzeit der Buchung im Format hh:mm ein:");
                    Uhrzeit();
                    Console.WriteLine("\n\tBitte geben Sie die Endzeit der Buchung im Format hh:mm ein:");
                    Uhrzeit();
                    Console.WriteLine("\n\tBitte wählen Sie die Technik Items aus.\n\tWenn Sie fertig sind geben Sie 4 für Exit ein um die Eingabe abzuschließen:");
                    TechnikMenu();
                    Console.WriteLine("\n\tDer Raum Nr. 002 ist für Sie gebucht und ein Supportauftrag wurde an die Technikabteilung gegeben!\n");
                    Console.WriteLine("\tDa Sie einen Raum mit Techniksupport gebucht haben,\n\twird der Raum für Sie vor und nach dem Meeting eine 0,5 Std. für Auf- und Abbauarbeiten geblockt.\n");
                    
                    Hauptmenu();

                }

                else if (auswahl == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t================================== DMT Unternehmen ==================================\n");
                    Console.WriteLine($"\n\tSie haben sich für die Buchung eines {Raum3.name}entschieden.\n");
                    Console.WriteLine("Bitte geben Sie das Datum der Buchung im Format 'ddMMyyyy' ein:");
                    Datum();
                    Console.WriteLine("Bitte geben Sie die Startzeit der Buchung im Format hh:mm ein: ");
                    Uhrzeit();
                    Console.WriteLine("Bitte geben Sie die Endzeit der Buchung im Format hh:mm ein:");
                    Uhrzeit();
                    Console.Clear();
                    Console.WriteLine($"\n\tDer Raum Nr. 004 ist für Sie gebucht.\n");
                   
                    Hauptmenu();
                }

                else if (auswahl == 4)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t================================== DMT Unternehmen ==================================\n");
                    Console.WriteLine("\n\tAuf Wiedersehen!\n\n\tBitte drücken Sie Enter um das Programm zu verlassen!");
                    roomBooked = false;
                }

                else
                {
                    Console.WriteLine("\tUngültige Eingabe. Bitte geben Sie eine der aufgeführten Optionen ein.");
                }

            } while (roomBooked == true);


            void Hauptmenu()
            {

                bool Hauptmenu = true;
                do
                {
                    Console.WriteLine("Möchten Sie zurück zum Hauptmenu? ja / nein");
                    string input = Console.ReadLine().ToLower();
                    if (input == "j" || input == "ja")
                    {
                        Menu.DMTUnternehmen();
                        Hauptmenu = true;

                    }
                    else if (input == "n" || input == "nein")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tAuf Wiedersehen!\n\n\tBitte Enter drücken um das Programm zu beenden.");
                        Hauptmenu = true;
                        roomBooked = false;
                    }
                    else
                    {
                        Hauptmenu = false;
                        Console.WriteLine("\tUngültige Eingabe. Bitte geben Sie eine der aufgeführten Optionen ein.");

                    }

                } while (Hauptmenu == false);

            }

        }

        static void CateringMenu()
        {
            Catering order1 = new Catering("\t\tBuffet");
            Catering order2 = new Catering("\t\tSandwiches");
            Catering order3 = new Catering("\t\tKuchen");
            Catering order4 = new Catering("\t\tTee und Kaffee");
            Catering order5 = new Catering("\t\tMinerallwasser und Softdrinks");



            List<Catering> Cateringlist = new List<Catering>();

            bool CateringBooked = false;

            do
            {
                Console.WriteLine("\n\tBitte wählen Sie Ihre Catering aus.\n\tWenn Sie fertig sind geben Sie 6 für Exit ein um die Eingabe abzuschließen:\n");
                Console.WriteLine("\t\t1.Buffet\n\t\t2.Sandwiches\n\t\t3.Kuchen\n\t\t4.Tee und Kaffee\n\t\t5.Minerallwasser und Softdrinks\n\t\t6.Exit");

                Int32.TryParse(Console.ReadLine(), out int auswahl);

                if (auswahl == 1)
                {
                    Console.Clear();
                    Cateringlist.Add(order1);
                    Console.WriteLine("Sie haben folgendes Catering hinzugefügt:");

                    foreach (var i in Cateringlist)
                    {
                        Console.WriteLine(i);
                    }

                }
                else if (auswahl == 2)
                {
                    Console.Clear();
                    Cateringlist.Add(order2);
                    Console.WriteLine("Sie haben folgendes Catering hinzugefügt:");

                    foreach (var i in Cateringlist)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 3)
                {
                    Console.Clear();
                    Cateringlist.Add(order3);
                    Console.WriteLine("Sie haben folgendes Catering hinzugefügt:");

                    foreach (var i in Cateringlist)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 4)
                {
                    Console.Clear();
                    Cateringlist.Add(order4);
                    Console.WriteLine("Sie haben folgendes Catering hinzugefügt:");

                    foreach (var i in Cateringlist)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 5)
                {
                    Console.Clear();
                    Cateringlist.Add(order5);
                    Console.WriteLine("Sie haben folgendes Catering hinzugefügt:");

                    foreach (var i in Cateringlist)
                    {
                        Console.WriteLine(i);
                    }

                }
                else if (auswahl == 6)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tCatering wurde erfolgreich hinzugefügt!");
                    CateringBooked = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }


            } while (CateringBooked == false);

            Console.WriteLine("\n\tSie haben sich für folgende Catering entschieden:\n ");

            foreach (var i in Cateringlist)
            {
                Console.WriteLine(i);
            }

        }
        static void TechnikMenu()
        {
            Technik Item1 = new Technik("\t\tProjektor");
            Technik Item2 = new Technik("\t\tBildschirm");
            Technik Item3 = new Technik("\t\tBeamer");


            List<Technik> TechnikList = new List<Technik>();

            bool TechnikBooked = false;

            do
            {
                Console.WriteLine("\n\tHier ist die Technik-Itemsliste:\n");
                Console.WriteLine("\t\t1.Projektor\n\t\t2.Bildschirm\n\t\t3.Beamer\n\t\t4.Exit");

                Int32.TryParse(Console.ReadLine(), out int auswahl);

                if (auswahl == 1)
                {
                    Console.Clear();
                    TechnikList.Add(Item1);
                    Console.WriteLine("Sie haben folgende Items hinzugefügt:");

                    foreach (var i in TechnikList)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 2)
                {
                    Console.Clear();
                    TechnikList.Add(Item2);
                    Console.WriteLine("Sie haben folgende Items hinzugefügt:");

                    foreach (var i in TechnikList)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 3)
                {
                    Console.Clear();
                    TechnikList.Add(Item3);
                    Console.WriteLine("Sie haben folgende Items hinzugefügt:");

                    foreach (var i in TechnikList)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (auswahl == 4)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tTechnik Items wurden erfolgreich hinzugefügt!");
                    TechnikBooked = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }


            } while (TechnikBooked == false);

            //Mit der foreach Schleife wird die ausgewählte Technik-Items angezeigt.
            Console.WriteLine("\n\tSie haben folgende Techknik Items gebucht:\n ");

            foreach (var i in TechnikList)
            {
                Console.WriteLine(i);
            }
        }

        public static void Datum()
        {
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi.ShortDatePattern = "ddMMyyyy"; // Das Datum muss ohne Punkt geschrieben werden!

            bool gültigeeingabe = false;
            do
            {
                string input = Console.ReadLine();
                DateTime result;
                bool success = DateTime.TryParseExact(input, "ddMMyyyy", dtfi, DateTimeStyles.None, out result);

                if (success)
                {
                    Console.WriteLine("\tDas eingegebene Datum ist: " + result.ToShortDateString());
                    gültigeeingabe = true;
                }
                else
                {
                    Console.WriteLine("\tDas eingegebene Datum ist ungültig. Bitte noch einmal das richtige Format eingeben.");
                }

            } while (gültigeeingabe == false);
        }
        public static void Uhrzeit()
        {
            string input;
            do
            {
                input = Console.ReadLine();

            } while (!IsValidTime(input));
        }

        static bool IsValidTime(string input)
        {
            if (input.Length != 5) // Die Eingabe muss 5 Zeichen lang sein, also hh:mm.
            {
                Console.WriteLine("\n\tUngültiges Format. Bitte geben Sie eine Uhrzeit im Format hh:mm ein.");
                return false;
            }

            string[] time = input.Split(':');
            int hours, minutes;
            if (!int.TryParse(time[0], out hours) || !int.TryParse(time[1], out minutes)) // Überprüfen, ob die Eingabe Zahlen sind.
            {
                Console.WriteLine("\tUngültige Eingabe. Bitte geben Sie eine gültige Uhrzeit im Format hh:mm ein.");
                return false;
            }

            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59) // Überprüfen, ob die Zahlen innerhalb des gültigen Bereichs liegen.
            {
                Console.WriteLine("\tUngültige Uhrzeit. Bitte geben Sie eine gültige Uhrzeit im Format hh:mm ein.");
                return false;
            }

            return true;

        }
        



        
    }
}
