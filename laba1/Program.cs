using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrList array = new ArrList();
            ChainList chain = new ChainList();

            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                int operation = rnd.Next(4);
                int item = rnd.Next(100);
                int pos = rnd.Next(100);
                switch (operation)
                {
                    case 1:
                        array.Add(item);
                        chain.Add(item);
                        break;
                    case 2:
                        array.Delete(pos);
                        chain.Delete(pos);
                        break;
                    case 3:
                        array.Insert(pos, item);
                        chain.Insert(pos, item);
                        break;
                    case 4:
                        array.Clear();
                        chain.Clear();
                        break;
                }
            }
        }
    }
}