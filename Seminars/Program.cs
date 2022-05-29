using static System.Console;

namespace Seminars
{
    class Program
    {
        static void Main()
        {
            WriteLine(new string('-', 45) + "Практикум по Linq" + new string('-', 45));
            LinqProgram.LinqMain();
            WriteLine(new string('-', 45) + "Листы и словари" + new string('-', 45));
            ListsProgram.ListsMain();
            WriteLine(new string('-', 45) + "Структуры данных" + new string('-', 45));
            StructProgram.StructMain();
        }
    }
}
