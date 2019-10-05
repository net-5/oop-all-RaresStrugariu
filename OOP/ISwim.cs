using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   interface ISwim
   {
      void Swim(int speed);
      int MaxSwimSpeed { get; set; }

   }
}
