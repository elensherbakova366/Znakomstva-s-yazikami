// Написать программу, которая принимает на вход координаты 2-х точек и находит
//  расстояние между ними в 3 д пространстве А(3,6,8) В(2,1,-7)=15,84 и 
//  А(7,-5,0) В(1,-1,9)=11,53
double Distans (int xa, int ya, int za, int xb, int yb, int zb)
{
double d = Math.Sqrt(Math.Pow(xb-xa)+Math.Pow(yb-ya)+Math.Pow(zb-za));
return d;
} 
int x1 = int.Parse(Console.ReadLine());  //Что ему опять не нравится?
int y1 = int.Parse(Console.ReadLine()); // Я сделала все точь в точь, как на семинаре
int x2 = int.Parse(Console.ReadLine()); // только при вызове функции добавила числа но 
int y2 = int.Parse(Console.ReadLine()); // я и без них делала - все равно ошибка
int z1 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double result = Distans(3, 6, 8, 2, 1, -7);
Console.WriteLine(result);