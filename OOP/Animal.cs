using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public abstract class Animal
   {
      public string Name { get; private set; }

      public Animal(string _name)
      {
         Name = _name;
      }

   }
}
