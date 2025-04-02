public class Armure
{
    public string Nom { get; set; }
    public int Defense { get; set; }

    public Armure(string nom, int defense)
    {
        Nom = nom;
        Defense = defense;
    }

    public void Utiliser(Personnage personnage)
    {
        personnage.PV += Defense;
        Console.WriteLine($"{Nom} augmente les PV de {personnage.Nom} de {Defense}.");
    }
}