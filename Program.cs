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

Console.Write ("Нow many elements of array you enter: ");
int el = Convert.ToInt32 (Console.ReadLine());

string [] inputArray = CreatInputArray (el);