public class Outil
{
    public string Nom { get; set; }
    public int Durabilite { get; set; }

    public Outil(string nom, int durabilite)
    {
        Nom = nom;
        Durabilite = durabilite;
    }

    public void Utiliser()
    {
        if (Durabilite > 0)
        {
            Durabilite--;
            Console.WriteLine($"{Nom} est utilisé. Durabilité restante : {Durabilite}.");
        }
        else
        {
            Console.WriteLine($"{Nom} est cassé et ne peut plus être utilisé.");
        }
    }
}