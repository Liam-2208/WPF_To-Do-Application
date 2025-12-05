using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_To_Do
{
    public class Todos :INotifyPropertyChanged
    {
        public Todos()
        {
            _allTodos = new ObservableCollection<TODO>()
            {
                new TODO() { Title = "Learn WPF" },
                new TODO() { Title = "Build a To-Do App" },
            };
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<TODO>? _allTodos;

        public ObservableCollection<TODO> AllTodos
        {
            get { return _allTodos; }
            set
            {
                _allTodos = value;
                OnPropertyChange(nameof(AllTodos));
            }
        }
    }
}
