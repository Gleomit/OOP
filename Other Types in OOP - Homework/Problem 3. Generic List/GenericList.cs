namespace GenericList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using GenericListVersion;

    [Version(1, 6)]
    public class GenericList<T> : IComparable<T>
    {
        private T[] elements;
        private int currentItemIndex;
        private const int DEFAULT_CAPACITY = 16;

        public GenericList(int capacity = DEFAULT_CAPACITY)
        {
            elements = new T[capacity];
            currentItemIndex = 0;
        }

        public void Add(T item)
        {
            this.elements[currentItemIndex] = item;
            currentItemIndex++;
            IsInternalArrayFull();
        }
        
        public T ElementAt(int index)
        {
            if (index < 0 || index > this.elements.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            else
            {
                return elements[index];
            }
        }

        public int Length
        {
            get { return this.elements.Length; }
        }

        public void Clear()
        {
            Array.Clear(this.elements, 0, this.elements.Length);
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.elements.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            else
            {
                if (this.elements[index] != null)
                {
                    this.elements[index] = default(T);
                }
            }
        }

        public int Find(T value)
        {     
            return Array.IndexOf(this.elements, value);
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > this.elements.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            else
            {
                if (this.elements[index] == null)
                {
                    this.elements[index] = value;
                }
                else
                {
                    T[] newArr = new T[this.elements.Length + 1];
                    Array.Copy(this.elements, 0, newArr, 0, index + 1);
                    Array.Copy(this.elements, index, newArr, index + 1, this.elements.Length - index);
                    this.elements = newArr;
                }
            }
        }

        public bool Contains(T value)
        {
            if (Array.IndexOf(this.elements, value) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Min<B>() where B : IComparable
        {
            return this.elements.Min();
        }

        public T Max<B>() where B : IComparable
        {
            return this.elements.Max();
        }

        public override string ToString()
        {
            return String.Join(", ", this.elements);
        }

        private bool IsInternalArrayFull()
        {
            foreach (T element in this.elements)
            {
                if(element == null)
                {
                    return false;
                }
            }
            AutoGrow();
            return true;
        }

        private void AutoGrow()
        {
            T[] expanded = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                expanded[i] = this.elements[i];
            }
            this.elements = expanded;
        }
    }
}
