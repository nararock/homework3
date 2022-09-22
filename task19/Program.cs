// Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int invertedNumber = 0;
int testNumber = number;
while (testNumber != 0){
    invertedNumber = invertedNumber * 10 + testNumber % 10;
    testNumber /= 10;
}
if (invertedNumber == number) Console.WriteLine("Да");
else Console.WriteLine("Нет");