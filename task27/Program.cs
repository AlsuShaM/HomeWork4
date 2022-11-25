// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;
int result = 0;
while(n > 0)
{
    result = result + n % 10;
    n = n / 10;        
}
Console.WriteLine(result);
