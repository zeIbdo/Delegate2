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
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list[0]);
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
            Console.WriteLine(list2.Capacity);
            Console.WriteLine(list2.Count);
        }
    }
}
