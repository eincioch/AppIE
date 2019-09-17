﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppIE.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //ocupado
        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                RaisePropertyChanged();
            }
        }

        //Por otro lado, vamos a hacer uso del atributo CallerMemberName con el cual aseguras 
        //que el nombre de la propiedad que llama al método RaisePropertyChanged es el correcto sin tener que indicarlo explícitamente.
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
