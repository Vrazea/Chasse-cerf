namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        int arrows = 5;
        int hits = 0;
        int misses = 0;
        bool hasEnoughArrows = arrows > 1;
        Console.WriteLine("Bienvenue à la chasse ! " + "Il y a un cerf en vue " + "\nTu lui tires dessus avec ton arc..." + "\n(touché / raté) ");
        do
        {
            if (hits < 3)
            {
                string? answer = Console.ReadLine();
                if ( answer == "touché")
                {
                    arrows--;
                    Console.WriteLine("Tu l'as touché ! Il te reste == " + arrows + " == flèches");
                    hits++;
                }else if (answer == "raté")
                {
                    arrows--;
                    Console.WriteLine("Tu l'as manqué ! Il te reste == " + arrows + " == flèches");
                    misses++;
                }
                else
                {
                    Console.WriteLine("Saisie invalide");
                }
            }
            else
            {
                break;
            }
           
            
        } while (arrows >= 1);
        if(hits == 3)
        {
            Console.WriteLine("\nBien joué !");
            Console.WriteLine("===== Statistiques =====" + "\n Hits : " + hits +"\n Misses: " + misses);
        }
        else
        {
            Console.WriteLine("\nDommage, tu l'auras la prochaine fois...");
            Console.WriteLine("===== Statistiques =====" + "\n Hits : " + hits +"\n Misses: " + misses);
        }
        












        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
    }
}