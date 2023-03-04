using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Elements.TestApp {
    class ViewModel : ObservableObject {
        
        // ComboBox

        public ObservableCollection<string> letters { get; set; } = new ObservableCollection<string>() {
            "a", "b", "c", "d", "e"
        };

        private int _selectedLetterIndex = 0;
        public int selectedLetterIndex {
            get { return _selectedLetterIndex; }
            set { 
                if (value != _selectedLetterIndex) {
                    _selectedLetterIndex = value;
                    OnPropertyChanged(nameof(selectedLetterIndex));
                }
            }
        }


        // SpinBox

        private const int sboxValueMin = -10;
        private const int sboxValueMax = 10;

        private int _sboxValue = 0;
        public int sboxValue {
            get { return _sboxValue; }
            set {
                if (value != _sboxValue && value >= sboxValueMin && value <= sboxValueMax) {
                    _sboxValue = value;
                    OnPropertyChanged(nameof(sboxValue));
                }
            }
        }


        public ICommand sboxDecreaseCommand { get; private set; }
        public ICommand sboxIncreaseCommand { get; private set; }

        private void DecreaseSboxValue(object sender) {
            sboxValue -= 1;
        }

        private void IncreaseSboxValue(object sender) {
            sboxValue += 1;
        }


        public ViewModel() {
            sboxDecreaseCommand = new RelayCommand<object>(DecreaseSboxValue);
            sboxIncreaseCommand = new RelayCommand<object>(IncreaseSboxValue);
        }
    }
}
