public class Coffre : IInteractif
{
    public void Interagir(Personnage auteur)
    {
        auteur.Parler
        ( $"{auteur.Nom} ouvre le coffre et trouve une potion de soin !" );
    }
}