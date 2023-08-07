Console.WriteLine("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число:");
int num2 = int.Parse(Console.ReadLine());
 if(num1>num2)
 {
    Console.Write($"Наибольшим числом среди чисел {num1}, {num2} является { num1}, наименьшим {num2} ");
 }
 else
{
    Console.Write($"Наибольшим числом среди чисел {num1}, {num2} является { num2}, наименьшим {num1} ");
}