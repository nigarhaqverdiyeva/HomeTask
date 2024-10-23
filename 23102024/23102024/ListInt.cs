namespace _23102024;
public class ListInt
{
    private int[] array;
    private int size;

    public ListInt()
    {
        array = new int[10]; 
        size = 0;
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= size)
                return 0;
            return array[index];
        }
        set
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            array[index] = value;
        }
    }
        public void Add(int num)
    {
        if (size >= array.Length)
        {
            int newSize = array.Length * 2; 
            int[] newArray = new int[newSize];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i]; 
            }
            array = newArray; 
        }

        array[size] = num; 
        size++; 
    }

    public void Add(params int[] nums)
    {
        foreach (var num in nums)
        {
            Add(num); 
        }
    }
     public bool Contains(int num)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] == num)
                return true;
        }
        return false;
    }

    public int Pop()
    {
        if (size == 0)
            return 0; 

        size--;
        return array[size];
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < size; i++)
        {
            result += array[i] + " ";
        }
        return result.Trim();
    }

    public int IndexOf(int num)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] == num)
                return i;
        }
        return -1;
    }

    public int LastIndexOf(int num)
    {
        for (int i = size - 1; i >= 0; i--)
        {
            if (array[i] == num)
                return i;
        }
        return -1; 
    }
    public void Insert(int num, int index)
    {
        if (index < 0 || index > size)
            return; 

        if (size >= array.Length)
        {
            int newSize = array.Length * 2; 
            int[] newArray = new int[newSize];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray; 
        }

        for (int i = size; i > index; i--)
        {
            array[i] = array[i - 1];
        }

        array[index] = num; 
        size++; 
    }
    public float Average()
    {
        if (size == 0)
        {
            return 0; 
        }
        return (float)Sum() / size;
    }
}



