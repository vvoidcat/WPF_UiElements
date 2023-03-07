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

namespace Elements.IntSpinBox {
    /// <summary>
    /// Interaction logic for IntSpinBox.xaml
    /// </summary>
    public partial class IntSpinBox : UserControl {
        public static readonly DependencyProperty titleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(IntSpinBox), new PropertyMetadata(String.Empty));
        public string Title {
            get { return (string)GetValue(titleProperty); }
            set { SetValue(titleProperty, value); }
        }

        public static readonly DependencyProperty TitleWidthProperty =
            DependencyProperty.Register("TitleWidth", typeof(int), typeof(IntSpinBox), new PropertyMetadata(100));
        public int TitleWidth {
            get { return (int)GetValue(TitleWidthProperty); }
            set { SetValue(TitleWidthProperty, value); }
        }

        public static readonly DependencyProperty BoxWidthProperty =
            DependencyProperty.Register("BoxWidth", typeof(int), typeof(IntSpinBox), new PropertyMetadata(100));
        public int BoxWidth {
            get { return (int)GetValue(BoxWidthProperty); }
            set { SetValue(BoxWidthProperty, value); }
        }

        public static readonly DependencyProperty BoxHeightProperty =
            DependencyProperty.Register("BoxHeight", typeof(int), typeof(IntSpinBox), new PropertyMetadata(20));
        public int BoxHeight {
            get { return (int)GetValue(BoxHeightProperty); }
            set { SetValue(BoxHeightProperty, value); }
        }

        public static readonly DependencyProperty boxValueProperty =
            DependencyProperty.Register("BoxValue", typeof(string), typeof(IntSpinBox), new PropertyMetadata(String.Empty));
        public string BoxValue {
            get { return (string)GetValue(boxValueProperty); }
            set { SetValue(boxValueProperty, value); }
        }

        public static readonly DependencyProperty decreaseCommandProperty =
            DependencyProperty.Register("DecreaseCommand", typeof(ICommand), typeof(IntSpinBox), new UIPropertyMetadata(null));
        public ICommand DecreaseCommand {
            get { return (ICommand)GetValue(decreaseCommandProperty); }
            set { SetValue(decreaseCommandProperty, value); }
        }

        public static readonly DependencyProperty increaseCommandProperty =
            DependencyProperty.Register("IncreaseCommand", typeof(ICommand), typeof(IntSpinBox), new UIPropertyMetadata(null));
        public ICommand IncreaseCommand {
            get { return (ICommand)GetValue(increaseCommandProperty); }
            set { SetValue(increaseCommandProperty, value); }
        }

        public IntSpinBox() {
            InitializeComponent();
        }
    }
}
