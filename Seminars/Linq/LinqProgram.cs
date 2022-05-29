using static System.Console;

namespace Seminars
{
    class LinqProgram
    {
        public static void LinqMain()
        {
            var first = new LinqFirst();
            WriteLine("Первое задание");
            WriteLine("Массив: " + string.Join(" ", first.mas));
            WriteLine("Сдвиг на 2: " + string.Join(" ", first.FirstMain(2)));
            WriteLine("Сдвиг на 3: " + string.Join(" ", first.FirstMain(3)) + "\n");

            var second = new LinqSecond();
            WriteLine("Второе задание");
            WriteLine("Окрестности для: [(0, 0), (0, 1)]");
            for(int i = 0; i < 18; i++)
            {
                Write("({0}, {1})" + " ", second.SecondMain()[i].X, second.SecondMain()[i].Y);
                if (i % 6 == 0 && i != 0) WriteLine();
            }

            var third = new LinqThird();
            WriteLine("\n\nТретее задание");
            WriteLine("Тестируемые строки: " + string.Join(" ", third.text));
            WriteLine("Ответ: " + string.Join(" ", third.ThirdMain()));
        }
    }
}
