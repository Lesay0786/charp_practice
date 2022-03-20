object[] array = new object[3] {32, 'A', "Hello"};

foreach (var item in array)
{
    Console.WriteLine(item);
}
Console.WriteLine();

int number = Convert.ToInt32(array[0]);
number += 10;
array[0] = Convert.ToString(number);
string str = ", gyes!";
array[2] += str;

foreach (var newArray in array)
{
    Console.WriteLine(newArray);
}
Console.ReadLine();