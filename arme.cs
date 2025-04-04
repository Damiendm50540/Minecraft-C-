public class Arme
{
    public string Nom { get; set; }
    public int Degats { get; set; }

    public Arme(string nom, int degats)
    {
        Nom = nom;
        Degats = degats;
    }

    public void Utiliser(Personnage cible, int degatsTotaux) 
    {
        Console.WriteLine($"{Nom} inflige {degatsTotaux} de dégâts à {cible.Nom}.");
        cible.PV -= degatsTotaux;
    }
}