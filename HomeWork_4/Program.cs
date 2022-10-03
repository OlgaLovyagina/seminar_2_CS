
#region Task25 
/// <summary>
///на вход два натуральных числа (A и B) и возводит число A в степень B.
/// </summary>

void Task25()
{
    Console.WriteLine("Введите 1-е число: ");
    Console.Write("А =  ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    Console.Write("B = ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = num * i;
    }
    Console.WriteLine("Число А в степени В = " + result);
}
#endregion

#region Task27
/// <summary>
///принимает на вход число и выдаёт сумму цифр в числе.
/// </summary>
/// 
void Task27()
{
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int current = Math.Abs(number);

        int sum = 0;
        int a = NumberDigits(current);
        for (int i = 0; i < a; i++)
        {
            sum = sum + current % 10;
            current = current / 10;
        }
        Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
    }



    int NumberDigits(int current) // считает количество цифр в числе
    {
        int i = 0;

        while (current > 0)
        {
            current /= 10;
            i++;
        }
        return i;
    }
}

// В предыдущем варианте использовала метод, но как-то выглядит сложно,
// посмотрела разбор ДЗ, добавила ваше решение
void Task27_1()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0)
    {
       sum += number% 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}

#endregion

#region Task29 
/// <summary>
///Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит 
///отсортированный по модулю массив.
/// </summary>
/// 
void Task29()
{

    int size = 8;
    int[] numbers = new int[size];
    Console.WriteLine("Размер массива: " + size);

    FillArrey(numbers); //  вызов метода на заполнения массива
    
    PrintArrey(numbers); //  вызов метода на вывод массива



    void FillArrey(int[] num) //  метод на заполнения массива
    {
        Random random = new Random();
        for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
        {
            num[i] = random.Next(-1000, 1001);
        }
        
    }

    void PrintArrey(int[] num) //  метод на вывод массива
    {
        num = num.OrderBy(x => Math.Abs(x)).ToArray(); // сортировка по модулю

        for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
        {
            Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
        }
        Console.WriteLine();

    }

}

#endregion

Task25();
//Task27();
//Task27_1();
//Task29();