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
