public class PNJ :Personnage, IInteractif
{
    public void Interagir(Personnage auteur)
    {
        auteur.Parler
        ( $"{auteur.Nom} rencontre un PNJ et discute avec lui." );
    }
    public override void CriDeGuerre()
    {
        Parler("Je suis un PNJ, je ne me bats pas !");
    }
    public PNJ(string nom) : base(nom, 0, 100, ConsoleColor.Yellow)
    {
    }
}