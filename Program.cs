string [] CreatInputArray (int size)
{
    string [] array = new string [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write ($"Input element ({size-i} attempts left): ");
        string element = Console.ReadLine();
        array [i] = element;
    }
    return array;
}

void ShowArray (string [] array)
{   
    if (array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write ($"\"{array[i]}\", ");
        }
        Console.WriteLine("\b\b]");
    }
    else
    Console.Write("[]");
}

string [] CreatArray3simbol (string [] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length < 4)
        {
            size += 1;
        }
    }

    string [] newArray = new string [size];
    int series = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length < 4)
        {
            for (int j = 0 + series; j < size; j++)
            {
                newArray [j] = array [i];
            }
            series += 1;
        }
    }
    return newArray;
}

Console.Write ("Нow many elements of array you enter: ");

int num;
while (true)
{
    string elem = Console.ReadLine();

    if (int.TryParse(elem, out num) && num > 0)
        break;
    else
    {
        Console.WriteLine("[ERROR]: Invalid input");
        Console.Write("Retry write number greater than zero: ");
    }
}

string [] inputArray = CreatInputArray (num);

Console.Write("Input array: ");
ShowArray (inputArray);

string [] outputArray = CreatArray3simbol (inputArray);

Console.Write("Output array: ");
ShowArray (outputArray);