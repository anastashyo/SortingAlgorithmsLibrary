using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLib
{
    public class ShakerSort<T> : SortingAlgorithmBase<T> where T:IComparable
    {
        public override void Sort()
        {
            int arrayLength = Items.Count;
            if (arrayLength <= 1) return;
            int begin = 0;
            int end = arrayLength - 1;
            bool isSorted = false;
            while(!isSorted)
            {
                if (begin == arrayLength || end == 0)
                    isSorted = true;
                for (int i = begin; i < end; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                        Swap(i, i + 1);
                }
                end--;
                for (int i = end; i > begin; i--)
                {
                    if (Items[i - 1].CompareTo(Items[i]) == 1)
                        Swap(i, i - 1);
                }
                begin++;
            }
        }
    }
}
