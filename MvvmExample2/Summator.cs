using System.Collections.Generic;
using System.Linq;


namespace MvvmExample2
{
	public class Summator
	{
		public List<int> Numbers { get; } = new List<int>();

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
