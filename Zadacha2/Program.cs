int numberA = 28;
int numberB = 35;
int numberC = 3;
int max = numberA;
 if (numberA > numberB)
 {
    Console.WriteLine (numberA = max);
    Console.WriteLine ("Число большее");
 }
 else if (numberC > numberB)
 {
    Console.WriteLine (numberC = max);
    Console.WriteLine ("Число большее");
 }
 else if (numberA > numberC)
 {
    Console.WriteLine (numberA = max);
    Console.WriteLine ("Число большее");
 }
 else
 {
    Console.WriteLine (numberC = max);
    Console.WriteLine ("Число большее");
 }
 //Почему-то он всегда выдает numberA = max
 //Я хотела решить эту задачку с помощью логических операций по той ссылке,которую
 //ты скинул, я ничего там не поняла. Мне что именно надо было использовать для своей задачи?
 //Операция "больше чем". Сравнивает два операнда и возвращает true, если первый операнд больше второго,
  //иначе возвращает false:
//int a = 10;
//int b = 4;
//bool c = a > b;     // true
//bool d = a > 25;    // false
//И еще можешь сказать, что значит "возвращает false"?Я прочитала в интернете, но не поняла


 