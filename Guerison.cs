public class Guerison: Sort

{
    public Guerison() : base("Guerison", 20){}
    public override void lancer(Sorcier lanceur, Personnage cible)
    {
       if (!cible.EstMort)
        {
            lanceur.Parler($"{lanceur.Nom} lance {this.Nom} sur {cible.Nom} !");
            cible.PointsDeVie += 20;
            lanceur.Parler($"{cible.Nom} gagne 20 points de vie !");
        }
    }
}