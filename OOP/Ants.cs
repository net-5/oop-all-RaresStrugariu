using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   class Ants : Insect, ICrawl
   {
      public int MaxCrawlSpeed { get; set; }

      public Ants(string _name) : base(_name)
      {
      }

      
      

      public void Crawl(int speed)
      {
         if (speed < MaxCrawlSpeed)
         {
            Console.WriteLine($"I am {Name} the insect and I crawl with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the insect and my maximum crawl speed is {MaxCrawlSpeed} km/h.");
         }
      }
   }
}
