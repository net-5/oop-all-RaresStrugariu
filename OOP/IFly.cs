using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   interface IFly
   {
      void Fly(int speed);
      int MaxFlySpeed { get; set; }
   }
}
