using System;
using System.ComponentModel.Design;
namespace app
{
    public class Animal
    {
        public string nom;
        public Animal()
        {
            nom = "";
        }
        public int age;
        public void respirer()
        {
            Console.WriteLine("Je respire et je suis le.a " + nom);
        }
    }
    public class chien : Animal /*Voici le constructeur standart,
                                 mais dans ce cas il ne sera plus utilisée
                                parce que ci-dessous on a un nouveau construcuteur
                                que pour construire un objet il faut que nous lui
                                passions le nom du objet (nom du chien) comme valeur
                                de paramètre*/
    {
        public chien(string nomduanimal)
        {
            nom = nomduanimal;
        }
        public void aboyer()
        {
            Console.WriteLine("houf");
        }
        public void veillir()
        {
            age++;
            Console.WriteLine(age.ToString());
        }


    }
    public class chat : Animal
    {
        public chat(string nomduanimal)
        {
            nom = nomduanimal;
        }
        public void miauler()
        {
            Console.WriteLine("Meow");
        }
        public void veillir()
        {
            age++;
            Console.WriteLine(age.ToString());
        }

        static void Main(string[] args)
        {
            chien Bulldog = new chien("Dudinha");
            chat Chat = new chat("Garfield");

            List<Animal> animaux = new List<Animal>(); /*Nous devons faire attention au type de liste*/
            animaux.Add(Bulldog);
            animaux.Add(Chat);
            /*Console.WriteLine(animaux[0].nom);/*Nous devons indiquer quel information nous souhaitons afficher, dans ce cas le nom*//*
            Console.WriteLine(animaux[1].nom);*/

            foreach (Animal animal in animaux)
            {
                animal.respirer();/* Dans ce cas nous avons transformé tous nos objets
            en un seul objet (une liste dans ce cas), mais cette transformations n'empeche pas
            nos objets d'utilser les méthodes qu'ils ont hérité
            */
            }

            Bulldog.respirer();/*voici un exemple d'un objet qui est pas concerné
                                 dans la list en profitant de son héritege*/
        }
            

    }
}