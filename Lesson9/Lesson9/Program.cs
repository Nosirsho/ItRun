using System;
using System.Collections.Generic;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Wolf wolf = new Wolf();
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(wolf);

            foreach (Animal animal in animals)
                animal.Voice();
        }
    }
}
