namespace laba1
{
    public class ChainList
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;
        private int count;

        public ChainList()
        {
            head = null;
            count = 0;
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

        public void Add(int item)
        {
            if (head == null)
            {
                head = new Node(item);
            }
            else
            {
                Node lastNode = NodeFind(count - 1);
                lastNode.Next = new Node(item);
            }
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

                Node current = NodeFind(index);
                return current.Data;
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    //throw new IndexOutOfRangeException();
                    return;
                }

                Node current = NodeFind(index);
                current.Data = value;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public void Insert(int pos, int item)
        {
            if (pos < 0 || pos > count)
            {
                //throw new IndexOutOfRangeException();
                return;
            }

            if (pos == 0)
            {
                Node newNode = new Node(item);
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node prevNode = NodeFind(pos - 1);
                Node newNode = new Node(item);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
            count++;
        }

        public void Delete(int pos)
        {
            if (pos < 0 || pos >= count)
            {
                //throw new IndexOutOfRangeException();
                return;
            }

            if (pos == 0)
            {
                head = head.Next;
            }
            else
            {
                Node prevNode = NodeFind(pos - 1);
                prevNode.Next = prevNode.Next.Next;
            }
            count--;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
