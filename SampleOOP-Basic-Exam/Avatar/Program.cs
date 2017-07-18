using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nationBuilder = new NationsBuilder();
            var engine = new Engine(nationBuilder);
            engine.Run();
        }
    }
}
