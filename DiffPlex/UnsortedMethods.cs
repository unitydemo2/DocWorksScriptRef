using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex
{
    public class UnsortedMethods
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
                array.Reverse();
            }
            return array;
        }

        public void Add()
        {

        }

        public void Multiply(int a, int b)
        {

        }
        /// <summary>
        /// This is a test method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Divide(int x, int y) {
            Console.Write(x / y);
        }
    }
}
