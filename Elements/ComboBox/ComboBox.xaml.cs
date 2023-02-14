﻿using System;
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
        public ComboBox() {
            InitializeComponent();
        }


        // DEPENDENCY PROPERTIES

        //public static readonly DependencyProperty finalizeSelectionCommandProperty =
        //    DependencyProperty.Register("FinalizeSelectionCommand", typeof(ICommand), typeof(ComboBox), new UIPropertyMetadata(null));
        //public ICommand FinalizeSelectionCommand {
        //    get { return (ICommand)GetValue(finalizeSelectionCommandProperty); }
        //    set { SetValue(finalizeSelectionCommandProperty, value); }
        //}

        public static readonly DependencyProperty BoxWidthProperty =
            DependencyProperty.Register("BoxWidth", typeof(int), typeof(ComboBox), new PropertyMetadata(100));
        public int BoxWidth {
            get { return (int)GetValue(BoxWidthProperty); }
            set { SetValue(BoxWidthProperty, value); }
        }

        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register("ButtonHeight", typeof(int), typeof(ComboBox), new PropertyMetadata(20));
        public int ButtonHeight {
            get { return (int)GetValue(ButtonHeightProperty); }
            set { SetValue(ButtonHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemHeightProperty =
            DependencyProperty.Register("ItemHeight", typeof(int), typeof(ComboBox), new PropertyMetadata(20));
        public int ItemHeight {
            get { return (int)GetValue(ItemHeightProperty); }
            set { SetValue(ItemHeightProperty, value); }
        }

        public static readonly DependencyProperty PopupHeightProperty =
            DependencyProperty.Register("PopupHeight", typeof(int), typeof(ComboBox), new PropertyMetadata(20));
        public int PopupHeight {
            get { return (int)GetValue(PopupHeightProperty); }
            set { SetValue(PopupHeightProperty, value); }
        }

        public static readonly DependencyProperty PopupMaxHeightProperty =
            DependencyProperty.Register("PopupMaxHeight", typeof(int), typeof(ComboBox), new PropertyMetadata(100));
        public int PopupMaxHeight {
            get { return (int)GetValue(PopupMaxHeightProperty); }
            set { SetValue(PopupMaxHeightProperty, value); }
        }


        // EVENTS

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

        private void ControlButton_CheckedUnchecked(object sender, RoutedEventArgs e) {
            if (ControlButton.IsChecked == true) {
                ArrowDown.Visibility = Visibility.Collapsed;
                ArrowUp.Visibility = Visibility.Visible;
            } else {
                ArrowDown.Visibility = Visibility.Visible;
                ArrowUp.Visibility = Visibility.Collapsed;
            }
        }

        private void ContentList_SizeChanged(object sender, SizeChangedEventArgs e) {
            if (ContentList.Items.Count > 0) {
                PopupHeight = ItemHeight * ContentList.Items.Count;
            } else {
                PopupHeight = ButtonHeight;
            }
        }
    }
}
