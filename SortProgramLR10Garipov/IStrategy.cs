using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProgramLR10Garipov
{
    public interface IStrategy
    {
        void SortArr(int[] arr, bool flag);
        void AnalSortArr(AnalInfo info);
    }
}
