namespace Seminars
{
    public class LinqFirst
    {
        public int[] mas = new[] { 1, 2, 3, 4, 5, 6 };

        public int[] FirstMain(int k)
        {
            var items = mas.Take(k % mas.Length);
            return mas
                .Skip(k % mas.Length)
                .Concat(items)
                .ToArray();
        }
    }
}
