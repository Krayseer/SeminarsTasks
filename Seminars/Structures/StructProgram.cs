using static System.Console;

namespace Seminars
{
    class StructProgram
    {
        public static void StructMain()
        {
            var first = new StructFirst();
            WriteLine("Первое задание");
            WriteLine("Первое дерево: " + string.Join(" ", first.firstTree));
            WriteLine("Второе дерево: " + string.Join(" ", first.secondTree));
            WriteLine("Ответ: " + string.Join(" ", first.FirstMain()));
        }
    }
}
