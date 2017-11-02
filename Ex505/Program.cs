using System;
using System.Collections;

namespace Ex505
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zwierzaki = new ArrayList();
            zwierzaki.Add(new Ssak("Kot"));
            zwierzaki.Add(new Ptak("Sikorka"));
            zwierzaki.Add(new Ssak("Pies"));
            zwierzaki.Add(new Ptak("Papuga"));
            zwierzaki.Sort();
            foreach (var element in zwierzaki)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();

        }
    }
}
