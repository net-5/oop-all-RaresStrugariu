using System;

namespace OOP
{
   class Program
   {
      static void Main(string[] args)
      {
         Ants myAnt = new Ants("Soldier");
         myAnt.MaxCrawlSpeed = 66;
         myAnt.Crawl(77);

         Bat myBat = new Bat("BatMan");
         myBat.MaxFlySpeed = 160;
         myBat.Fly(100);

         Flying_Lizard myLizard = new Flying_Lizard("Dragon");
         myLizard.MaxCrawlSpeed = 120;
         myLizard.Crawl(100);
         myLizard.MaxFlySpeed = 25;
         myLizard.Fly(55);


         Ostrich myOstrich = new Ostrich("Speedy Gonzales");
         myOstrich.MaxWalkSpeed = 70;
         myOstrich.Walk(55);

         Platypus myPlatypus = new Platypus("Perry");
         myPlatypus.MaxSwimSpeed = 80;
         myPlatypus.MaxWalkSpeed = 35;
         myPlatypus.Swim(40);
         myPlatypus.Walk(45);

         WildDuck myDuck = new WildDuck("Duck Dodgers");
         myDuck.MaxFlySpeed = 50;
         myDuck.MaxSwimSpeed = 30;
         myDuck.MaxWalkSpeed = 15;
         myDuck.Fly(48);
         myDuck.Swim(60);
         myDuck.Walk(8);
      }


   }
}
