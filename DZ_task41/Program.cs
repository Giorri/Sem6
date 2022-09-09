// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] VvodChisel(int size) // Массив ввода базы данных;
{
    int[] MassivChisel = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} значение: ");
        MassivChisel[i] = int.Parse(Console.ReadLine());
    }
    return MassivChisel;
}
int[] ChetPositivNumber(int[] MassivChisel) // Массив подсчета положительных элементов;
{
    int[] sum = { 0 }; // !!!! Здесь, как и в прошлом ДЗ пытаюсь указать просто в 17 строке написать: int sum = 0; в 20: sum++; Но выдает тогда ошибку error CS0029 следующего плана: Не удается неявно преобразовать тип "int" в "int[]"
    for (int i = 0; i < MassivChisel.Length; i++)
    {
        if (MassivChisel[i] > 0) sum[0]++;
    }
    return sum;
}
// Задаем размерность M нашегo;
Console.Write("Задайте желаемую длину массива: ");
int dlinaMassiva = int.Parse(Console.ReadLine());
// Вызываем функцию для создания и заполнения массива;
if (dlinaMassiva > 0)
{
    int[] MyVvodChisel = VvodChisel(dlinaMassiva);
    Console.WriteLine("Ваш массив данных: ");
    Console.Write(string.Join(" ", MyVvodChisel));
    // Вызываем  функцию подсчета положительных чисел;
    int[] SumPositivElements = ChetPositivNumber(MyVvodChisel);
    Console.WriteLine();
    Console.Write("Положительных элементов : ");
    Console.WriteLine(String.Join(" ", SumPositivElements));
}
else
{
    Console.WriteLine("Ваш ввод не корректен");
}