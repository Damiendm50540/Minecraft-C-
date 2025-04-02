using System;

class Program
{
    static void Main(string[] args)
    {
        Joueur joueur1 = new Joueur("Damien", 250, 5); 
        Joueur joueur2 = new Joueur("Enzo", 100, 5);   
        Monstre monstre = new Monstre("Abdel", 50, 5);

        joueur1.Attaquer(monstre);
        if (monstre.PV <= 0)
        {
            Console.WriteLine($"{joueur1.Nom} a gagné !");
            return;
        }

        monstre.Attaquer(joueur1);
        if (joueur1.PV <= 0)
        {
            Console.WriteLine($"{monstre.Nom} a gagné !");
            return;
        }

        Console.WriteLine($"{joueur1.Nom} a {joueur1.PV} PV restants.");
        Console.WriteLine($"{monstre.Nom} a {monstre.PV} PV restants.");

        Outil outil = new Outil("Hache", 10);
        outil.Utiliser();

        Arme arme = new Arme("Épée", 15); 
        arme.Utiliser(monstre, joueur1.Degats + arme.Degats); 
        if (monstre.PV <= 0)
        {
            Console.WriteLine($"{monstre.Nom} est vaincu ! {joueur1.Nom} a gagné !");
            return;
        }

        Armure armure = new Armure("Bouclier", 20);
        armure.Utiliser(joueur1);

        Console.WriteLine($"{joueur1.Nom} a {joueur1.PV} PV restants après l'utilisation de l'armure.");

        Arme arme = new Arme("Épée", 15); 
        arme.Utiliser(joueur2, joueur1.Degats + arme.Degats); 
        if (joueur2.PV <= 0)
        {
            Console.WriteLine($"{joueur2.Nom} est vaincu ! {joueur2.Nom} a gagné !");
            return;
        }
        
        Console.WriteLine($"{joueur2.Nom} a {joueur2.PV} PV restants après l'utilisation de l'arme.");

    
        
    }
}