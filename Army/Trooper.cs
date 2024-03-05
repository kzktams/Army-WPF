using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class Trooper : INotifyPropertyChanged
    {
        public string name;
        public int power;
        public int vitality;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public int Power
        {
            get { return power; }
            set { power = value; OnPropertyChanged(); }
        }
        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; OnPropertyChanged(); }
        }
        public int? cost;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Cost
        {
            get { return power * vitality; }
        }
    }
}
