using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //public static readonly DependencyProperty titleProperty =
        //    DependencyProperty.Register("Title", typeof(string), typeof(SpinBox), new PropertyMetadata(String.Empty));
        //public string Title {
        //    get { return (string)GetValue(titleProperty); }
        //    set { SetValue(titleProperty, value); }
        //}

        //public static readonly DependencyProperty controlCommandProperty =
        //    DependencyProperty.Register("ControlCommand", typeof(ICommand), typeof(ComboBox), new UIPropertyMetadata(null));
        //public ICommand ControlCommand {
        //    get { return (ICommand)GetValue(controlCommandProperty); }
        //    set { SetValue(controlCommandProperty, value); }
        //}

        public ComboBox() {
            InitializeComponent();
        }
    }
}
