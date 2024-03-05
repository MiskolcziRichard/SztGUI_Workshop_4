using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Gui_004_lab
{
    /// <summary>
    /// Interaction logic for EditSoldier.xaml
    /// </summary>
    public partial class EditSoldier : Window
    {
        Soldier s;
        public EditSoldier(Soldier s)
        {
            InitializeComponent();
            this.s = s;
        }
    }
}
