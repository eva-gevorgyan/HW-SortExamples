namespace SortExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------
            //SortArray
            //Random rnd2 = new Random();
            //int[] arr = new int[5];
            //for(int i = 0; i < arr.Length; i++)
            //{

            //    arr[i] = rnd2.Next(-3,22);
            //}
            //foreach(var i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //void SortArr(int[] arr)
            //{
            //    int n = arr.Length;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (arr[j] > arr[j + 1])
            //            {
            //                int s = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = s;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("\nSorted Array\n");
            //SortArr(arr);
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------------------

            //SortList
            //List<int> myList = new List<int>();
            //Random rnd = new Random();
            //for(int i=0;i<5;i++)
            //{
            //    int rndvalue= rnd.Next(-2,15);
            //    myList.Add(rndvalue);
            //}
            //foreach(var i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\nSorted List\n");

            //SortList(myList);
            //foreach (var i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //void SortList(List<int> myList)
            //{
            //    int n = myList.Count;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (myList[j] > myList[j + 1])
            //            {
            //                int s = myList[j];
            //                myList[j] = myList[j + 1];
            //                myList[j + 1] = s;
            //            }
            //        }
            //    }
            //}

            //-----------------------------------------------

            //SortQueue
            //Queue<int> queue = new Queue<int>();
            //Random rnd3=new Random();
            //for(int i = 0; i < 5; i++)
            //{
            //    int rnd3value = rnd3.Next(-4, 19);
            //    queue.Enqueue(rnd3value);
            //}
            //foreach(var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //List<int> list_queue = queue.ToList();
            //SortList(list_queue);
            //Console.WriteLine("\nSorted Queue");
            //foreach (var i in list_queue)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------------------

            //SortStack

            //Stack<int> stack_num = new Stack<int>(5);
            //Random rnd4=new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int rndnums = rnd4.Next(-5, 10);
            //    stack_num.Push(rndnums);
            //}
            //foreach (var i in  stack_num)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\nSortStack\n");

            //SortStack(stack_num);
            //foreach (var i in stack_num)
            //{
            //    Console.WriteLine(i);
            //}

            //static void SortStack(Stack<int> stack)
            //{
            //    Stack<int> New_Stack = new Stack<int>();
            //    while (stack.Count > 0)
            //    {
            //        int s = stack.Pop();
            //        while (New_Stack.Count > 0 && New_Stack.Peek() > s)
            //        {
            //            stack.Push(New_Stack.Pop());
            //        }
            //        New_Stack.Push(s);
            //    }
            //    while (New_Stack.Count > 0)
            //    {
            //        stack.Push(New_Stack.Pop());
            //    }


            //-----------------------------------------------

            //SortIList

            Random rnd5= new Random();
            IList<int>ilist_num= new List<int>(5);
            for (int i = 0; i < 5; i++)
            {
                int rnd5nums = rnd5.Next(-10, 20);
                ilist_num.Add(rnd5nums);
            }
            foreach (int i in ilist_num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nSorted IList\n");
            SortIList(ilist_num);
            foreach (int i in ilist_num)
            {
                Console.WriteLine(i);
            }
            void SortIList(IList<int> myList)
            {
                int n = myList.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (myList[j] > myList[j + 1])
                        {
                            int s = myList[j];
                            myList[j] = myList[j + 1];
                            myList[j + 1] = s;
                        }
                    }
                }
            }
        }
    }
}