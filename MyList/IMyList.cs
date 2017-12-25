using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public interface IMyList
    {
        int this[int index] { get; set; }

        void Add(int value);
        void Insert(int index, int value);
        void RemoveAt(int index);
        bool Contains(int value);

        int Length { get; }
    }
}
