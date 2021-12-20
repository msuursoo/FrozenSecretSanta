using System;

namespace OOP
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double levelOfHappiness;

            //constructor

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                levelOfHappiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");

            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Spots: {spots}");
                Console.WriteLine($"Level of happiness: {levelOfHappiness}");

            }

            public void Rename(string newName)
            {
                Console.WriteLine($"The dog {name} has been renamed to {newName}");
                name = newName;
            }

            //getter for name
            public string Name
            {
                get { return name; }
            }

            public double LevelOfHappiness
            {
                get { return levelOfHappiness; }
            }

            public void Bark()
            {
                levelOfHappiness += 0.2; //levelOfHappiness +0.2;
                Console.WriteLine($"{name} says: Woof - woof");
            }

            public void Wag()
            {
              Console.WriteLine("Wiggle-wiggle");
            }

            static void Main(string[] args)
            {
                Dog myDog = new Dog("koer", 25);

                Console.WriteLine($"{myDog.Name} is a good boy!");
                myDog.Rename("Good boy");
                
                while(myDog.LevelOfHappiness < 1)
                {
                    myDog.Bark();
                }

                myDog.Wag();

                myDog.ShowDogData();
            }
        }
    }
}
