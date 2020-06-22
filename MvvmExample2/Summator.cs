using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace MvvmExample2
{
	public class Summator
    {
        public Summator()
        {
            Numbers = new ObservableCollection<int>
            {
				1, 2, 3, 4, 5, 6, 7, 8, 9, 0
            };
        }

        public ObservableCollection<int> Numbers { get; }

        public void AddNumber(int number)
		{
			Numbers.Add(number);
		}

		public void RemoveNumber(int index)
		{
			if (index >= 0 && index < Numbers.Count)
			{
				Numbers.RemoveAt(index);
			}
		}

		public int GetSum()
		{
			return Numbers.Sum();
		}
	}
}
