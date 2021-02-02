using System;

namespace MyListClass
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> asli = new MyList<string>();
            Console.WriteLine(asli.count);

            asli.Add("asli");
            asli.Add("efe");
            Console.WriteLine(asli.count);
            Console.WriteLine(asli.items[0] + " " + asli.items[1]);



        }
    }

    class MyList<T>
    {
        T[] aarray;
        T[] temparr;

        public MyList()
        {
            aarray = new T[0];
        }

        public void Add(T item)
        {
            temparr = aarray;
            aarray = new T[aarray.Length + 1];

            for (int i = 0; i < temparr.Length; i++)
            {
                aarray[i] = temparr[i];
            }

            aarray[aarray.Length - 1] = item;

        }



        public int count
        {
            get { return aarray.Length; }

        }

        public T[] items
        {
            get { return aarray; }
        }


    }
}
