using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProgramLR10Garipov
{
    public class Context
    {
        public IStrategy strategy;
        public static int[] array;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void SortArr(bool flag = true)
        {
            strategy.SortArr(array, flag);
        }

        internal void AnalSortArr(AnalInfo sort)
        {
            strategy.AnalSortArr(sort);
        } 
    }

}
