Console.WriteLine("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
 if(num1>max)
 {
    max=num1;
 }
if(num2>max)
{
    max=num2;
}
if(num3> max)
{
    max=num3;
}
Console.Write($"Максимальным числом среди чисел {num1}, {num2}, {num3} является { max} ");


