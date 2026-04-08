public  class Sorcier : Aventurier
{
    public int mana { get; set; }
   
     public override void CriDeGuerre()
    {
        Parler($"{this.Nom} pousse un cri de guerre terrifiant !");
    }
    public Sorcier(string nom, int force, int pointsDeVie) : base(nom, force, pointsDeVie, ConsoleColor.Magenta)
    {
       this.mana=100; 
    }
    public  override void Attaquer(Personnage cible)
    {
        
        if (this.mana >= 20)
        {
            Parler($"{this.Nom} lance une boule de feu sur {cible.Nom} !");
            cible.PointsDeVie -= 20; // Sort plus puissant que l'attaque normale
            this.mana -= 20; // Consomme du mana
           
        }
        else
        {
            Parler($"{this.Nom} n'a pas assez de mana pour lancer un sort !");
            base.Attaquer(cible); // Attaque normale si pas assez de mana
        }
    }
    public bool Lancer(Sort sortilege,Personnage cible)
    {
        if (this.mana >= sortilege.ManaCost)
        {
            sortilege.lancer(this, cible);
            mana-=sortilege.ManaCost;
            return true;
        }
        return false;
    }
    
}