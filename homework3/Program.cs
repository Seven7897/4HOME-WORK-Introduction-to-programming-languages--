
Console.WriteLine("Массив из восьми элементов , для подтверждения нажмите цифру : 8 ");
int number = Convert.ToInt32(Console.ReadLine());
void FillArray (int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < collection.Length)
    {
        collection[index] = new Random().Next(1,20);
        index++;
    }
}


if (number < 8 || number > 8)
{
    Console.WriteLine("Вы не подтвердили , повторите попытку ");
    return;
}
int[] array = new int[number];

FillArray(array);



Console.WriteLine($"[{String.Join(";",array)}]");