using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLib
{
    public abstract class SortingAlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        protected void Swap(int positionA, int positionB)
        {
            T temp = Items[positionA];
            Items[positionA] = Items[positionB];
            Items[positionB] = temp;
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
