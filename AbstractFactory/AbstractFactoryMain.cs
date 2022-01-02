using Assignment2.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public IAnimal Run()
        {
            var factoryFactory = new FactoryFactory();
            var dogFactory = factoryFactory.GetFactory("Dog");
            var dog = dogFactory.CreateAnimals();
            return dog;

            var catFactory = factoryFactory.GetFactory("Cat");
            var cat = catFactory.CreateAnimals();
            return cat;


        }
    }
}
