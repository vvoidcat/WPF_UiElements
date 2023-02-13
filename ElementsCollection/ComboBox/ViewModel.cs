using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Elements.Common;

namespace Elements.ComboBox {
    class ViewModel : ObservableObject {
        public ICommand controlCommand { get; private set; }
        private void OpenCloseListView(object sender) {

        }

        public ViewModel() {

        }
    }
}
