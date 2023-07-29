using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        /*
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End
*/
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inpt;
            List<Hero> list = new List<Hero>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string name = input[0];
                double hp = double.Parse(input[1]);
                double mp = double.Parse(input[2]);
                list.Add(new Hero(name, hp, mp));
            }

            while ((inpt = Console.ReadLine()) != "End")
            {
                List<string> input = inpt.Split(" - ").ToList();
                string arg = input[0];

                switch (arg)
                {
                    case "CastSpell":
                        string heroToFind = input[1];
                        string spell = input[3];
                        double mpNeeded = double.Parse(input[2]);
                        Hero hero = list.FirstOrDefault(x => x.HeroName == heroToFind);
                        var leftMP = hero.MP - mpNeeded;
                        if (leftMP >= 0) //>
                        {
                            hero.MP = leftMP;
                            Console.WriteLine($"{heroToFind} has successfully cast {spell} and now has {hero.MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroToFind} does not have enough MP to cast {spell}!");
                        }
                        break;
                    case "TakeDamage":
                        heroToFind = input[1];
                        double damage = double.Parse(input[2]);
                        string attacker = input[3];
                        hero = list.FirstOrDefault(x => x.HeroName == heroToFind);
                        hero.HP = hero.HP - damage;
                        if(hero.HP <= 0)
                        {
                            Console.WriteLine($"{heroToFind} has been killed by {attacker}!");
                           list.Remove(hero);
                        }
                        else
                        {
                            Console.WriteLine($"{heroToFind} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                        }
                        break;
                    case "Recharge":
                        heroToFind = input[1];
                        hero = list.FirstOrDefault(x => x.HeroName == heroToFind);
                        double amount = double.Parse(input[2]);
                        double currMP = hero.MP + amount;
                        if (currMP > 200)
                        {
                            double amountRecovered = 200 - hero.MP;
                            hero.MP = 200;
                            Console.WriteLine($"{heroToFind} recharged for {amountRecovered} MP!");
                        }
                        else
                        {
                            hero.MP = hero.MP+ amount;
                            Console.WriteLine($"{heroToFind} recharged for {amount} MP!");
                        }
                        break;
                        case "Heal":
                        heroToFind= input[1];
                        amount = double.Parse(input[2]);
                        hero = list.FirstOrDefault(x => x.HeroName == heroToFind);
                        double currHP= hero.HP + amount;
                        if (currHP > 100)
                        {
                            double amountRecovered = 100 - hero.HP;
                            hero.HP = 100;
                            Console.WriteLine($"{heroToFind} healed for {amountRecovered} HP!");
                        }
                        else
                        {
                            hero.HP = hero.HP + amount;
                            Console.WriteLine($"{heroToFind} healed for {amount} HP!");
                        }
                        break;
                }
            }
            foreach ( var hero in list )
            {
                Console.WriteLine(hero.HeroName);
                Console.WriteLine($"HP: {hero.HP}");
                Console.WriteLine($"MP: {hero.MP}");
            }
        }
        class Hero
        {
            public Hero(string heroName, double hP, double mP)
            {
                HeroName = heroName;
                HP = hP;
                MP = mP;
            }

            public string HeroName { get; set; }
            public double HP { get; set; }
            public double MP { get; set; }
        }
    }
}
