namespace Exercises.Classes;

public class DogClass
{
    public class Dog
    {
        string Name, Breed;
        int Weight;

        public Dog(string name, string breed, int weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public Dog(string name, int weight, string breed = "mixed-breed")
        {
            Name = name;
            Weight = weight;
            Breed = breed;
        }

        public string Describe()
        {
            string dogSize = "";
            if (Weight < 5)
            {
                dogSize = "tiny";
            }
            else if (Weight < 30)
            {
                dogSize = "medium";
            }
            else
            {
                dogSize = "large";
            }

            return
                $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {dogSize} dog.";
        }
    }
}

// Dog class
//     Define a Dog
//
// class. Each Dog will have a name(string),
// breed(string), and weight(int)
// fields.This
//
// class will have two constructors:
//
// The first takes name, breed, and weight parameters(in this order).The second takes only the name
//     and weight parameters(in this order).In this case, the breed should be assigned the "mixed-breed" value.
// This class will expose a single
// public method called Describe, returning a string describing the dog.
// For a dog named Lucky, with the breed "german shepherd" and weight of 40, this method should return
// "This dog is named Lucky, it's a german shepherd, and it weighs 40 kilograms, so it's a large dog."
// For a dog named Tina, with the breed "shar pei" and weight of 25, this method should return
// "This dog is named Tina, it's a shar pei, and it weighs 25 kilograms, so it's a medium dog."
// The rule for translating the dog's weight to the weight description is as follows:
// For dogs lighter than 5 kilos, it is "tiny".
// For dogs weighing 5 kilos or more but less than 30 kilos, it is "medium".
// For other dogs, it is "large".