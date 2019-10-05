using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   class Flying_Lizard : Reptile,ICrawl,IFly
   {
      public int MaxCrawlSpeed { get; set; }
      public int MaxFlySpeed { get; set; }
      public Flying_Lizard(string _name) : base(_name)
      {
      }

      

      public void Crawl(int speed)
      {
         if (speed < MaxCrawlSpeed)
         {
            Console.WriteLine($"I am {Name} the reptile and I crawl with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the reptile and my maximum crawl speed is {MaxCrawlSpeed} km/h.");
         }
      }

      public void Fly(int speed)
      {
         if (speed < MaxFlySpeed)
         {
            Console.WriteLine($"I am {Name} the reptile,And I can Fly(almost) and I fly with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the reptile and my maximum fly speed is {MaxFlySpeed} km/h.");
         }
      }
   }
}
