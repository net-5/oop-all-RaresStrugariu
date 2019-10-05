using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public class Ostrich : Bird, IWalk
   {
      public int MaxWalkSpeed { get; set; }
      public Ostrich(string _name) : base(_name)
      {
      }

      

      public void Walk(int speed)
      {
         if (speed < MaxWalkSpeed)
         {
            Console.WriteLine($"I am {Name} the bird and I don't fly, but I walk with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the bird and I don't fly, but my maximum walk speed is {MaxWalkSpeed} km/h.");
         }
      }
   }
}
