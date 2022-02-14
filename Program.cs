using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya222 
{

    class Program 
    {
    
        static public void Main(string[] args) 
        {
        
            Address someAddress = new Address();

            someAddress.Index = 12234;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kiyv";
            someAddress.Street = "Kyoto";
            someAddress.House = 4;
            someAddress.Apartment = 32;

            Console.WriteLine($"Index: {someAddress.Index}; Country: {someAddress.Country}; City: {someAddress.City}; Street: {someAddress.Street}; House: {someAddress.House}; Apartment: {someAddress.Apartment};");
        
            Console.ReadKey();
        }
    }
}
