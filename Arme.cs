public class Arme
{
    public string Nom{get;set;}

    public int Puissance{get;set;}
    public string rarete{get;set;}
    
    public Arme(string nom, int puissance, string rarete)
    {
        this.Nom=nom;
        this.Puissance=puissance;
        this.rarete=rarete;
    }
    public Arme(string nom, int puissance):this(nom,puissance,"Commun")
    {
        this.rarete="Commun";
    }
    public void AfficherStats()
    {
        Console.WriteLine($"Nom:{this.Nom}");
        Console.WriteLine($"Puissance:{this.Puissance}");
        Console.WriteLine($"Rareté:{this.rarete}");
    }
 
}
