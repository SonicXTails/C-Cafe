using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe
{
    public class Cake
    {
        public string Name;
        public int Cost;

        public Cake(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
