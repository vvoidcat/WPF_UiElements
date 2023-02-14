using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.TestApp {
    public class DataWrapper<T> : ObservableObject {
        private T _val;
        public T val {
            get { return _val; }
            set {
                _val = value;
                OnPropertyChanged(nameof(val));
            }
        }

        public DataWrapper(T newValue) {
            _val = newValue;
        }
    }
}
