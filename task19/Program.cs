// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// строки и массивы использовать нельзя

Console.WriteLine("Введите пятизначное число");
int poly = Convert.ToInt32(Console.ReadLine());
if (poly > 9999 && poly < 100000){
Console.WriteLine(poly);
int i, n1, n2, n3, n4, n5;
i = poly/10;
int NumbPoly(int arg) {
    int result = arg%10;
    return result;
}
n1 = NumbPoly(poly);
n2 = NumbPoly(i);
n3 = NumbPoly(i/10);
n4 = NumbPoly(i/100);
n5 = NumbPoly(i/1000);

if (n1 == n5 || n2 == n4) {
    Console.WriteLine("Число палиндром");
}
else {
    Console.WriteLine("Число не палиндром");
}

}

else {
Console.WriteLine("Вы ввели не пятизначное число");
}
