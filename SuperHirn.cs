using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    internal class SuperHirn
    {
        internal static void Spielablauf()
        {
            Console.WriteLine("Der Computergegner wählt einen geheimen Farbcode mit vier Farben aus.(Farben können auch mehrfach vorkommen)");
            Console.WriteLine("Nun darf der Spieler vier Farbpins stecken.");
            Console.WriteLine("Der Computergegner gibt an ob bei den vier Farbpins richtige Farben dabei sind oder sogar am richigen Platz stecken.");
            Console.WriteLine("Das Spiel ist verloren, wenn der Farbcode nach 16 Versuchen nicht gefunden wurde.");
            Console.WriteLine("Drücke eine Taste um wieder ins Menü zu kommen");
            Console.ReadKey();
            Console.Clear();
        }
        internal static void Wissenswertes()
        {
            Console.WriteLine("Das Spiel wurde von Mordechai Meirovitz 1970 erfunden, leider konnte der Erfinder keine Spielefirma\nüberzeugen sein Spiel auf den Markt zu bringen.");
            Console.Write("Meirovitz stellte dann das Spiel 1971 auf der Spielwarenmesse in Nürnberg vor. Eine englische Firma\nkaufte sich die Recht, verfeinerte das Spiel und brachte es auf den Markt");
            Console.WriteLine("\nMasterMind war 1973 >Game of the Year<");
            Console.WriteLine("Drücke eine Taste um wieder ins Menü zu kommen");
            Console.ReadKey();
            Console.Clear();
        }
       

        enum Colors
        {
            Red = 1,
            Yellow = 2,
            Green = 3, 
            Blue = 4,
            Magenta = 5,
            Grau = 6,
            
        }
    }
}
