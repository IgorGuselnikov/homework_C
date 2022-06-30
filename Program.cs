// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
    Console.WriteLine("Максимальное число из двух:" + firstNumber);
    Console.WriteLine("Минимальное число из двух:" + secondNumber);
}
else if (firstNumber < secondNumber)
{
    max = secondNumber;
    min = firstNumber;
    Console.WriteLine("Максимальное число из двух:" + secondNumber);
    Console.WriteLine("Минимальное число из двух:" + firstNumber);
}
else
{
    Console.WriteLine("Введенные числа равны, необходимо обязательно вводить разные числа!");    
}*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    max = firstNumber;
    Console.WriteLine("Максимальное число из трех:" + firstNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    max = secondNumber;
    Console.WriteLine("Максимальное число из трех:" + secondNumber);
}
else
{
    max = thirdNumber;
    Console.WriteLine("Максимальное число из трех:" + thirdNumber);    
}*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


if (number%2 == 0)
{
    Console.WriteLine("Число " + number + " является четным");
}
else 
{
    Console.WriteLine("Число " + number + " не является четным");
}



