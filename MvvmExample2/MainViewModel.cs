using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmExample2.Annotations;


namespace MvvmExample2
{
	public class MainViewModel : Notifier
	{
		private readonly Summator _summator;

		private readonly ICommand _removeNumber;

		private int _selectedNumberIndex;
		private int _newNumber;

		public MainViewModel()
		{
			_summator = new Summator();
			Numbers = new ObservableCollection<int>(_summator.Numbers);
			AddNumber = new AddNumberCommand(this);
		}

		public Summator GetSummator()
		{
			return _summator;
		}

		public ICommand AddNumber { get; }

		public ObservableCollection<int> Numbers { get; }

		public int Sum => _summator.GetSum();

		public int SelectedNumberIndex
		{
			set
			{
				_selectedNumberIndex = value;
				OnPropertyChanged(nameof(SelectedNumberIndex));
			}
		}

		public int NewNumber
		{
			get => _newNumber;
			set
			{
				_newNumber = value;
				OnPropertyChanged(nameof(NewNumber));
			}
		}
	}
}
