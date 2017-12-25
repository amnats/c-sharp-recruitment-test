/* 
 *  Implement all the methods. You can add and edit all objects in this solution except for the project with tests.
 *  You can consider this task complete when all tests run green.
 * 
 *  Optional tasks:
 *  - make the objects of this class consumable by a foreach statement
 *  - add `First` and `Last` methods
 *  - add and implement a generic version of MyList collection
 *  - add a new test project to the solution and add tests for the new tasks
 * 
 */

using System;
using System.Collections;

namespace MyList
{
    public class MyList : IMyList
    {
        public MyList(int initialCapacity)
        {
            _arr = new int[initialCapacity];
        }

        private int[] _arr;

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Add(int value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool Contains(int value)
        {
            throw new NotImplementedException();
        }

        private int _length;
        public int Length => _length;
    }
}
