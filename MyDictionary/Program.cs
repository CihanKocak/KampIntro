using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<string, string> sehirler = new MyDictionaryList<string, string>();
            sehirler.Add("06", "Ankara");

            //Console.WriteLine(sehirler);

            sehirler.Add("07", "Antalya");

            //Console.WriteLine(sehirler);

            foreach (var plakalar in sehirler.Keys)
            {
                Console.WriteLine(plakalar);
            }

            foreach (var sehir in sehirler.Values)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadLine();
        }
    }
}
