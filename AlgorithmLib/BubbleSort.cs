using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLib
{
    public class BubbleSort<T> : SortingAlgorithmBase<T> where T : IComparable
	{
		public override void Sort()
		{
			int arrayLength = Items.Count;
			if (arrayLength <= 1) return;
			for (int i = 0; i < arrayLength; i++)
				for (int j = 0; j < arrayLength - i - 1; j++)
					if (Items[j].CompareTo(Items[j + 1]) == 1)
						Swap(j, j + 1);
		}
	}
}
