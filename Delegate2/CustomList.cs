using System.Collections;

namespace Delegate2;

public class CustomList<T>:IEnumerable<T>
{
    T[] arr;
    public CustomList()
    {
        arr = new T[0];
    }
    public CustomList(int capacity)
    {
        arr = new T[capacity];
        Capacity = capacity;
    }
    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
    public int Count { get; set; }
    public int Capacity { get; set; }
    
    public void Add(T item)
    {
        if (Capacity == 0)
        {
            Capacity = 4;
            Array.Resize(ref arr, Capacity);
            arr[0] = item;
            Count++;
        }
        else if (Count < Capacity)
        {
            arr[Count] = item;
            Count++;
        }
        else
        {
            Capacity *= 2;
            Array.Resize(ref arr, Capacity);
            arr[Count]=item;
            Count++;
        }
    }
    public T? Find(Predicate<T> predicate)
    {
        foreach (T item in arr)
        {
            if(predicate(item)) return item;
        }
        return default(T);
    }
    public CustomList<T> FindAll(Predicate<T> predicate)
    {
        CustomList<T> temp = new CustomList<T>();
        foreach (T item in arr)
        {
            if (predicate(item))
            {
                temp.Add(item);
            }
        }
        return temp;
    }
    public bool Remove(T item)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(item))
            {
                for(int j = i ;j< arr.Length-1; j++)
                {
                    arr[j] = arr[j+1];
                }
                arr[Count-1] = default(T);
                Count--;
                
                return true;
            }
        }
        return false;
    }
    public int RemoveAll(Predicate<T> predicate)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (predicate(arr[i]))
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[Count - 1] = default(T);
                Count--;
                count++;
                i--;
            }
        }
                return count;
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach(var item in arr)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
