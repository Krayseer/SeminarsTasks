namespace Seminars
{
    class StructFirst
    {
        public List<int> firstTree = new() { 5, 6, 7, 9 };
        public List<int> secondTree = new() { 1, 2, 3, 8 };

        public List<int> FirstMain() => firstTree
            .Concat(secondTree)
            .Where(x => x != -1)
            .OrderBy(x => x)
            .ToList();
    }
}
