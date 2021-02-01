using System;
using System.Collections.Generic;

namespace KendiCalismalarım
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string> sozcukler = new MyDictionary<string>();
            sozcukler.Add("kelime");
            Console.WriteLine(sozcukler.Lenght);
            sozcukler.Add("hece");
            Console.WriteLine(sozcukler.Lenght);
            foreach (var sozcuk in sozcukler.Items)
            {
                Console.WriteLine(sozcuk);
            }

            
        }
    }
}
