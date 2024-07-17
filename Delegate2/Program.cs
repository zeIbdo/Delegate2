namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(3);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(3);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=================================");
            CustomList<int> list2 = new CustomList<int>(3);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(5);
            list2.Add(5);
            list2.Add(5);
            list2.Add(5);
            list2.Remove(5);
            list2.RemoveAll(x => x == 5);
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(list2.Capacity);
            //Console.WriteLine(list2.Count);
        }
    }
}
