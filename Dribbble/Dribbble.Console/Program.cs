using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dribbble.Lib;

namespace Dribbble.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var scrapper = new Scrapper();
            scrapper.GetProfiles().GetAwaiter().GetResult();
        }
    }
}
