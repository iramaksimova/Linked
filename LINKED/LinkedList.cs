using System;
using System.Collections;

namespace linked_list.Model
{
    /// <summary>
    /// односвязный список
    /// </summary>

    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// 1 элемент с-а
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// посл-ий элемент с-а
        /// </summary>

        public Item<T> Tail { get; private set; }

        /// <summary>
        /// кол-во эл в списке
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// создать пустой список
        /// </summary>

        public LinkedList()
        {
            Clear();
        }



        /// <summary>
        /// создать список с началь-м эл
        /// </summary>


        public LinkedList(T data)
        {
            var item = new Item<T>(data);

            SetHeadAndTail(data);

        }

        /// <summary>
        /// добавить данные в конец списка
        /// </summary>

        public void Add(T data)
        {


            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;

            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;


                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }

            }

            else
            {
                SetHeadAndTail(data);
            }
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            {
                item.Next = Head;
            }

            Head = item;
            Count++;
        }

        public void InsertAftar(T target, T data)
        {

            if (Head != null)
            {

                var current = Head;
                while (current != null)
                    if (current.Data.Equals(target))
                    {
                        var iten = new Item<T>(data);
                        iten.Next = current.Next;
                        current.Next = iten;
                        Count++;
                        return;
                    }

                    else
                    {
                        current = current.Next;
                    }
            }


        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }



        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }


        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + "элементов";
        }
    }

}