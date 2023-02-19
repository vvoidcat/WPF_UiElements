using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.TestApp {
    class ViewModel : ObservableObject {
        public ObservableCollection<DataWrapper<string>> letters1 { get; set; } = new ObservableCollection<DataWrapper<string>>() {
            new DataWrapper<string>("a"),
            new DataWrapper<string>("b"),
            new DataWrapper<string>("c"),
            new DataWrapper<string>("d"),
            new DataWrapper<string>("e")
        };

        public ObservableCollection<string> letters2 { get; set; } = new ObservableCollection<string>() {
            "a", "b", "c", "d", "e"
        };

        public ViewModel() {
            //

            letters1.Add(new DataWrapper<string>("abobs"));
            letters2.Add("abobus");
        }
    }
}
