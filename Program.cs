using System;

class Program
{
    static void Main(string[] args)
    {
        Joueur joueur = new Joueur("Steve", 100, 10);
        Monstre monstre = new Monstre("Zombie", 50, 5);

        Arme epee = new Arme("Épée", 15);
        Armure bouclier = new Armure("Bouclier", 20);
        Outil pioche = new Outil("Pioche", 10);

        joueur.Armes.Add(epee);
        joueur.Armures.Add(bouclier);
        joueur.Outils.Add(pioche);

        joueur.Attaquer(monstre);
        epee.Utiliser(monstre);
        bouclier.Utiliser(joueur);
        pioche.Utiliser();

        Console.WriteLine($"PV du monstre : {monstre.PV}");
        Console.WriteLine($"PV du joueur : {joueur.PV}");
    }
}