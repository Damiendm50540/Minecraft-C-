using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrez le nom du joueur 1 : ");
        string nomJoueur1 = Console.ReadLine();
        Console.Write("Entrez le nom du joueur 2 : ");
        string nomJoueur2 = Console.ReadLine();

        Joueur joueur1 = new Joueur(nomJoueur1, 1000, 15); 
        Joueur joueur2 = new Joueur(nomJoueur2, 1000, 15);   

        Arme epee = new Arme("Épée", 15);
        Armure bouclier = new Armure("Bouclier", 20);

        while (joueur1.PV > 0 && joueur2.PV > 0)
        {
            Console.WriteLine($"\n--- Tour de {joueur1.Nom} ---");
            Console.WriteLine("1. Attaquer");
            Console.WriteLine("2. Prendre une épée");
            Console.WriteLine("3. Prendre une armure");
            Console.Write("Choisissez une action : ");
            string choixJoueur1 = Console.ReadLine();

            switch (choixJoueur1)
            {
                case "1":
                    joueur1.Attaquer(joueur2);
                    break;
                case "2":
                    joueur1.Degats += epee.Degats;
                    Console.WriteLine($"{joueur1.Nom} prend une {epee.Nom} et augmente ses dégâts de {epee.Degats}.");
                    break;
                case "3":
                    if (!joueur1.ArmurePrise)
                    {
                        bouclier.Utiliser(joueur1);
                        joueur1.ArmurePrise = true;
                        Console.WriteLine($"{joueur1.Nom} prend une {bouclier.Nom} et augmente ses PV de {bouclier.Defense}.");
                    }
                    else
                    {
                        Console.WriteLine($"{joueur1.Nom} a déjà pris une armure !");
                    }
                    break;
                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }

            if (joueur2.PV <= 0)
            {
                Console.WriteLine($"{joueur2.Nom} est vaincu ! {joueur1.Nom} a gagné !");
                break;
            }

            Console.WriteLine($"\n--- Tour de {joueur2.Nom} ---");
            Console.WriteLine("1. Attaquer");
            Console.WriteLine("2. Prendre une épée");
            Console.WriteLine("3. Prendre une armure");
            Console.Write("Choisissez une action : ");
            string choixJoueur2 = Console.ReadLine();

            switch (choixJoueur2)
            {
                case "1":
                    joueur2.Attaquer(joueur1);
                    break;
                case "2":
                    joueur2.Degats += epee.Degats;
                    Console.WriteLine($"{joueur2.Nom} prend une {epee.Nom} et augmente ses dégâts de {epee.Degats}.");
                    break;
                case "3":
                    if (!joueur2.ArmurePrise)
                    {
                        bouclier.Utiliser(joueur2);
                        joueur2.ArmurePrise = true;
                        Console.WriteLine($"{joueur2.Nom} prend une {bouclier.Nom} et augmente ses PV de {bouclier.Defense}.");
                    }
                    else
                    {
                        Console.WriteLine($"{joueur2.Nom} a déjà pris une armure !");
                    }
                    break;
                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }

            if (joueur1.PV <= 0)
            {
                Console.WriteLine($"{joueur1.Nom} est vaincu ! {joueur2.Nom} a gagné !");
                break;
            }

            Console.WriteLine($"\n{joueur1.Nom} a {joueur1.PV} PV restants.");
            Console.WriteLine($"{joueur2.Nom} a {joueur2.PV} PV restants.");
        }
    }
}