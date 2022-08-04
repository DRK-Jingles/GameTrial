using ConsoleSandbox;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace HelloWorldApplication
{
    
    class HelloWorld
    {
        
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = Encoding.Unicode;
            char singleCharacter = '\u0101';
            string diacritics = "diacritics will go here:     "+ '\u0101' + '\u0113'+'\u012B'+'\u014D'+'\u016B';
            
            Console.WriteLine("Hello World");
            //string word = ""+Console.ReadLine();
            //Console.WriteLine(word);
            
            MacronTable Mt = new MacronTable();
            
            Mt.Letter1 = (""+'\u0101');
            Mt.Letter2 = (""+'\u0113');
            Mt.Letter3 = (""+'\u012B');
            Mt.Letter4 = (""+'\u014D');
            Mt.Letter5 = (""+'\u016B');
            Mt.Letter6 = ("" + '\u0101');

            Console.WriteLine(Mt.Letter1.ToString());
            Console.WriteLine(Mt.Letter2.ToString());
            Console.WriteLine(Mt.Letter3.ToString());
            Console.WriteLine(Mt.Letter4.ToString());
            Console.WriteLine(Mt.Letter5.ToString());

            Console.WriteLine(diacritics);
            Console.WriteLine(singleCharacter);
            */

            //Writing for extras
            var allies = new List<Person>();
            allies.Add(new Person("John", 100, 25));
            allies.Add(new Person("Tony", 100, 15));
            allies.Add(new Person("Jenny", 100, 10));

            //Person ally = new Person("Johnny Bravo", 100, 20);
            Person enemy = new Person("Dr. Doom", 100, 30);

            Console.WriteLine("Ally1 status is: " + allies[0].status() + " with {0} health", allies[0].Health);
            Console.WriteLine("Ally2 status is: " + allies[1].status() + " with {0} health", allies[1].Health);
            Console.WriteLine("Enemy status is: " + enemy.status() + " with {0} health", enemy.Health);
            
            
            void choice(int ally) {
                if (allies[ally].selection() == "h")
                {
                    allies[ally].heal();
                    Console.WriteLine(allies[ally].Name + " healed" + " to {0} health", allies[ally].Health);
                }
                else
                {
                    allies[ally].attack(enemy);
                    Console.WriteLine(allies[ally].Name + " attacked " +enemy.Name + " with {0} attack power", allies[ally].AttackPower);
                };
            }
            Random rnd = new Random();
            int number = rnd.Next(0, 2);
            enemy.attack(allies[number]);
            Console.WriteLine(enemy.Name + " attacked " + allies[number].Name + " with {0} attack power", enemy.AttackPower);
            choice(0);            
            choice(1);
            choice(0);
            choice(1);
            enemy.heal();
            Console.WriteLine(enemy.Name + " heals. They now have {0} health", enemy.Health);
            choice(0);            
            choice(1);
            choice(0);
            choice(1);
            Console.WriteLine(enemy.Name + " is " + enemy.status() + " with {0} health", enemy.Health);
        }
    }
}