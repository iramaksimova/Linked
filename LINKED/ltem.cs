using System;

namespace linked_list.Model
{
    /// <summary>
    /// ячейка списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        /// <summary>
        /// Данные хранимые в ячейке сп.
        /// </summary>
        private T data = default(T);
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));

            }





        }

        /// <summary>
        /// следующая ячейка сп.
        /// </summary>


        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }



}
