using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    class Person
    {
        public Person(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            AttackPower = attack;
              
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }


        public int attack(Person b)
        {
            b.Health = b.Health - AttackPower;
            
            return b.Health;
            
        }
        public void heal() {
            Health = Health + 20;
        }
        public string status()
        {
            string stats ="";
            if (Health <= 0)
            {
                stats = "Dead";
            }
            else {
                stats = "still alive";
                 }
            return stats;
        }
        public String selection()
        {
            Console.WriteLine("Select attack for " + Name+" (A for attack, H for heal)");
            string? selection = Console.ReadLine();
            if (selection == "a" || selection == "h")
            {
                return selection;

            }
            else {
                return null;
                
            };
        }    
    }    
}
