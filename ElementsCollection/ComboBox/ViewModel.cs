using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Elements.Common;

namespace Elements.ComboBox {
    class ViewModel : ObservableObject {
        private bool _isPopupOpen = false;
        public bool isPopupOpen {
            get { return _isPopupOpen; }
            set { 
                _isPopupOpen = value;
                OnPropertyChanged(nameof(isPopupOpen));
            }
        }

        public ICommand controlCommand { get; private set; }
        private void OpenClosePopup(object sender) {
            Debug.WriteLine("aboba");
            isPopupOpen = !isPopupOpen;
        }

        public ViewModel() {
            controlCommand = new RelayCommand<object>(OpenClosePopup);


            Task.Run(() => {
                while (true) {
                    //if (historyNames.Count > 2) {
                    //    Debug.WriteLine(": " + historyNames[historyNames.Count - 1].val + " | " + historyNames[historyNames.Count - 2].val);
                    //}
                    Debug.WriteLine(": " + isPopupOpen);
                    Thread.Sleep(500);
                }
            });
        }
    }
}
