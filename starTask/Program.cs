// Напишите программу, которая на вход принимает радиус круга 
//и находит его площадь округленную до целого числа,
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга
Console.Write("Радиус круга R = ");
int radius = Convert.ToInt32(Console.ReadLine());
int area = (int)Math.Round(Math.PI * Math.Pow(radius, 2), 0);
int maxNumber = getMax(area);
Console.WriteLine(maxNumber);


int getMax(int number){
    int max = 0;
    while (number != 0){
        if (max < (number % 10)){
            max = number % 10;
        }
        number /= 10;
    }
    return max;
}