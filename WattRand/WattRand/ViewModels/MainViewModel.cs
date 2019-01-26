using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WattRand.BusinessLogic;

namespace WattRand.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private SumControlViewModel _activeSumControlViewModel;
        private ObservableCollection<ControlElementViewModel> _elements;
        private bool _isSumPopUpOpen;
        private string _errorText;

        public MainViewModel()
        {
            Elements = new ObservableCollection<ControlElementViewModel>();
            AddElementCommand = new RelayCommand<Object>(AddCommandExecute);
            ExecuteCommand = new RelayCommand<Object>(ExecuteCommandExecute);
            SortElementsCommand = new RelayCommand<Object>(SortElementsCommandExecute);
            ActiveSumControlViewModel = new SumControlViewModel(DateTime.Now, true);
            IsSumPopUpOpen = false;
            Elements.Add(GetNewElement());
        }


        public ObservableCollection<ControlElementViewModel> Elements
        {
            get { return _elements; }
            set
            {
                _elements = value;
                RaisePropertyChanged("Elements");
            }
        }
        public SumControlViewModel ActiveSumControlViewModel
        {
            get { return _activeSumControlViewModel; }
            set
            {
                _activeSumControlViewModel = value;
                RaisePropertyChanged("ActiveSumControlViewModel");
            }
        }
        public bool IsSumPopUpOpen
        {
            get { return _isSumPopUpOpen; }
            set
            {
                _isSumPopUpOpen = value;
                RaisePropertyChanged("IsSumPopUpOpen");
            }
        }

        public string ErrorText
        {
            get { return _errorText; }
            set
            {
                _errorText = value;
                RaisePropertyChanged("ErrorText");
            }
        }

        public ICommand AddElementCommand { get; private set; }
        public ICommand SortElementsCommand { get; private set; }
        public ICommand ExecuteCommand { get; private set; }

        private void AddCommandExecute(object o)
        {

            Elements.Add(GetNewElement());
        }

        private void SortElementsCommandExecute(object obj)
        {

            Elements = new ObservableCollection<ControlElementViewModel>(Elements.OrderBy(e => e.Date));
        }

        private void ExecuteCommandExecute(object obj)
        {
            WattRandManager manager = new WattRandManager() { Elements = this.Elements.ToList().ConvertAll(v => v.GetElement()) };

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Foglio di calcolo Excel 2007-2010 (.xlsx)|*.xlsx|Foglio Word 2007-2010 (.docx)|*.docx";
            bool? result = dialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                string filename = dialog.FileName.EndsWith(".xlsx") ? dialog.FileName : $"{dialog.FileName}.xlsx" ;
                try
                {
                    manager.Elaborate(filename);
                    ErrorText = $"Esportazione completata: {filename}";
                }
                catch (Exception e)
                {
                    ErrorText = e.Message;

                }
            }
        }


        private ControlElementViewModel GetNewElement()
        {
            var newElement = new ControlElementViewModel(new ControlElement(DateTime.Now, 0, 0));
            newElement.CloseSumPopUp += (e) => { IsSumPopUpOpen = false; };
            newElement.OpenSumPopUp += (vm) =>
            {
                ActiveSumControlViewModel = vm;
                IsSumPopUpOpen = true;
            };
            newElement.RequestedRemove += (element) => { Elements.Remove(element); };
            return newElement;
        }



    }
}
