using static System.Console;

namespace Seminars
{
    class ListsProgram
    {
        public static void ListsMain()
        {
            var exercise = new ListsFourth();
            WriteLine("Четвертое задание");
            WriteLine("Для строки {0} количество различных подстрок: {1} ", exercise.testString, exercise.FindCount());
        }
    }
}
