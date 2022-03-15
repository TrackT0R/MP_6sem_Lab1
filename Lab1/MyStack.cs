using System;
using System.Linq;

namespace Lab1
{
    public class MyStack<T>
    {
        #region Data
        public int Count     { get; private set; }
        private int _Capacity { get; set; }
        private T[] _items   { get; set; }
        #endregion

        #region Constructors
        public MyStack()
        {
            Count = 0;
            _Capacity = 4;
            _items = new T[_Capacity];
        }
        #endregion

        #region Public methods
        public void Push(T elem)
        {
            _items[Count++] = elem;
            IncreaseCapacity();
        }

        public T Pop()
        {
            Count--;
            return _items[Count];
        }

        public T Peek()
        {
            return _items[Count-1];
        }

        public bool Contains(T elem)
        {
            return _items.Contains(elem);
        }
        #endregion
        
        #region Private methods
        private void IncreaseCapacity()
        {
            if (Count == _Capacity) {
                _Capacity *= 2;
                var newItems = new T[_Capacity];
                Array.Copy(_items, newItems, Count);
                _items = newItems;
            }
        }
        #endregion
    }
}
