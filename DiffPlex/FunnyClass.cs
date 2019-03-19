using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex
{
    
    /// <summary>
    /// I am a funny class.
    /// </summary>
    /// <description>
    /// Really funny class, very very funny.<br/>  ![Flower image](beauty_5c7e227def98045e009a9b7a.jpg)
    /// </description>
    public class FunnyClass
    {
        /// <summary>
                /// This method will sort list in given order
                /// </summary>
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
