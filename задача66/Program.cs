// задайте значения M и N. напишите программу
// которая найдет сумму натуральных элементов 
// в промежутке от M до N
// M=1 N=15 ->120

Console.Write("введите число N:");
Console.Write("введите число M:");
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());

int PrintSum(int start, int end)
{
    //базовый случай
    if(start == end) return start;// start- int, а метод возвращает string
    //рекурсивный случай
    return (start + PrintSum(start + 1, end));
}
Console.WriteLine(PrintSum(M,N));//сначала вводим end




