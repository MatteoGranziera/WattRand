using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WattRand.ViewModels
{
    public delegate void SumControlCloseEventHandler(double value);
    public delegate void SumControlOpenEventHandler(SumControlViewModel viewModel);
    public class SumControlViewModel : BaseViewModel
    {
        private double _valueOne;
        private double _valueTwo;
        private double _valueThree;
        private DateTime _dateSelected;
        private bool _isInValue;

        public event SumControlCloseEventHandler OnClose;
        public SumControlViewModel(DateTime date, bool inValue)
        {
            ConfirmCommand = new RelayCommand<Object>(ConfirmCommandExecute);
            DateSelected = date;
            IsInValue = inValue;
            _valueOne = 0;
            _valueTwo = 0;
            _valueThree = 0;
        }

        private void ConfirmCommandExecute(object obj)
        {
            OnClose?.Invoke(ValueOne + ValueTwo + ValueThree);
        }

        public ICommand ConfirmCommand { get; private set; }
        

        public double ValueOne
        {
            get { return _valueOne; }
            set
            {
                _valueOne = value;
                RaisePropertyChanged("ValueOne");
            }
        }

        public double ValueTwo
        {
            get { return _valueTwo; }
            set
            {
                _valueTwo = value;
                RaisePropertyChanged("ValueTwo");
            }
        }

        public double ValueThree
        {
            get { return _valueThree; }
            set
            {
                _valueThree = value;
                RaisePropertyChanged("ValueThree");
            }
        }

        public DateTime DateSelected
        {
            get { return _dateSelected; }
            set
            {
                _dateSelected = value;
                RaisePropertyChanged("DateSelected");
            }
        }

        public bool IsInValue
        {
            get { return _isInValue; }
            set
            {
                _isInValue = value;
                RaisePropertyChanged("IsInValue");
            }
        }
    }
}
