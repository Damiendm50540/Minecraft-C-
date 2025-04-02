using System.Collections.Generic;

public class Joueur : Personnage
{
    public List<Arme> Armes { get; set; }
    public List<Armure> Armures { get; set; }
    public List<Outil> Outils { get; set; }

    public Joueur(string nom, int pv, int degats) : base(nom, pv, degats)
    {
        Armes = new List<Arme>();
        Armures = new List<Armure>();
        Outils = new List<Outil>();
    }
}