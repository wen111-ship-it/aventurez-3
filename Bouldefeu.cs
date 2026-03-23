public class Bouldefeu: Sort
{
    public Bouldefeu() : base("Bouldefeu", 20){}
    public override void lancer(Sorcier lanceur, Personnage cible)
    {
        if (!cible.EstMort)
        {
            lanceur.Parler($"{lanceur.Nom} lance une boule de feu!");
            cible.PointsDeVie -= 20;
            lanceur.Parler($"{this.Nom}perd 20 points de vie !");
        }

    }
}