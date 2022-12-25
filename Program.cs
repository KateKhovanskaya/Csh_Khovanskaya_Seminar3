// Задача 19
// Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
// Console.WriteLine("Введите пятизначное число");
// string num11=Console.ReadLine()!;
// if (num11.Length==5)
// {
//     bool result=true;
//     for(int i=0; i<num11.Length/2; i++)
//     {
//         if(num11[i]!=num11[num11.Length-1-i])
//         {
//             result=false;
//             break;
//         }
//     }
//     if(result==true)
//     {
//     Console.WriteLine("Число является полиндромом"); 
//     }
//     else
//     {
//         Console.WriteLine("Число не является полиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Число не является пятизначным");
// }

//Задача 21
// Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
// Console.WriteLine("Введите координаты точки А ");
// Console.Write("x1= ");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.Write("y1= ");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.Write("z1= ");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B ");
// Console.Write("x2= ");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.Write("y2= ");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.Write("z2= ");
// int z2=Convert.ToInt32(Console.ReadLine());
// double distance=Math.Round((Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2))),2);
// Console.WriteLine($"Расстояние между точками: {distance}");

// Задача 23
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число N");
int n=Convert.ToInt32(Console.ReadLine());
if(n>0){
for(int i=1; i<=n; i++){
    Console.Write(Math.Pow(i,3)+" ");
}
}
else{
for(int i=1; i>=n; i--){
    Console.Write(Math.Pow(i,3)+" ");
}
}