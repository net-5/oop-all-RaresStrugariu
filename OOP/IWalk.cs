using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   interface IWalk
   {
      void Walk(int speed);
      int MaxWalkSpeed { get; set; }
   }
}
