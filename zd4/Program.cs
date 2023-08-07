Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());
int A = 2;
while(A<=N)
{
    System.Console.Write(A);
if(A < N-1)
{
    Console.Write(", ");
}
 A=A+2;
}
