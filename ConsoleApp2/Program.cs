using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magical_Pet_Store
{
    public class Maytham_Magical_Pet
    {
        public string Name { get; set; }
        public string MagicalPower { get; set; }
        public int Hunger { get; private set; } = 100;
        public int Energy { get; private set; } = 100;

        public Maytham_Magical_Pet(string name, string magicalPower)
        {
            Name = name;
            MagicalPower = magicalPower;
        }

        public void Feed()
        {
            Hunger += 100;
            Console.WriteLine($"{Name} has been fed!");
        }

        public void Exercise()
        {
            if (Energy > 100)
            {
                Energy -= 100;
                Console.WriteLine($"{Name} has been exercised!");
            }
            else
            {
                Console.WriteLine($"{Name} is too tired to exercise!");
            }
        }

        public void ActivatePower()
        {
            if (Energy > 2)
            {
                Energy -= 2;
                Console.WriteLine($"{Name} used its magical power: {MagicalPower}!");
            }
            else
            {
                Console.WriteLine($"{Name} is too tired to use its magical power!");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Magical Power: {MagicalPower}, Hunger: {Hunger}, Energy: {Energy}");
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void InteractWithPet(Maytham_Magical_Pet pet, string action)
        {
            Console.WriteLine($"{Name} is interacting with {pet.Name}.");

            switch (action.ToLower())
            {
                case "feed":
                    pet.Feed();
                    break;
                case "exercise":
                    pet.Exercise();
                    break;
                case "activate_power":
                    pet.ActivatePower();
                    break;
                default:
                    Console.WriteLine("Invalid action!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Maytham_Magical_Pet dragon = new Maytham_Magical_Pet("X-power", "B-power");
            Student Maytham = new Student("Maytham");

            Maytham.InteractWithPet(dragon, "feed");
            dragon.DisplayInfo();

            Console.ReadKey();  
        }
    }
}
