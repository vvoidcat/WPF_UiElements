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
        //public static readonly DependencyProperty finalizeSelectionCommandProperty =
        //    DependencyProperty.Register("FinalizeSelectionCommand", typeof(ICommand), typeof(ComboBox), new UIPropertyMetadata(null));
        //public ICommand FinalizeSelectionCommand {
        //    get { return (ICommand)GetValue(finalizeSelectionCommandProperty); }
        //    set { SetValue(finalizeSelectionCommandProperty, value); }
        //}

        public ComboBox() {
            InitializeComponent();
        }

        private void ListBoxItem_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (sender as ListBoxItem is not null) {
                if (sender != ContentList.SelectedItem) {
                    ListBoxItem item = (ListBoxItem)sender;
                    ContentList.SelectedItem = item;
                    item.IsSelected = true;
                }
                
                ComboboxPopup.IsOpen = false;
            }
        }
    }
}
