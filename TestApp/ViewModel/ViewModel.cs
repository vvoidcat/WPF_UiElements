using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.TestApp {
    class ViewModel : ObservableObject {

        public ObservableCollection<string> letters { get; set; } = new ObservableCollection<string>() {
            "a", "b", "c", "d", "e"
        };

        private int _selectedLetterIndex = 0;
        public int selectedLetterIndex {
            get { return _selectedLetterIndex; }
            set { 
                if (value != _selectedLetterIndex) {
                    OnPropertyChanged(nameof(selectedLetterIndex));
                }
            }
        }

        public ViewModel() {
            //
        }
    }
}
