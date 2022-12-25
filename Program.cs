// Задача 19
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число");
string num11=Console.ReadLine()!;
if (num11.Length==5)
{
    bool result=true;
    for(int i=0; i<num11.Length/2; i++)
    {
        if(num11[i]!=num11[num11.Length-1-i])
        {
            result=false;
            break;
        }
    }
    if(result==true)
    {
    Console.WriteLine("Число является полиндромом"); 
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}