﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Crossroads.ViewModel
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged([CallerMemberName] string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName=null)
        {
            if(Equals(field, value)) return false;
            field = value;
            onPropertyChanged(PropertyName); return true;
        }
    }
}
