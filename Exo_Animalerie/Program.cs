using Exo_Animalerie.Models;

Console.WriteLine("Exercice de l'animalerie");
Console.WriteLine("************************");

Animalerie a = new Animalerie();
a.Nom = "Le Shop de Techni";

a.AjouterAnimal(new Chat
{
    Nom = "Le Chat",
    Caractere = "Joueur",
    Age = 1,
    DateArrive = new DateTime(2023, 1, 6),
    Poil = Chat.PoilEnum.Court,
    Poids = 1.2,
    Sexe = Animal.SexeEnum.F,
    Taille = 30
});

a.AjouterAnimal(new Chat
{
    Nom = "Robert",
    Caractere = "Dormeur",
    Age = 10,
    DateArrive = new DateTime(2021, 2, 9),
    Poil = Chat.PoilEnum.Long,
    Poids = 5.7,
    Sexe = Animal.SexeEnum.M,
    Taille = 50
});

a.AjouterAnimal(new Chien
{
    Nom = "Le Chien",
    Age = 8,
    DateArrive = new DateTime(2019, 9, 1),
    Race = "Carlin",
    Poids = 8.1,
    CouleurCollier = "Rose bonbon",
    Sexe = Animal.SexeEnum.M,
    Taille = 36
});

a.AjouterAnimal(new Oiseau
{
    Nom = "Titi",
    Age = 7,
    DateArrive = new DateTime(2022, 3, 5),
    Couleur = "Jaune",
    Habitat = Oiseau.HabitatEnum.Cage,
    Poids = 0.2,
    Sexe = Animal.SexeEnum.F,
    Taille = 11
});

Console.WriteLine(a.GetListing());
Console.WriteLine();
Console.WriteLine("Debut de la simulation...");
Console.ReadLine();

int tour = 0;
do
{
    tour++;

    Console.Clear();
    Console.WriteLine($"Tour : {tour}");
    Console.WriteLine("******************");

    string resume = a.FairePasserUneJournee();
    Console.WriteLine(resume);
    Console.ReadLine();


} while (a.Animaux.Any());

