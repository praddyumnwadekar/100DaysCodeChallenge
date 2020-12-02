using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{

    class Program
    {
        public void SQLLikeInLinq()
        {
            string[] strings = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var wantedstring = from parstring in strings
                               where parstring.ToLower().StartsWith("a") && parstring.ToLower().EndsWith("m")
                               select parstring;
            foreach (var str in wantedstring)
            {
                Console.WriteLine($"{str}");
            }
        }

        public void FrequencyCheckerUsingLinq()
        {
            int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var numbersFrequency = from number in numbers
                                   group number by number into frequency
                                   select frequency;

            foreach (var item in numbersFrequency)
            {
                Console.WriteLine($"Number = {item.Key},\t Frequency = {item.Count()},\t Number * Frequency = {item.Sum()}");
            }
        }

        public void NumberGreaterThantheNumber()
        {

            List<int> members = new List<int>();

            Console.WriteLine("Enter the number of members: ");
            int memberNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < memberNumbers; i++)
            {
                members.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Enter the number from where you want to display: ");
            int numberParameter = Convert.ToInt32(Console.ReadLine());

            var displayAboveParticularMember = from member in members
                                               where member > numberParameter
                                               select member;
            Console.WriteLine($"Numbers Greater Than {numberParameter}: ");
            foreach (var item in displayAboveParticularMember)
            {
                Console.WriteLine(item);
            }

        }

        public void NthTopRecords()
        {
            List<int> members = new List<int>();

            Console.WriteLine("Enter the number of members: ");
            int memberNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < memberNumbers; i++)
            {
                members.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("How many Top Elements do you want: ");
            int numbersWanted = Convert.ToInt32(Console.ReadLine());


            var topNumbers = (from number in members
                              orderby number descending

                              select number).Take(numbersWanted);

            Console.WriteLine($"The top {numbersWanted} records from the list are :");
            foreach (var item in topNumbers)
            {
                Console.WriteLine(item);
            }
        }

        public void FindTheUpperCaseInString()
        {
            string sentence = "This IS a STRING";

            var upperCaseWords = from word in sentence.Split()
                                 where word.Equals(word.ToUpper())
                                 select word;

            foreach (var item in upperCaseWords)
            {
                Console.WriteLine(item);
            }

        }

        public void FrequencyOfExtension()
        {
            string[] extensions = {"aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf",
"aaaa.PDF","xyz.frt","abc.xml", "ccc.txt", "zzz.txt"};


            var fGrp = extensions.Select(file => System.IO.Path.GetExtension(file).TrimStart('.').ToLower()).GroupBy(z => z, (x, y) => new
            {
                ext = x,
                Count = y.Count()
            });

            foreach (var m in fGrp)
                Console.WriteLine("{0} Files with {1} Extension ", m.Count, m.ext);


        }

        public void InnerJoin()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };


            var innerJoin = from item in itemlist
                            join purchase in purchlist on item.ItemId equals purchase.ItemId
                            select new
                            {
                                itId = item.ItemId,
                                itemName = item.ItemDes,
                                purQuality = purchase.PurQty
                            };

            foreach (var item in innerJoin)
            {
                Console.WriteLine($"Item Id: {item.itId}, Item Name: {item.itemName}, Pur Quality: {item.purQuality}");
            }
        }


        public void OrderDistinctElementAsending()
        {

            string[] lists = { "Biscuit", "Apple", "Butter", "Brade", "Honey", "Jamun", "Honey" };


            var listDistnctAsending = (from list in lists.Distinct()
                                       orderby list
                                       select list).ToList();

            listDistnctAsending.ForEach(n => Console.Write(n + " "));

            /*if the list have more elements in it 
            var listDistnctAsending = (from list in lists.Distinct()
                                       select list).Distinct()
                                       .OrderBy(x => x);

            listDistnctAsending.ForEach(n => Console.Write(n + " "));
            */
        }

        public void ArrangeCities()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

            var groupcities = (from city in cities
                               orderby city.Length, city ascending
                               select city).ToArray();

            Console.WriteLine(string.Join(", ", groupcities));


            //  Alternative way
            
           // string[] cities =
           //{
           //     "ROME","LONDON","NAIROBI","CALIFORNIA",
           //     "ZURICH","NEW DELHI","AMSTERDAM",
           //     "ABU DHABI", "PARIS","NEW YORK"
           // };

           // var city1 = cities.Select(city => city).OrderBy(city => city.Length).ThenBy(city => city).ToList();

           // city1.ForEach(city => Console.WriteLine(city));

        }
        static void Main(string[] args)
        {


        }
        internal class Purchase
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }
        }

        internal class Item_mast
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }
        }
    }
}



