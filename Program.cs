int size = 6;
int n = 3;
string [] arrayOne = new string[size];

Console.WriteLine("Введите символы через Enter, которые будут являтся строковыми элементами массива");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();

if (GetSizeOfSecondArray(arrayOne) == 0)
{
    Console.WriteLine("Размер всех элементов строкого массива больше для переноса в новый массив нет ");
}
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);

}


void FillArray (string []arr) //Заполнение первого массива
{
    for ( int i=0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }

}

void PrintArray(string[] arr) //Вывод в консоль массива
{
    Console.Write("[ ");
    for ( int i=0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]"); 
}

int GetSizeOfSecondArray(string[] arr) //Определение размера второго массива
{
    int secondSize = 0;
    for ( int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr) //Создание и заполнение второго массива при условии n
{
    string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}   




