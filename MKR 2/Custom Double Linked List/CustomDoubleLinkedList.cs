using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Double_Linked_List
{
    public class CustomDoubleLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head; // головной/первый элемент
        private Node<T> _tail; // последний/хвостовой элемент
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
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            _count++;
        }

        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = _head;
            node.Next = temp;
            _head = node;

            if (_count == 0)
            {
                _tail = _head;
            }
            else
            {
                temp.Previous = node;
            }

            _count++;
        }

        // удаление
        public bool Remove(T data)
        {
            Node<T> current = _head;
 
            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }

                current = current.Next;
            }

            if (current!=null)
            {
                // если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    _tail = current.Previous;
                }
 
                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    _head = current.Next;
                }

                _count--;

                return true;
            }

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
            Node<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
         
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
 
        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = _tail;
            
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}