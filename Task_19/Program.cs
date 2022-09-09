/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

void Palindrop(int num)
{

int a = num;
int turn = 0;

while (num > 0)
    {
       int dig = num % 10;
       turn = turn * 10 + dig;
       num = num / 10;
    }

if (turn == a)
    
    Console.WriteLine($"Число {a} являеться палиндромом!");

else
    
    Console.WriteLine($"Число {a} не являеться палиндром!");
}

Palindrop(num);


/*
Console.Write("Введите пятизначное число: ");
uint a = uint.Parse(Console.ReadLine());
uint b = a;
var col = new List<uint>();
while (b > 0)
    {
         col.Add(b % 10);
        b = b / 10;
    }
    b = 0;
    col.Reverse();
    for(int mcol = 0; mcol < col.Count; mcol++)
        b = b + col[mcol] * (uint)Math.Pow(10, mcol);
    if (a == b)
        Console.WriteLine("Это палиндром!");
                
    else
        Console.WriteLine("Это не палиндром!");
*/
        
