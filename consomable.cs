public class Consomable : IInteractif
{
    public string Nom { get; set; }
    public string Effet { get; set; }

    public Consomable(string nom, string effet)
    {
        this.Nom = nom;
        this.Effet = effet;
    }

    public void Interagir(Personnage auteur)
    {
        auteur.Parler($"{auteur.Nom} utilise {this.Nom} et {this.Effet} !");
    }
}