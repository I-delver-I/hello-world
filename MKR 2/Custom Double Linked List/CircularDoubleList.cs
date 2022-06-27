using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Double_Linked_List
{
    public class CircularDoubleList<T> : IEnumerable<T>
    {
        private Node<T> _head; // головной/первый элемент
        private int _count;  // количество элементов в списке

        public int Count => _count;
        public bool IsEmpty => _count == 0;
 
        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
 
            if (_head == null)
            {
                _head = node;
                _head.Next = node;
                _head.Previous = node;
            }
            else
            {
                node.Previous = _head.Previous;
                node.Next = _head;
                _head.Previous.Next = node;
                _head.Previous = node;
            }

            _count++;
        }

        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> removedItem = null;

            if (_count == 0)
            {
                return false;
            }
 
            // поиск удаляемого узла
            do
            {
                if (current.Data.Equals(data))
                {
                    removedItem = current;
                    break;
                }

                current = current.Next;
            }
            while (current != _head);
 
            if (removedItem != null)
            {
                // если удаляется единственный элемент списка
                if (_count == 1)
                {
                    _head = null;
                }
                else
                {
                    // если удаляется первый элемент
                    if (removedItem == _head)
                    {
                        _head = _head.Next;
                    }

                    removedItem.Previous.Next = removedItem.Next;
                    removedItem.Next.Previous = removedItem.Previous;
                }

                _count--;

                return true;
            }

            return false;
        }
 
        public void Clear()
        {
            _head = null;
            _count = 0;
        }
 
        public bool Contains(T data)
        {
            Node<T> current = _head;
            
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
 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;

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