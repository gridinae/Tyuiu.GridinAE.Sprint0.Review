using Tyuiu.GridinAE.Sprint0.TaskReview.V0.Lib;
Console.Title = "Спринт #0 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #0                                                            *");
Console.WriteLine("* Тема: Спринт ревью #0                                                *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #0                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, принимает от пользователя целочисленные значения *");
Console.WriteLine("* x, y, z и печатает значение выражения (x + y + z) * 5 на экране.     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calc(x, y, z));

Console.ReadKey();