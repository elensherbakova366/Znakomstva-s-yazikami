Console.WriteLine ("Введите числа 5,2,-9");
int numberA = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите числа 7,10,-3");
int numberB = int.Parse (Console.ReadLine());
int max = numberA;
Console.WriteLine("Сравним числа:");
if (numberA > numberB)
{   Console.WriteLine (numberA = max);
    Console.WriteLine ("Число большее");
}
else
{
    Console.WriteLine(numberB = max);
    Console.WriteLine ("Число меньшее");
}
// я хотела решить задачку таким образом, что переменные не надо вводить, 
//а чтоб они уже были заданы, но как записать это, так и не сообразила. Может 
//подскажите в коммнтарии? 