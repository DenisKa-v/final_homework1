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

Console.Write ("Нow many elements of array you enter: ");
int el = Convert.ToInt32 (Console.ReadLine());

string [] inputArray = CreatInputArray (el);

Console.Write("Input array: ");
ShowArray (inputArray);