using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   interface ICrawl
   {
      void Crawl(int speed);
      int MaxCrawlSpeed { get; set; }
   }
}
