
using System.Linq.Expressions;

Gobelin monstre = new Gobelin("gobelin", 3, 20);

Aventurier conan = new Aventurier ("conan", 5, 50);
Arme epee =new Arme("Excalibur", 20, "Légendaire");


conan.Attaquer(monstre);
conan.ArmeEquipee = epee;
conan.Attaquer(monstre);

monstre.Attaquer(conan);
Console.WriteLine($"{conan.Nom} a {conan.PointsDeVie} PV.");

epee.AfficherStats();
conan.ArmeEquipee=epee;
Console.WriteLine(
    $"{conan.Nom} est equipé de :{conan.ArmeEquipee.Nom}");



Sorcier Gandalf = new Sorcier("Gandalf", 10, 100);
Gobelin gobelin = new Gobelin("gobelin", 3, 20);
Aventurier Conan = new Aventurier("conan" , 5, 50);
Dragons Smaug = new Dragons("Smaug");

List<Personnage>mesCombattants = new List<Personnage>();
mesCombattants.Add(Gandalf);
mesCombattants.Add(gobelin);
mesCombattants.Add(Conan);


while (Smaug.PointsDeVie > 0)
{
    foreach (Personnage p in mesCombattants)
    {
    p.Attaquer(Smaug);
    }
    foreach (Personnage p in mesCombattants)
    {
    p.Attaquer(Smaug);
    }
    if (mesCombattants.Any(p => p.PointsDeVie <= 0))
    {
        Console.WriteLine($"{mesCombattants.First(p => p.PointsDeVie <= 0).Nom} est mort ! Smaug a gagné !");
        break;
    }
    if (Smaug.PointsDeVie <= 0)
    {
        Console.WriteLine($"{Smaug.Nom} est mort ! vous avez gagné !");
        break;
    }
}
Coffre c=new Coffre();
    PNJ bob=new PNJ("bob");
    List<IInteractif>decors=new List<IInteractif>();
    decors.Add(c);
    decors.Add(bob);

    foreach (IInteractif d in decors)
    {
        d.Interagir(Gandalf);
    }



