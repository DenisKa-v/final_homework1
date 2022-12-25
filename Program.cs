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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

void CreatArray3simbol (string [] array)
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
    ShowArray (newArray);
    //return array;
}

Console.Write ("Нow many elements of array you enter: ");
int el = Convert.ToInt32 (Console.ReadLine());

string [] inputArray = CreatInputArray (el);

Console.Write("Input array: ");
ShowArray (inputArray);

Console.Write("Output array: ");
CreatArray3simbol (inputArray);