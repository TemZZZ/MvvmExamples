using System.Collections.ObjectModel;


namespace MvvmExample2
{
	public class MainViewModel : Notifier
    {
        private readonly Summator _summator;

        private RelayCommand _addNumberCommand;
        private RelayCommand _removeNumberCommand;

		private int _newNumber;
        private int _selectedIndex;

        public MainViewModel()
        {
            _summator = new Summator();
        }

        public ObservableCollection<int> Numbers => _summator.Numbers;

        public int Sum => _summator.GetSum();

		public int NewNumber
        {
            get => _newNumber;
			set => _newNumber = value;
        }

        public int SelectedIndex
        {
            set => _selectedIndex = value;
        }

        public RelayCommand AddNumberCommand
        {
            get
            {
                return _addNumberCommand
                       ?? (_addNumberCommand = new RelayCommand(AddNumber));
            }
        }

        public RelayCommand RemoveNumberCommand
        {
            get
            {
                return _removeNumberCommand
                       ?? (_removeNumberCommand
                           = new RelayCommand(RemoveNumber));
            }
        }

        private void AddNumber(object parameter)
        {
            _summator.AddNumber(_newNumber);
            OnPropertyChanged(nameof(Sum));
        }

        private void RemoveNumber(object parameter)
        {
            _summator.RemoveNumber(_selectedIndex);
            OnPropertyChanged(nameof(Sum));
        }
	}
}
