string [] array = new string[4];
void FillArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.WriteLine(String.Join(", ", array));
}
int ArrayLength(string[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
     string text = array[i]; int length = text.Length;
     if(length <= 3)
     {
        count +=  1;
     }   
     
    }
    return count;
}
FillArray(array);
ArrayLength(array);
int length = ArrayLength(array);

string[]newarray = new string[length];
void FillNewArray(string[]newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
        string text = array[i]; int length = text.Length;
        if(length<=3)
        {
            newarray[i]=array[i];
        }
    }
    Console.WriteLine(String.Join(", ", newarray));
}

FillNewArray(newarray);