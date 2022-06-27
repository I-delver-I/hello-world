using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Linked_List
{
    public class CircularLinkedList<T> : IEnumerable<T>
    {
        private CircularListNode<T> _head; // головной/первый элемент
        private CircularListNode<T> _tail; // последний/хвостовой элемент
        private int _count;  // количество элементов в списке

        public int Count => _count;
        public bool IsEmpty => _count == 0;
 
        // добавление элемента
        public void Add(T data)
        {
            CircularListNode<T> node = new CircularListNode<T>(data);
            // если список пуст
            if (_head == null)
            {
                _head = node;
                _tail = node;
                _tail.Next = _head;
            }
            else
            {
                node.Next = _head;
                _tail.Next = node;
                _tail = node;
            }

            _count++;
        }
        public bool Remove(T data)
        {
            CircularListNode<T> current = _head;
            CircularListNode<T> previous = null;
 
            if (IsEmpty) return false;
 
            do
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
 
                        // Если узел последний,
                        // изменяем переменную tail
                        if (current == _tail)
                        {
                            _tail = previous;
                        }
                    }
                    else // если удаляется первый элемент
                    {
                        // если в списке всего один элемент
                        if(_count==1)
                        {
                            _head = _tail = null;
                        }
                        else
                        {
                            _head = current.Next;
                            _tail.Next = current.Next;
                        }
                    }

                    _count--;

                    return true;
                }
 
                previous = current;
                current = current.Next;
            }
            while (current != _head);
 
            return false;
        }
 
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
 
        public bool Contains(T data)
        {
            CircularListNode<T> current = _head;

            if (current == null)
            {
                return false;
            }

            do
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }
            while (current != _head);

            return false;
        }
 
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            CircularListNode<T> current = _head;

            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != _head);
        }
    }
}