using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gui_004_lab
{
    
    
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    ObservableCollection<Soldier> soldiers;
        public MainWindow()
        {
            InitializeComponent();
            soldiers = new ObservableCollection<Soldier>()
            {
                new Soldier(){Type="Mariner", Power=30,Value=25,Vitality=25},
                new Soldier(){Type="Pilot", Power=20,Value=15,Vitality=27},
                new Soldier(){Type="Infantry", Power=25,Value=35,Vitality=21},
                new Soldier(){Type="Sniper", Power=40,Value=45,Vitality=20},
                new Soldier(){Type="Engineer", Power=20,Value=15,Vitality=20},
            };
            lbox_left.ItemsSource= soldiers;
            
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string selected = (string)(sender as Label).Content;
            var obj= soldiers.Select(t => t.Type == selected);
            ;
        }

        private void btn_editarmy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}