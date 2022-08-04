//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Cube(int[] array){
  int a = 0;
  int ln = array.Length;
  while (a <  ln){
    array[a] = Convert.ToInt32(Math.Pow(a, 3));
    a++;
  }
}
void PrintCube(int[] array){
  int b = array.Length;
  int i = 0;
  while(i < b){
    Console.Write(array[i]+ " ");
    i++;
  }
} 

int[] cube = new int[n+1];
Cube(cube);
PrintCube(cube);