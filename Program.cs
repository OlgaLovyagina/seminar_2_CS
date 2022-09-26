void Task1() // оборачиваем задачу в метод
{
// Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
Random random = new Random(); //создание объекта типа рандом
int number = random.Next(10, 100); 
Console.WriteLine(number);
int tens = number / 10; // находим десятки в двузначном числе
int ones = number % 10; // находим единицы в двузначном числе
Console.WriteLine(tens);
Console.WriteLine(ones);

if (tens > ones)
{
    Console.Write ("наибольшее: " + tens);
}
else
{
    Console.Write ("наибольшее: " + ones);
}
}
//Task1();


void Task2() // оборачиваем задачу в метод
{
// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.

Random random = new Random(); //создание объекта типа рандом
int number = random.Next(100, 1000); 
Console.WriteLine(number);
int sot = number / 100; // находим сотни в трехзначном числе
int ones = number % 10; // находим единицы в трехзначном числе
Console.WriteLine(sot);
Console.WriteLine(ones);
Console.Write(" " + sot + ones);
// Варианты вывода ответа:
//string c = Convert.ToString(sot) + Convert.ToString(ones);
//Console.WriteLine(c);

//Console.Write(sot);
//Console.Write(ones);

//Console.Write(sot*10 + ones);

}

//Task2();


void Task3() 
{
// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0)
{
    Console.WriteLine("второе введенное число кратно первому ");
}
else 
{
    int ost = num2 % num1;
    Console.WriteLine("второе введенное число не кратно первому. Остаток: " + ost);    
}
}
 
//Вариант вывода
//Console.WriteLine("Число " + num2 + "не кратно числу"+ num1 + "Остаток: " + ost);
//Task3();

void Task4()
{
   //Напишите программу, которая принимает на вход число и проверяет, 
   //кратно ли оно одновременно 7 и 23 
Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) // и
{
    Console.WriteLine($" число { num} кратно 7 и 23 ");
}
else 
{
        Console.WriteLine($" число {num} не кратно 7 и 23");    
}
}
//Task4();


void Task5()
{
//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

Console.WriteLine("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2*num2 || num2 == num1*num1) // или
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");
    // функция возведения в квадрат
    //if(num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
}
//Task5();
// Функция для ввода числа
//int Input()
//{
//    Console.WriteLine("Введите первое число : ");
//    return Convert.ToInt32(Console.ReadLine());
//}


///Семинар 3
///





#region Task17
/// <summary>
/// Напишите программу, которая принимает на вход
///координаты точки(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
///номер четверти плоскости, в которой находится эта точка
/// </summary>

void Task17()
{
 // А здесь только ввод данных и вызов метода, ищет где лежит точка

    Random random = new Random();
    int x = random.Next(-10, 10);
    int y = random.Next(-10, 10);
    Console.WriteLine($"A({ x},{ y})");
    CoordCheck(x, y);
}

void CoordCheck(int x, int y)
    // Метод, который проверяет, где лежит точка
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка лежит в 1-ой четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка лежит во 2-ой четверти ");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 3-ей четверти ");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 4-ой четверти ");
    }
    else
        Console.WriteLine("Точка лежит на одной из осей ");
}
#endregion

#region Task18
/// <summary>
/// Напишите программу, которая по заданному номеру четверти, 
/// показывает диапазон возможных координат точек в этой четверти (x и y).
/// </summary>

void Task18()
{
    Console.WriteLine("Введите номер четверти");
    int number = Convert.ToInt32(Console.ReadLine());
    CheckNam(number);
}

void CheckNam(int number)
{
    if (number == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    if (number == 2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    if (number == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    if (number == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("Вы ввели не номер четверти");
    }
}
#endregion

#region Task21
/// <summary>
///Напишите программу, которая принимает на вход координаты двух точек и
///находит расстояние между ними в 2D пространстве.
/// </summary>
/// 

void Task21()
{
    Console.WriteLine("Введите координаты точки А: ");

    Console.Write("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B: ");
    Console.Write("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());

    int k = bx - ax;
    int m = by - ay;

    double length = Math.Sqrt(k * k + m * m);
    length = Math.Round(length, 2);
    Console.WriteLine($"Длинна {length}");
}

#endregion

#region Task21_1
/// <summary>
///Напишите программу, которая принимает на вход координаты двух точек и
///находит расстояние между ними в 3D пространстве.
/// </summary>
/// 

void Task21_1()
{ 
    Console.WriteLine("Введите координаты точки А: ");

    Console.Write("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int az = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Введите координаты точки B: ");

    Console.Write("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Z: ");
    int bz = Convert.ToInt32(Console.ReadLine());
        

    double length = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay)
        + (bz - az) * (bz - az));
    length = Math.Round(length, 2);
    Console.WriteLine($"Расстояние между точками {length}");
}
#endregion

#region Task19
/// <summary>
///Напишите программу, которая принимает на вход пятизначное число и проверяет,
///является ли оно палиндромом.
/// </summary>


void Task19()
{
    Console.WriteLine("Введите пятизначное целое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int num = n;
    int rev = 0;

    while (n > 0)
    {
        rev = rev * 10 + n % 10;
        n = n / 10;
    }
        if (num == rev)
        {
            Console.WriteLine("Введеное число является полиндромом ");
        }
        else
        {
            Console.WriteLine("Введеное число не является полиндромом ");
        }
}
#endregion

#region Task23
/// <summary>
///Напишите программу, которая принимает на
///вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
/// </summary>
/// 
void Task23()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    Result(num, i);
}

void Result(int num, int i)
    {

        if (num > i)
        {
            while (i <= num)
            {
                Console.WriteLine($"Число  {i}  |  Куб числа = {Math.Pow((i), 3)}");
                i++;
            }
        }
        else
        {
            while (i >= num)
            {
                Console.WriteLine($"Число  {num}  |  Куб числа = {Math.Pow((num), 3)}");
                num++;
            }
        }
    }



  
#endregion

//Task17();
//Task18();
//Task21();
//Task21_1();
//Task19();
Task23();

Console.ReadLine();