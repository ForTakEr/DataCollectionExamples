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
            #region List<>
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



            #endregion

            #region Dictionary
            //Dictionary

            //var openWith = new Dictionary<string, string>
            //{ //   Key      Value
            //    { "txt", "notepad.exe" },
            //    { "bmp", "paint.exe" },
            //    { "jpg", "paint.exe" },
            //    { "rtf", "wordpad.exe" },
            //};

            //openWith["rtf"] = "winword.exe";

            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException)
            //{

            //    Console.WriteLine("An element with the key \"txt\" already exists!");
            //}

            //Console.WriteLine("For key = rtf, value = {0} ", openWith["rtf"]);
            //Console.WriteLine("For key = bmp, value = {0}", openWith["bmp"]);
            //Console.WriteLine("For key = txt, value = {0}", openWith["txt"]);

            //try
            //{
            //    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = 'tif' is not found");
            //}

            //string value = "";
            //if (openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = 'tif', value = {0}", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key = 'tif' is not found");
            //}

            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key 'ht': {0}", openWith["ht"]);
            //}

            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0} , Value = {1}", kvp.Key, kvp.Value);
            //}


            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;

            //foreach (var item in valueCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key 'doc' is not found");
            //}

            #endregion


            #region Queue
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("One");
            //numbers.Enqueue("Two");
            //numbers.Enqueue("Three");
            //numbers.Enqueue("Four");
            //numbers.Enqueue("Five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //Console.WriteLine("Peek at the next item to dequeue: {0}", numbers.Peek());

            //Console.WriteLine("Dequeing '{0}'\n", numbers.Dequeue());

            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("Contents of the first copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\nContents of the second Copy, with duplicates and nulls");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("\nQueueCopy contains 'Four' = {0}", queueCopy.Contains("Four"));
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is: {0}", queueCopy.Count);




            #endregion

            #region Stack

            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("One");
            //numbers.Push("Two");
            //numbers.Push("Three");
            //numbers.Push("Four");
            //numbers.Push("Five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            //Console.WriteLine("Peek at the next item to destack: {0}", numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());




            #endregion

            #region LINQ
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var numQuery = from num in numbers
            //               where (num % 2) == 0
            //               select num;
            //int evenNumCount = numQuery.Count();


            //foreach (int num in numQuery)
            //{
            //    Console.WriteLine("{0,1} ", num);
            //}

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 21},
            //    new Human(){Name = "Malle", Age = 40},
            //    new Human(){Name = "Mari", Age = 28},
            //    new Human(){Name = "Elmar", Age = 40},
            //    new Human(){Name = "Juku", Age = 10}
            //};

            //var query = (from element in humans1
            //             orderby element.Age ascending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}


            //CONTAINS
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //var a = numbers.Contains(7);

            //var b = false;
            //foreach (var item in numbers)
            //{
            //    if (item == 6)
            //        b = true;
            //}

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var a = numbers.ElementAtOrDefault(15);
            //var b = numbers.FirstOrDefault();
            //var c = numbers.Take(3).ToList();
            //var d = numbers.Average();
            //var e = numbers.Max();
            //var f = numbers.Min();

            //Console.WriteLine("ElementAtOrDefault: " + a);
            //Console.WriteLine("FirstOrDefault: " + b);
            //foreach (var item in c)
            //{
            //    Console.WriteLine("Take: " + item);
            //}
            //Console.WriteLine("Average: " + d);
            //Console.WriteLine("Max: " + e);
            //Console.WriteLine("Min: " + f);


            //var g = humans1.Where(x => x.Name == "Kalle").FirstOrDefault().Name;
            //var h = humans1.Where(x => x.Age == 40).ToList();
            //var i = humans1.Where(x => x.Name.Contains("a")).ToList();
            //var j = humans1.Where(x => x.Name.StartsWith("M")).ToList();

            //Console.WriteLine(g);

            //foreach (var item in h)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //Console.WriteLine("\nContains 'a': ");

            //foreach (var item in i)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //Console.WriteLine("\nStarts with 'M': ");

            //foreach (var item in j)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            #endregion

            #region Cars

            //var Cars1 = new List<Car>
            //{
            //    new Car(){KW = 100, Tootja = "Opel", Mudel = "Omega", Värv = "Sinine"},
            //    new Car(){KW = 55, Tootja = "Moskvich", Mudel = "2140", Värv = "Kollane"},
            //    new Car(){KW = 132, Tootja = "BMW", Mudel = "E39 530", Värv = "Must"},
            //    new Car(){KW = 70, Tootja = "Ford", Mudel = "Focus", Värv = "Kuldne"},
            //    new Car(){KW = 90, Tootja = "Mercedes", Mudel = "C230", Värv = "Valge"},
            //    new Car(){KW = 60, Tootja = "Toyota", Mudel = "Auris", Värv = "Lilla"},
            //    new Car(){KW = 75, Tootja = "Kia", Mudel = "Carens", Värv = "Punane"},
            //    new Car(){KW = 140, Tootja = "Audi", Mudel = "A8", Värv = "Tume sinine"},
            //    new Car(){KW = 45, Tootja = "Lada", Mudel = "Riva", Värv = "Roheline"},
            //    new Car(){KW = 200, Tootja = "Lamborghini", Mudel = "Aventador", Värv = "Roosa"},
            //};

            //Console.WriteLine("KW järjestuses: ");

            //var query = (from element in Cars1
            //             orderby element.KW ascending
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            //var a = Cars1.Where(x => x.Tootja.Contains("o")).ToList();
            //var b = Cars1.Where(x => x.Tootja.Contains("e")).ToList();
            //var c = Cars1.Where(x => x.Mudel.Length > 4).ToList();
            //var d = Cars1.Where(x => x.KW >= 150).ToList();
            //var e = Cars1.Where(x => x.KW <= 50).ToList();

            //Console.WriteLine("\n'o' tootja nimes: ");
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            //Console.WriteLine("\n'e' tootja nimes: ");
            //foreach (var item in b)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            //Console.WriteLine("\nMudel koosneb rohkem kui 4 tähest: ");
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            //Console.WriteLine("\nVõimsaim auto: ");
            //foreach (var item in d)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            //Console.WriteLine("\nNõrgeim auto: ");
            //foreach (var item in e)
            //{
            //    Console.WriteLine(item.Tootja + " | " + item.Mudel + " | " + item.KW + "KW | " + item.Värv);
            //}

            #endregion

            #region Grupeerimine

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 21},
                new Human(){Name = "Malle", Age = 40},
                new Human(){Name = "Mari", Age = 28},
                new Human(){Name = "Elmar", Age = 40},
                new Human(){Name = "Juku", Age = 10}
            };

            int[] numbers = new int[8] { 0, 1, 2, 3, 4, 5, 6, 5};

            var grupid = from human in humans1
                         group human by human.Age into NewGroup
                         select NewGroup;

            //var grupid = (from number in numbers
            //             group number by number == 5);

            foreach (var grupp in grupid)
            {
                Console.WriteLine("Uus grupp: " + grupp.Key);
                foreach (var item in grupp)
                {
                    Console.WriteLine(item.Age + " " + item.Name);
                }
            }

            #endregion



            Console.ReadLine();
        }
    }
}
