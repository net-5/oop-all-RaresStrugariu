using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public class Platypus : Mammal, ISwim, IWalk
   {
      public int MaxWalkSpeed { get; set; }
      public int MaxSwimSpeed { get; set; }
      public Platypus(string _name) : base(_name)
      {
      }

      

      public void Swim(int speed)
      {
         if (speed < MaxSwimSpeed)
         {
            Console.WriteLine($"I am {Name} the platypus and I swim with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the platypus and my maximum swim speed is {MaxSwimSpeed} km/h.");
         }
      }

      public void Walk(int speed)
      {
         if (speed < MaxWalkSpeed)
         {
            Console.WriteLine($"I am {Name} the platypus and I walk with {speed} km/h");
         }
         else
         {
            Console.WriteLine($"I am {Name} the platypus and may maximum walk speed is {MaxWalkSpeed} km/h");
         }
      }
   }
}
