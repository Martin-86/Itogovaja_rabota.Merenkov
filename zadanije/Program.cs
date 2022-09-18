string[] array = {"Hello", "2", "world", ":-)"};

int Method(int count)
{
    int arrayindex = 0;
    int result = 0;
    while (arrayindex < count)
    {
        if (array[arrayindex].Length <= 3)           
        {
            result++;
        }
        arrayindex++;
    }
    return result;

}

int res = Method(array.Length);

if (res < 1)
{
   Console.WriteLine("Нет искомых элементов ");
}

void FillArray(string[] elemetsless4)
{
    int count = array.Length;
    int arrayindex = 0;
    int elementless4index = 0;
    while(arrayindex < count)
    {
        if (array[arrayindex].Length <= 3)           
        {
            elemetsless4[elementless4index] = array[arrayindex];
            elementless4index++;
            arrayindex++;
        }
        else
        {
            arrayindex++;
        }
        
    }
}

void PrintArray(string[] elementless4)
{
    int elementless4index = 0;
    while(elementless4index < res)
    {
        Console.Write(elementless4[elementless4index] + "  ");
        elementless4index++;
    }
}


string[] elemetsless4 = new string[res];
FillArray(elemetsless4);
PrintArray(elemetsless4);