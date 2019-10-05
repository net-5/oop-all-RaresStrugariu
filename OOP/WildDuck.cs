using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public class WildDuck : Bird, ISwim, IFly, IWalk
   {
      public int MaxSwimSpeed { get; set; }
      public int MaxWalkSpeed { get; set; }
      public int MaxFlySpeed { get; set; }
      public WildDuck(string _name) : base(_name)
      {
      }

      

      public void Fly(int speed)
      {
         if (speed < MaxFlySpeed)
         {
            Console.WriteLine($"I am {Name} the bird and I fly with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the bird and my maximum fly speed is {MaxFlySpeed} km/h.");
         }
      }

      public void Swim(int speed)
      {
         if (speed < MaxSwimSpeed)
         {
            Console.WriteLine($"I am {Name} the bird and I swim with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the bird and my maximum swim speed is {MaxSwimSpeed} km/h.");
         }
      }

      public void Walk(int speed)
      {
         if (speed < MaxWalkSpeed)
         {
            Console.WriteLine($"I am {Name} the bird and I walk with {speed} km/h.");
         }
         else
         {
            Console.WriteLine($"I am {Name} the bird and my maximum walk speed is {MaxWalkSpeed} km/h.");
         }
      }
   }
}
