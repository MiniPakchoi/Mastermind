using Mastermind;
using System.Collections.Concurrent;
int geheimCodeStellen = 4;
int rateVersuche = 0;
string code = "";
Random geheimCode = new Random(); //Wird benötigt um den "Geheimcode zu generieren"
int stellenKorrekt = 0;
int ziffernKorrekt = 0;
string nochmal = "";
//static bool SequenceEquals(List<string> list, List<string> list2) 
//{
//    for(int i = 0; i < list.Count; i++) 
//    {
//        if (list[i] != list2[i]) return false;
//    }
//    return true;
//}

do
{
    Console.WriteLine("Willkommen bei MasterMind!");
    Console.WriteLine("Was willst du tun?");
    Console.WriteLine("\n1. Spielablauf durchlesen\n2. Wissenswertes\n3. Eine Runde MasterMind spielen\n4. Ragequit!\n5. Speichern und Verlassen");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            //Spielablauf lesen
            SuperHirn.Spielablauf();
            break;
        case "2":
            // Wissenswertes
            SuperHirn.Wissenswertes();
            break;
        case "3":
            // Eine Runde MasterMind spielen
            Console.WriteLine("Lass uns eine Runde Mastermind spielen! Wenn du in 16 Versuchen den Code nicht erraten hast, hast du verloren!");
            Console.WriteLine($"Gesucht wird ein Code mit {geheimCodeStellen} Stellen.");
            for (int i = 0; i < geheimCodeStellen; i++)
                code += geheimCode.Next(1, 7);

            while (true)
            {
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-");
                char[] benutzerEingabe = Console.ReadLine().ToCharArray();
                if (benutzerEingabe.Length != code.Length)
                {
                    Console.WriteLine($"Gib bitte {geheimCodeStellen} Zahlen ein! Mögliche Zahlen von 1-6");
                    continue;
                }
                if (benutzerEingabe.SequenceEqual(code))
                {
                    rateVersuche++;
                    Console.WriteLine($"Du hast den Geheimcode geknackt, der Code lautete: {code}. Du hast {rateVersuche} Versuch/e gebraucht");
                    Console.WriteLine("Willst du noch eine Runde spielen? (j/n)", ++rateVersuche);
                    nochmal = Console.ReadLine();
                    if(nochmal == "n")
                    {
                        Console.WriteLine("\n Tschöö mit ö, du landest gleich wieder im Menü!");
                        break;

                    }

                    Console.WriteLine($"\nGesucht wird ein Code mit {geheimCodeStellen} Stellen.");
                    code = "";
                    for (int i = 0; i < geheimCodeStellen; i++)
                        code += geheimCode.Next(0, 6);

                    rateVersuche = 0;
                    continue;
                }
                // Stelle  korrekt
                char[] codeL = code.ToCharArray();
                for (int i = 0;i < geheimCodeStellen; i++)
                {
                    if (codeL[i] == benutzerEingabe[i])
                    {
                        stellenKorrekt++;
                        benutzerEingabe[i] = '+';
                        codeL[i] = '-';
                        continue;
                    }

                    // Ziffern richtig aber am falschen Ort
                    if (codeL.Contains(benutzerEingabe[i]) && codeL[Array.IndexOf(codeL, benutzerEingabe[i])] != benutzerEingabe[Array.IndexOf(codeL, benutzerEingabe[i])])
                    {
                        ziffernKorrekt++;
                        codeL[Array.IndexOf(codeL, benutzerEingabe[i])] = '#';
                    }
                }
                Console.WriteLine($"Stelle/n richtig: {stellenKorrekt}");
                Console.WriteLine($"Ziffer/n richtig: {ziffernKorrekt}");
                stellenKorrekt = 0;
                ziffernKorrekt = 0;
                rateVersuche++;
                Console.WriteLine($"{code}");
            }

            break;
        case "4":
            // Ragequit!
            
            break;
        case "5":
            // Spiel speichern & verlassen

            break;
        default:
            // Bei falsche Eingabe, Hinweis geben.
            if (input != "1" || input != "2" || input != "3" || input != "4")
            {
                Console.WriteLine("\nBitte gebe eine Zahl von 1 bis 4 ein!\n");
                break;
            }
            break;
            

    }
} while (true);

//user soll zahlen für farben