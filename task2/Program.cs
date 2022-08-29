//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("введите пятизначное число:   ");
bool palindrome = true;
int x = int.Parse(Console.ReadLine());
int c = x.ToString().Length - 1;
string b = x.ToString();
for (int i = 0; i < c; i++)
{
    if (b[i] != b[c - i])
        palindrome = false;
        if (palindrome == true)
            Console.Write("Число является палиндромом");
        else Console.Write("Число не является палиндромом");
    Console.ReadKey();
}    


