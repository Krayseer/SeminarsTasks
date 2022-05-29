namespace Seminars
{
    class LinqThird
    {
        public bool isCorrectValue = false;

        public List<string> text = new()
        {
            "aabaa",
            "abcab",
            "bbbbb",
            "abjja"
        };

        public List<string> ThirdMain()
        {
            var result = new List<string>();
            text
                .ForEach(str =>
                {
                    var dict = new Dictionary<char, int>();
                    foreach (var letter in str)
                        if (dict.ContainsKey(letter))
                            dict[letter]++;
                        else
                            dict.Add(letter, 0);
                    foreach (var element in dict)
                        if (element.Value > 1)
                            isCorrectValue = true;
                    if (!isCorrectValue)
                        result.Add(str);
                    isCorrectValue = false;
                });
            return result;
        }
    }
}
