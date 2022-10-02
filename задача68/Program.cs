// напишите программу вычисления фунции Аккермана
// с помощью рекурсии.даны два неотрицательных числа
// m и n 
// m = 3; n = 2 -> A(m,n) = 29


Console.Write("введите число N:");
Console.Write("введите число M:");
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int M, int N)
{
    //базовый случай
    if(M == 0) return N+1;
    if(M != 0 && N==0) return AkkermanFunction(M-1,1);
    if(M > 0 && N >0) return AkkermanFunction(M-1, AkkermanFunction (M, N-1));
    return AkkermanFunction(M,N);
}

Console.WriteLine(AkkermanFunction(M,N));
