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
            Console.WriteLine("Der Computergegner wählt einen geheimen Code bestehend aus vier Zahlen.(Zahlen können mehrfach vorkommen)");
            Console.WriteLine("Nun darf der Spieler vier Zahlen eingeben.");
            Console.WriteLine("Der Computergegner gibt an, ob bei den vier Zahlen richtige Zahlen dabei sind oder sogar am richigen\nPlatz stehen.Das Spiel ist verloren, wenn der geheim Code nach 16 Versuchen nicht geknackt wurde.");
            
            Console.WriteLine("Drücke eine Taste um wieder ins Menü zu kommen");
            Console.ReadKey();
            Console.Clear();
        }
        internal static void Wissenswertes()
        {
            Console.WriteLine("Das Spiel wurde von Mordechai Meirovitz 1970 erfunden, leider konnte der Erfinder keine Spielefirma\nüberzeugen sein Spiel auf den Markt zu bringen.Meirovitz stellte dann das Spiel 1971 auf der \nSpielwarenmesse in Nürnberg vor. Eine englische Firma kaufte sich die Recht, verfeinerte das Spiel\nund brachte es auf den Markt.");
            Console.WriteLine("MasterMind war 1973 >Game of the Year<");
            Console.WriteLine("Drücke eine Taste um wieder ins Menü zu kommen");
            Console.ReadKey();
            Console.Clear();
        }
        internal static void GameOver()
        {
            string gameover = @"            (`-')  _  <-. (`-')   (`-')  _                      (`-') (`-')  _    (`-')  ,---. 
    .->     (OO ).-/     \(OO )_  ( OO).-/          .->        _(OO ) ( OO).-/ <-.(OO )  |   | 
 ,---(`-')  / ,---.   ,--./  ,-.)(,------.     (`-')----. ,--.(_/,-.\(,------. ,------,) |   | 
'  .-(OO )  | \ /`.\  |   `.'   | |  .---'     ( OO).-.  '\   \ / (_/ |  .---' |   /`. ' |   | 
|  | .-, \  '-'|_.' | |  |'.'|  |(|  '--.      ( _) | |  | \   /   / (|  '--.  |  |_.' | |  .' 
|  | '.(_/ (|  .-.  | |  |   |  | |  .--'       \|  |)|  |_ \     /_) |  .--'  |  .   .' `--'  
|  '-'  |   |  | |  | |  |   |  | |  `---.       '  '-'  '\-'\   /    |  `---. |  |\  \  .--.  
 `-----'    `--' `--' `--'   `--' `------'        `-----'     `-'     `------' `--' '--' `--'  ";
            Console.WriteLine($"{gameover}");
        }
        internal static void Ascii()
        {
            string ascii1 =
@"     .->     _                          <-.(`-')             <-. (`-')  <-. (`-')   (`-')  _ <-. (`-')_ 
 (`(`-')/`) (_)        <-.       <-.     __( OO)       .->      \(OO )_    \(OO )_  ( OO).-/    \( OO) )
,-`( OO).', ,-(`-')  ,--. )    ,--. )   '-'. ,--. (`-')----. ,--./  ,-.),--./  ,-.)(,------. ,--./ ,--/ 
|  |\  |  | | ( OO)  |  (`-')  |  (`-') |  .'   / ( OO).-.  '|   `.'   ||   `.'   | |  .---' |   \ |  | 
|  | '.|  | |  |  )  |  |OO )  |  |OO ) |      /) ( _) | |  ||  |'.'|  ||  |'.'|  |(|  '--.  |  . '|  |)
|  |.'.|  |(|  |_/  (|  '__ | (|  '__ | |  .   '   \|  |)|  ||  |   |  ||  |   |  | |  .--'  |  |\    | 
|   ,'.   | |  |'->  |     |'  |     |' |  |\   \   '  '-'  '|  |   |  ||  |   |  | |  `---. |  | \   | 
`--'   '--' `--'     `-----'   `-----'  `--' '--'    `-----' `--'   `--'`--'   `--' `------' `--'  `--' ";
            string ascii2 =
            @"<-.(`-')   (`-')  _   _      
 __( OO)   ( OO).-/  (_)     
'-'---.\  (,------.  ,-(`-') 
| .-. (/   |  .---'  | ( OO) 
| '-' `.) (|  '--.   |  |  ) 
| /`'.  |  |  .--'  (|  |_/  
| '--'  /  |  `---.  |  |'-> 
`------'   `------'  `--'  ";
            string ascii3 =
            @"<-. (`-')   (`-')  _   (`-').-> (`-')       (`-')  _    (`-')  <-. (`-')    _      <-. (`-')_  _(`-')    
   \(OO )_  (OO ).-/   ( OO)_   ( OO).->    ( OO).-/ <-.(OO )     \(OO )_  (_)        \( OO) )( (OO ).-> 
,--./  ,-.) / ,---.   (_)--\_)  /    '._   (,------. ,------,) ,--./  ,-.) ,-(`-') ,--./ ,--/  \    .'_  
|   `.'   | | \ /`.\  /    _ /  |'--...__)  |  .---' |   /`. ' |   `.'   | | ( OO) |   \ |  |  '`'-..__) 
|  |'.'|  | '-'|_.' | \_..`--.  `--.  .--' (|  '--.  |  |_.' | |  |'.'|  | |  |  ) |  . '|  |) |  |  ' | 
|  |   |  |(|  .-.  | .-._)   \    |  |     |  .--'  |  .   .' |  |   |  |(|  |_/  |  |\    |  |  |  / : 
|  |   |  | |  | |  | \       /    |  |     |  `---. |  |\  \  |  |   |  | |  |'-> |  | \   |  |  '-'  / 
`--'   `--' `--' `--'  `-----'     `--'     `------' `--' '--' `--'   `--' `--'    `--'  `--'  `------'  

";
            Console.WriteLine($"{ascii1}\n{ascii2}\n{ascii3}");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
        }
    }
}
