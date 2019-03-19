using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex
{
    
    public class FunnyClass
    {
        /// <summary>
        /// This method will sort list in given order 
        /// </summary>
        /// <param name="array">list to be sorted</param>
        /// <param name="sortInAscOrder">Order of sorting.</param>
        public List<int> SortList(List<int> array, bool sortInAscOrder)
        {
            if (sortInAscOrder)
            {
                array.Sort();
            }
            else
            {
                array.Sort();
                array.Reverse();
            }
            return array;
        }

        
        public void Add()
        {
            Console.Write("You called add method");
        }
    }
}
