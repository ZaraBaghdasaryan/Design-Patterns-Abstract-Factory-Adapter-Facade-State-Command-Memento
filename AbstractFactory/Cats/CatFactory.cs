using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    internal class CatFactory : IFactory
    {
        public IAnimal CreateAnimals()
        {
            return new Cat("");
        }

    }
}