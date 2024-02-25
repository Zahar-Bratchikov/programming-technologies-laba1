namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrList array = new ArrList();
            ChainList chain = new ChainList();

            Random rnd = new Random();
            for (int i = 0; i < 5000; i++)
            {
                int operation = rnd.Next(5);
                int item = rnd.Next(100);
                int pos = rnd.Next(100);
                switch (operation)
                {
                    case 0:
                        array.Add(item);
                        chain.Add(item);
                        break;
                    case 1:
                        array.Delete(pos);
                        chain.Delete(pos);
                        break;
                    case 2:
                        array.Insert(pos, item);
                        chain.Insert(pos, item);
                        break;
                    case 3:
                        array.Clear();
                        chain.Clear();
                        break;
                    case 4:
                        array[pos] = item;
                        chain[pos] = item;
                        break;
                }
            }

            bool flag = true;
            if (array.Count == chain.Count)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    if (array[i] != chain[i])
                    {
                        Console.WriteLine("Error");
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
                flag = false;
            }
            if (flag == true)
            {
                Console.WriteLine("Successfull");
            }


            /*array.Print();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            chain.Print();

            Console.WriteLine(array.Count);
            Console.WriteLine(chain.Count);*/

            /*array.Add(10);
            array.Add(20);
            array.Insert(1, 2);
            Console.WriteLine(array[0]);
            //array.Clear();
            array.Print();

            Console.WriteLine("---------------");

            chain.Add(10);
            chain.Add(20);
            chain.Insert(1, 2);
            Console.WriteLine(chain[0]);
            //chain.Clear();
            chain.Print();*/
        }
    }
}
﻿