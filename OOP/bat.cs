using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public class Bat : Animal, IFly
   {
      public int MaxFlySpeed { get; set; }
      public Bat(string _name) : base(_name)
      {
      }

      

      public void Fly(int speed)
      {
         if (speed < MaxFlySpeed)
         {
            Console.WriteLine($"I am {Name} the bat and I fly with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the bat and my maximum speed is {MaxFlySpeed} km/h.");
         }
      }
   }
}
