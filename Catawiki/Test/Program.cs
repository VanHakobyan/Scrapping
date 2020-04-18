using Catawiki.Lib;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Scrapping scr = new Scrapping();
            await scr.Start();
        }
    }
}
