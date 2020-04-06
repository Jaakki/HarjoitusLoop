using System;
using System.Collections.Generic;

namespace HarjoitusLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            Person per1 = new Person();
            per1.firstName = "Julle";
            per1.lastName = "Nalle";
            per1.employeed = false;
            per1.money = 2000;

            Person per2 = new Person();
            per2.firstName = "Jalmari";
            per2.lastName = "Kalmari";
            per2.employeed = true;
            per2.money = 1100;

            Person per3 = new Person();
            per3.firstName = "Paavo";
            per3.lastName = "Pesusieni";
            per3.employeed = true;
            per3.money = 50;


            List<Person> persons = new List<Person>();
            persons.Add(per1);
            persons.Add(per2);
            persons.Add(per3);

            foreach (var per in persons)
            {
                Console.WriteLine($"{per.firstName} {per.lastName} {per.money}");
            }

            foreach (var per in persons)
            {
                    if (per.money < 1000)
                    {
                        Console.WriteLine($"{per.firstName} {per.lastName} {per.money}");
                    }
            }

            Hobby ho1 = new Hobby();
            ho1.name = "running";
            ho1.monthlyCost = 100;

            Hobby ho2 = new Hobby();
            ho2.name = "wines";
            ho2.monthlyCost = 250;

            Hobby ho3 = new Hobby();
            ho3.name = "miniatures";
            ho3.monthlyCost = 220;

            Hobby ho4 = new Hobby();
            ho4.name = "singing";
            ho4.monthlyCost = 0;

            per1.hobbies.Add(ho3);
            per1.hobbies.Add(ho4);
            per2.hobbies.Add(ho4);
            per3.hobbies.Add(ho4);

            foreach (var per in persons)
            {
                if (per.money < 1000)
                {
                    per.hobbies.Add(ho1);
                }

                if (per.money > 1000)
                {
                    per.hobbies.Add(ho2);
                }
            }

            Console.WriteLine();

            foreach (var per in persons)
            {
                Console.WriteLine($"Name: {per.firstName} {per.lastName}\nEmployed: {per.employeed}\nMoney: {per.money}");


                foreach (Hobby boi in per.hobbies)
                {
                    Console.WriteLine($"{boi.name} {boi.monthlyCost}");
                }
                Console.WriteLine();
            }

            foreach (var person in persons)
            {
                if (person.employeed == true)
                {
                    foreach (Hobby pers in person.hobbies)
                    {
                        if (pers.monthlyCost >= 100)
                        {
                            Console.WriteLine($"{pers.name} {pers.monthlyCost}!");
                        }
                    }
                }
                Console.WriteLine();
            }
            
            foreach (var person in persons)
            {
                int sum = 0;
                foreach (var hobby in person.hobbies)
                {
                    sum += hobby.monthlyCost;
                }

                Console.WriteLine($"{person.firstName} maksaa {sum}");
            }
        }
    }
}
