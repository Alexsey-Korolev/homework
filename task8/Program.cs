Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x < N+1; x++)       
if (x % 2==0)            
Console.Write($"{x},");
