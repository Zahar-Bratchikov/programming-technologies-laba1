namespace laba1
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class ChainList
    {
        Node head;
        int count;

        public ChainList()
        {
            head = null;
            count = 0;
        }

        public void Add(int item)
        {
            if (head == null)
            {
                head = new Node(item);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(item);
            }
            count++;
        }

        public void Insert(int index, int item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                Node newNode = new Node(item);
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                Node newNode = new Node(item);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; ++i)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Data = value;
            }
        }

        public Node NodeFind(int pos)
        {
            if (pos >= count) return null;
            int i = 0;
            Node P = head;
            while (P != null && i < pos)
            {
                P = P.Next;
                i++;
            }
            if (i == pos) return P;
            else return null;
        }

        public int Count
        {
            get { return count; }
        }

        public void print()
        {
            ChainList current = head;
            while (current != null)
            {
                Console.WriteLine(current.);

            }
        }
    }
}