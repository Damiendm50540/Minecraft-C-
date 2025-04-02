public class Arme
{
    public string Nom { get; set; }
    public int Degats { get; set; }

    public Arme(string nom, int degats)
    {
        Nom = nom;
        Degats = degats;
    }

    public void Utiliser(Monstre cible)
    {
        cible.PV -= Degats;
        Console.WriteLine($"{Nom} inflige {Degats} dégâts à {cible.Nom}.");
    }
}