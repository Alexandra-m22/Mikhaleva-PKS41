{
    Console.WriteLine("Введите число: ");
    int value = Convert.ToInt32(Console.ReadLine());

    int num1 = 5;
    int num2 = 10;


    if (value > num1 && value < num2)
        Console.WriteLine("Число больше 5 и меньше 10");
    else
        Console.WriteLine("Неизвестное число");
}
