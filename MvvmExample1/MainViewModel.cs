using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmExample1.Properties;

namespace MvvmExample1
{
	class MainViewModel : INotifyPropertyChanged
	{
		private int _firstNumber;
		private int _secondNumber;

		public event PropertyChangedEventHandler PropertyChanged;

		public int FirstNumber
		{
			get => _firstNumber;
			set
			{
				_firstNumber = value;
				OnPropertyChanged("Sum");
			}
		}

		public int SecondNumber
		{
			get => _secondNumber;
			set
			{
				_secondNumber = value;
				OnPropertyChanged("Sum");
			}
		}

		public int Sum => MathFunctions.Sum(_firstNumber, _secondNumber);
		
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
