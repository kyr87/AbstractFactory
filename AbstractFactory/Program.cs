using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var europe = new ToyotaAssemblyLine(new YarisFactory());
            var yaris = europe.AssembleCar();
            Console.WriteLine(yaris);
            yaris.StartEngine();

            var japan = new ToyotaAssemblyLine(new AvensisFactory());
            var avensis = japan.AssembleCar();
            Console.WriteLine(avensis);
            avensis.StartEngine();

            Console.Read();
        }
    }
}
