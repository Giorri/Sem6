// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindPoint00(double numB1, double numK1, double numB2, double numK2) // Поиск X_0
{
    double x0 = (numB2 - numB1) / (numK1 - numK2);
    return x0;
}
double FindPointY0(double x0, double numK1, double numB1) // Поиск Y_0
{
    double y0 = (numK1 * x0) + numB1;
    return y0;
}
Console.WriteLine("Задайте переменные первой прямой y = k1 * x + b1: ");
Console.Write("Введите k1: ");
int line1_tg = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int line1_var = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте переменные второй прямой y = k2 * x + b2:");
Console.Write("Введите k2: ");
int line2_tg = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int line2_var = int.Parse(Console.ReadLine());
if (line1_tg == line2_tg) Console.WriteLine("Прямые параллельные и никогда не пересекаются.");
else
{
    double Poisk00 = FindPoint00(line1_var, line1_tg, line2_var, line2_tg); 
    double PoiskY0 = FindPointY0(Poisk00, line1_tg, line1_var);
    Console.WriteLine("Точка пересечения: ");
    Console.Write("(");
    Console.Write(String.Join("; ", Poisk00, PoiskY0));
    Console.Write(")");
}