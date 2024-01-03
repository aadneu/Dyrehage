using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrehage
{
    internal abstract class Dyr
    {
        protected string Type { get; set; }
        protected string Name { get; set; }
        protected bool Hankjønn { get; set; }
        protected int Alder { get; set; }

        public Dyr(string type, string name, bool hankjønn, int alder)
        {
            Type = type;
            Name = name;
            Hankjønn = hankjønn;
            Alder = alder;
        }

       public void ShowAnimal()
        {
            Console.WriteLine($"Type: {Type} \n" +
                              $"Name: {Name} \n" +
                              $"Male? {Hankjønn} \n" +
                              $"Age: {Alder}\n");
        }
    }
}
