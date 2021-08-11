using System;

namespace GenericExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            myList.Add("Ali");
            myList.Add("Kemal");
            myList.ShowMyList();

            MyList<int> myList1 = new MyList<int>();

            myList1.Add(12);
            myList1.Add(13);
            myList1.ShowMyList();
        }
    }
}
