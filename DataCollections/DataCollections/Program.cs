using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<string>();

            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Audi";
            //var car4 = "Moskvich";
            //var car5 = "Opel";
            //var car6 = "Ferrari";
            //var car7 = "Saab";
            //var car8 = "Mercedes";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);
            //cars.Add(car7);
            //cars.Add(car8);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var cars = new List<string> {"BMW", "Lada", "Audi", "Moskvich", "Opel", "Ferrari", "Saab", "Mercedes"};



            //var elementidearv = cars.Count;

            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}


            //Console.WriteLine();


            //List<Human> humans1;

            //humans1 = new List<Human>()
            //{
            //    new Human(){Name = "Kalle", Age = 20 },
            //    new Human(){Name = "Malle", Age = 25 },
            //    new Human(){Name = "Mari", Age = 30 },
            //    new Human(){Name = "Elmar", Age = 20 },
            //    new Human(){Name = "Juku", Age = 20 },
            //};

            //var human2 = new Human();
            //Console.WriteLine("Sisestage nimi");
            //human2.Name = Console.ReadLine();
            //Console.WriteLine("Sisestage vanus");
            //human2.Age = int.Parse(Console.ReadLine());
            //humans1.Add(human2);

            //List<Human> humans;

            //while (true)
            //{


            //    humans = new List<Human>();

            //    var human2 = new Human();
            //    Console.WriteLine("Sisestage nimi");
            //    human2.Name = Console.ReadLine();
            //    Console.WriteLine("Sisestage vanus");
            //    human2.Age = int.Parse(Console.ReadLine());
            //    humans.Add(human2);
            //    var sisend = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(sisend))
            //    {
            //        break;
            //    }

            //}


            //foreach (var item in humans)
            //{
            //    Console.WriteLine("Nimi: " + item.Name + " Vanus: " + item.Age);
            //}




            //Dictionary

            var openWith = new Dictionary<string, string>
            { //   Key      Value
                { "txt", "notepad.exe" },
                { "bmp", "paint.exe" },
                { "jpg", "paint.exe" },
                { "rtf", "wordpad.exe" },
            };

            openWith["rtf"] = "winword.exe";

            try
            {
                openWith.Add("txt", "word.exe");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("An element with the key \"txt\" already exists!");
            }

            Console.WriteLine("For key = rtf, value = {0} ", openWith["rtf"]);
            Console.WriteLine("For key = bmp, value = {0}", openWith["bmp"]);
            Console.WriteLine("For key = txt, value = {0}", openWith["txt"]);

            try
            {
                Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = 'tif' is not found");
            }

            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = 'tif', value = {0}", value);
            }
            else
            {
                Console.WriteLine("Key = 'tif' is not found");
            }

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hyperterm.exe");
                Console.WriteLine("Value added for key 'ht': {0}", openWith["ht"]);
            }

            Console.ReadLine();
        }
    }
}
