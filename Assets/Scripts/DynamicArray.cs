[System.Serializable]
public class DynamicArray<T>
{
    public int count = 0;
    public int capacity = 10;
    public T[] array;

    public DynamicArray()
    {
        array = new T[capacity];
    }

    public void Add(T newElement)
    {
        if (count >= capacity) Resize();

        array[count++] = newElement;
        count++;
    }

    public void Resize()
    {
        capacity *= 2;

        T[] temp = array;
        array = new T[count];

        for(int i = 0; i < temp.Length; i++)
        {
            array[i] = temp[i];
        }

    }
}
