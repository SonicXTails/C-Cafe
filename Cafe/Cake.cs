using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe
{
    public class Form
    {
        public string Name;
        public int Cost;

        public Form(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public class Size
    {
        public string Name;
        public int Cost;

        public Size(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public class Taste
    {
        public string Name;
        public int Cost;

        public Taste(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public class Glaze
    {
        public string Name;
        public int Cost;
        public Glaze(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public class Topping
    {
        public string Name;
        public int Cost;
        public Topping(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
