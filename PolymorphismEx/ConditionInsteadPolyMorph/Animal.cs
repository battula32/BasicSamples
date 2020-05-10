using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismEx.ConditionInsteadPolyMorph
{
    public abstract class Animal
    {
    }

    public class Dog : Animal
    {
    }

    public class Cat : Animal
    {
    }

    public class Trainer
    {
        public string Speak(Animal animal)
        {
            Type animalType = animal.GetType();

            if(animalType == typeof(Dog))
            {
                return "Bow bow";
            }

            if(animalType == typeof(Cat))
            {
                return "Meav Meav";
            }

            return "I can't speak";
        }
    }
}
