                       //Найти все четные числа от 1 до N
int count = 1;
int N = 5;
while (count<N)
{
    if (count%2==0)
    {
        Console.WriteLine(count);
        Console.WriteLine("Число четное"); 
        count++;
    }   
    else
    {
        Console.WriteLine("Число нечетное");  
    }
}
