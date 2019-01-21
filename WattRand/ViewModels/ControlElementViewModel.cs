using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WattRand.BusinessLogic;

namespace WattRand.ViewModels
{
    public delegate void RemoveControlElementHandler(ControlElementViewModel element);
    public class ControlElementViewModel : BaseViewModel
    {
        private ControlElement _element;
        private DateTime _date;
        private double _inValue;
        private double _outValue;

        public event RemoveControlElementHandler RequestedRemove;
        public event SumControlOpenEventHandler OpenSumPopUp;
        public event SumControlCloseEventHandler CloseSumPopUp;
        public ControlElementViewModel(ControlElement element)
        {
            _element = element;
            Date = _element.Date;
            InValue = _element.OutValue;
            OutValue = _element.InValue;
            RemoveCommand = new RelayCommand<Object>(RemoveCommandExecute);
            OpenSumCommand = new RelayCommand<string>(OpenSumCommandExecute);
        }

        private void OpenSumCommandExecute(string obj)
        {
            var isIn = String.IsNullOrEmpty(obj) ? false : obj.ToLower() == "true";
            SumControlViewModel vm = new SumControlViewModel(Date, isIn);
            vm.OnClose += (r) => 
            {
                if(isIn)
                {
                    InValue = r;
                }
                else
                {
                    OutValue = r;
                }
                CloseSumPopUp?.Invoke(r);
            };
            OpenSumPopUp?.Invoke(vm);
        }

        private void RemoveCommandExecute(object obj)
        {
            RequestedRemove?.Invoke(this);
        }

        public ControlElement GetElement()
        {
            return new ControlElement(Date, InValue, OutValue);
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                RaisePropertyChanged("Date");
            }
        }

        public double InValue
        {
            get { return _inValue; }
            set
            {
                _inValue = value;
                RaisePropertyChanged("InValue");
            }
        }

        public double OutValue
        {
            get { return _outValue; }
            set
            {
                _outValue = value;
                RaisePropertyChanged("OutValue");
            }
        }

        public ICommand RemoveCommand { get; private set; }
        public ICommand OpenSumCommand { get; private set; }
    }
}
