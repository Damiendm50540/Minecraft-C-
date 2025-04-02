public class Personnage
{
    public int PV { get; set; }
    public int Degats { get; set; }
    public string Nom { get; set; }

    public Personnage(string nom, int pv, int degats)
    {
        Nom = nom;
        PV = pv;
        Degats = degats;
    }

    public virtual void Attaquer(Personnage cible)
    {
        cible.PV -= Degats;
        Console.WriteLine($"{Nom} attaque {cible.Nom} et inflige {Degats} dégâts.");
    }
}