Console.Clear();

// string[] stringArray = {"hello", "2", "world",":-)"};
// string[] stringArray = {"Russia", "Denmark", "Kazan"};
// string[] stringArray = {"1234", "1567", "-2", "computer science"};

string[] CreateUserStringArray(int length)
{
    string[] array = new string[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write("\nВведите элемент массива: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.Write("\nВы не ввели значение. Введите элемент массива: ");
            value = Console.ReadLine();
        }
        if(value != null) array[i] = value;
    }
    return array;
}

string[] CreateStringArray(string[] array, int numberSymbol = 3)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= numberSymbol) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= numberSymbol)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array)
{
    Console.Write("\nСозданный массив: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}