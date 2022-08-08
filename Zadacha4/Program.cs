int count = 0;
int N = max;
while (count<N)
{
    if (N/2)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Число четное");
    }
     else
    {
       int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Число не четное");  
    }
    count+=1;
}
//Пишет  Имя
// "max" не существует в текущем контексте. (5,9): error CS0029: Не 
//удается неявно преобразовать тип "int" в "bool". 
//Ошибка сборки. Устраните ошибки сборки и повторите попытку.
//не пойму, что ему надо, что вместо max надо поставить тоже не пойму. Подскажите, пожалуйста