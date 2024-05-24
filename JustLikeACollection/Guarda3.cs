using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T item1;
        private T item2;
        private T item3;

        // Constructor that initializes the three variables with default values
        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);
        }

        // Method to get the item at index i
        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            return i switch
            {
                0 => item1,
                1 => item2,
                2 => item3,
                _ => throw new IndexOutOfRangeException(),
            };
        }

        // Method to set the item at index i
        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    item1 = item;
                    break;
                case 1:
                    item2 = item;
                    break;
                case 2:
                    item3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        // Implementing IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            yield return item1;
            yield return item2;
            yield return item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Method to add an item to the first variable that is different from the default value
        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(item1, default(T)))
            {
                item1 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(item2, default(T)))
            {
                item2 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(item3, default(T)))
            {
                item3 = item;
            }
            else
            {
                throw new InvalidOperationException("The Guarda3<T> instance is already full.");
            }
        }
    }
}
