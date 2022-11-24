/*  Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длина которых меньше либо равна 3 символа.
*/

Main();

void Main()
{
    Console.Clear();
    string[] array = { "hello", "2", "world", ":-)" };
    int length = 3;
    string[] result = FindCellsSpecifiedLength(array, length);
    PrintArray(result);
}

string[] FindCellsSpecifiedLength(string[] array, int length)
{
    int count = 0;
    for (int i=0; i< array.Length; i++)
    {
        if (array[i].Length <= length) count++;
    }
    
    string[] result = new string[count];
    count = 0;
    
    for (int i=0; i< array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i] + "]");
        }
    }
    Console.WriteLine();
}