namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("İstanbul");

        MyList<string> list2 = new MyList<string>();
        list2.Add("İstanbul");
        list2.Add("İstanbul");
        list2.Add("İstanbul");

        Console.WriteLine(list2.Count);
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
