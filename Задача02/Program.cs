/*
Задача 2: 
Проверка на простое число:

N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”
*/


int Prompt(string massege)
{
    System.Console.WriteLine(massege);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool PrimeNumber(int number)
{
    for (int i = 2; i <= number; i++)
    {
        if (number / i == 1)
        {
        return true;
        } 
        
        if (number % i == 0)
        {
            return false;
        }
        
    }

    return false;
}
  

int N = Prompt("Введите число N: ");
Console.WriteLine();

if (PrimeNumber(N)) Console.WriteLine($"{N} -> Это простое число");
else Console.WriteLine($"{N} -> Это не простое число");

