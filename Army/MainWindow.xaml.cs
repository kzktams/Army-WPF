using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Army
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Trooper> army;
        ObservableCollection<Trooper> all = new ObservableCollection<Trooper>();
        int allCost = 0;
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Trooper> army = new ObservableCollection<Trooper>()
            {
                new Trooper(){Name = "pilot", Power=3, Vitality = 10},
                new Trooper(){Name = "marine", Power=10, Vitality = 7},
                new Trooper(){Name = "sniper", Power=9, Vitality = 6},
                new Trooper(){Name = "engineer", Power=5, Vitality = 6}
            };
            lBox.ItemsSource = army;
            lBox2.ItemsSource = all;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            all.Add((Trooper)lBox.SelectedItem);
            foreach (var item in all)
            {
                allCost += item.Cost;
            }
            lb_cost.Content = allCost.ToString() + "$";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            all.Remove((Trooper)lBox2.SelectedItem);
            allCost = 0;
            foreach (var item in all)
            {
                allCost += item.Cost;
            }
            lb_cost.Content = allCost.ToString() + "$";
        }
    }
}
