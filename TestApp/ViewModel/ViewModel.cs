using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
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


        // Int SpinBox

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

        private void DecreaseIntSboxValue(object sender) {
            intSboxValue -= 1;
        }

        private void IncreaseIntSboxValue(object sender) {
            intSboxValue += 1;
        }


        // String SpinBox

        public ObservableCollection<string> strValues = new ObservableCollection<string>() {
            "aboba", "bebra", "heheheee", "Aboba Flex"
        };

        private int _chosenValueIndex = 0;
        private int chosenValueIndex {
            get { return _chosenValueIndex; }
            set {
                if (value >= 0 && value < strValues.Count) {
                    _chosenValueIndex = value;
                }
            }
        }

        private string _chosenStringValue;
        public string chosenStringValue {
            get { 
                return (strValues is null || strValues.Count == 0) ? "" : _chosenStringValue; 
            }
            set {
                if (strValues is not null && strValues.Count > 0) {
                    if (_chosenStringValue != value) {
                        _chosenStringValue = value;
                        OnPropertyChanged(nameof(chosenStringValue));
                    }
                } else {
                    _chosenStringValue = "";
                    chosenValueIndex = 0;
                    OnPropertyChanged(nameof(chosenStringValue));
                }
            }
        }

        public ICommand stringSboxDecreaseCommand { get; private set; }
        public ICommand stringSboxIncreaseCommand { get; private set; }

        private void DecreaseStringSboxValue(object sender) {
            chosenValueIndex -= 1;
            chosenStringValue = strValues[chosenValueIndex];
        }

        private void IncreaseStringSboxValue(object sender) {
            chosenValueIndex += 1;
            chosenStringValue = strValues[chosenValueIndex];
        }

        public ViewModel() {
            chosenStringValue = strValues[0];

            intSboxDecreaseCommand = new RelayCommand<object>(DecreaseIntSboxValue);
            intSboxIncreaseCommand = new RelayCommand<object>(IncreaseIntSboxValue);

            stringSboxDecreaseCommand = new RelayCommand<object>(DecreaseStringSboxValue);
            stringSboxIncreaseCommand = new RelayCommand<object>(IncreaseStringSboxValue);
        }
    }
}
