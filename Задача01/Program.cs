/*
Задача 1: 
Определите, является ли число степенью двойки:

N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”
*/

int Prompt (string massege)
{
    Console.WriteLine(massege);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


    bool PowerTwq(int a)
    {
        if (a == 2) 
        {
        return true;
        }

        else if (a % 2 == 0) 
        {
            return PowerTwq(a / 2);
        }
        else return false;
        
    }

int N = Prompt("Введите число N: ");
System.Console.WriteLine();
if (PowerTwq(N)) Console.WriteLine($"{N} -> Является степенью двойки"); 
else Console.WriteLine($"{N} -> Не является степенью двойки"); 

