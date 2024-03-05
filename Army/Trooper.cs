using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class Trooper
    {
        public string name;
        public int power;
        public int vitality;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }
        public int? cost;
        public int Cost
        {
            get { return power * vitality; }
        }
    }
}
