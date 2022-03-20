int[] array = new int[13];
int a = int.MinValue;

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    int number = rnd.Next(0, 30);
    array[i] = number;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
 if (array[i] > a)
    {
        a = array[i];
    }
}
Console.Write($"Max = {a} ");