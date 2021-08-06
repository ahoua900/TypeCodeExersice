using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace TypeUser.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        readonly ConcurrentDictionary<string, object> _properties = new ConcurrentDictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool CallPropertyChangeEvent { get; set; } = true;
        
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected T Get<T>(T defValue = default(T), [CallerMemberName] string name = null) {
            return !string.IsNullOrEmpty(name) && _properties.TryGetValue(name, out var value)
                ? (T)value
                : defValue;
        }

        protected bool Set(object value, [CallerMemberName] string name = null) {
            if (string.IsNullOrEmpty(name))
                return false;

            var isExists = _properties.TryGetValue(name, out var getValue);
            if (isExists && Equals(value, getValue))
                return false;

            _properties.AddOrUpdate(name, value, (s, o) => value);

            if (CallPropertyChangeEvent)
                OnPropertyChanged(name);

            return true;
        }
    }
}
