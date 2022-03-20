short a = 102;
object o = a;
sbyte a2 = (sbyte)(short)o;
Console.WriteLine($"{a2}, {a2.GetType()}");