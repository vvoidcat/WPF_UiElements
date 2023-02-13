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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Elements.ComboBox {
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : UserControl {
        public static readonly DependencyProperty controlCommandProperty =
            DependencyProperty.Register("ControlCommand", typeof(ICommand), typeof(ComboBox), new UIPropertyMetadata(null));
        public ICommand ControlCommand {
            get { return (ICommand)GetValue(controlCommandProperty); }
            set { SetValue(controlCommandProperty, value); }
        }

        public ComboBox() {
            InitializeComponent();
        }
    }
}
