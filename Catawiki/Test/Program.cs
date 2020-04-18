using System.Threading.Tasks;
using Catawiki.Lib;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Scrapping scr = new Scrapping();
            var res = await scr.Start(null);
        }
    }
}
