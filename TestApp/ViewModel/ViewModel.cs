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


        // IntSpinBox

        private const int intSboxValueMin = -10;
        private const int intSboxValueMax = 10;

        private int _intSboxValue = 0;
        public int intSboxValue {
            get { return _intSboxValue; }
            set {
                if (value != _intSboxValue && value >= intSboxValueMin && value <= intSboxValueMax) {
                    _intSboxValue = value;
                    OnPropertyChanged(nameof(intSboxValue));
                }
            }
        }


        public ICommand intSboxDecreaseCommand { get; private set; }
        public ICommand intSboxIncreaseCommand { get; private set; }

        private void DecreaseSboxValue(object sender) {
            intSboxValue -= 1;
        }

        private void IncreaseSboxValue(object sender) {
            intSboxValue += 1;
        }


        public ViewModel() {
            intSboxDecreaseCommand = new RelayCommand<object>(DecreaseSboxValue);
            intSboxIncreaseCommand = new RelayCommand<object>(IncreaseSboxValue);
        }
    }
}
