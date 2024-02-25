
namespace laba1
{
    public class ArrList
    {
        int[] buffer; // массив для хранения элементов списка
        int count; // счетчик количества элементов в списке
        int capacity; // начальная емкость массива

        public ArrList()
        {
            capacity = 2;
            buffer = new int[capacity];
            count = 0;
        }

        void Expand()
        {
            capacity *= 2;
            int[] newBuffer = new int[capacity];
            Array.Copy(buffer, newBuffer, count);
            buffer = newBuffer;
        }

        public void Add(int item)
        {
            if (count == capacity)
            {
                Expand();
            }

            buffer[count] = item;
            count++;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    //throw new IndexOutOfRangeException();
                    return 0;
                }
                return buffer[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    //throw new IndexOutOfRangeException();
                    return;
                }
                buffer[index] = value;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public void Insert(int position, int item)
        {
            if (position < 0 || position > count)
            {
                //throw new IndexOutOfRangeException();
                return;
            }

            if (count == capacity)
            {
                Expand();
            }

            for (int i = count; i > position; i--)
            {
                buffer[i] = buffer[i - 1];
            }

            buffer[position] = item;
            count++;
        }

        public void Delete(int position)
        {
            if (position < 0 || position >= count)
            {
                //throw new IndexOutOfRangeException();
                return;

            }

            for (int i = position; i < count - 1; i++)
            {
                buffer[i] = buffer[i + 1];
            }

            count--;
        }

        public void Clear()
        {
            buffer = new int[capacity]; // Восстановление буфера с начальной емкостью
            count = 0;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(buffer[i] + " ");
            }
        }
    }
}
