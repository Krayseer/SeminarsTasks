namespace Seminars
{
    class ListsFourth
    {
        public readonly string testString = "acgagfa";

        public int FindCount()
        {
            var list = new List<string>();
            var hashSet = new HashSet<int>();
            var currElement = "";
            var currNumber = 0;
            for (var i = 0; i < testString.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        currNumber = 1;
                        break;
                    case 2:
                        currNumber = 2;
                        break;
                    case 3:
                        currNumber = 3;
                        break;

                }
                for(var j = currNumber; j < testString.Length; j++)
                {
                    switch (i)
                    {
                        case 0:
                            list.Add(testString[j].ToString());
                            break;
                        case 1:
                            currElement = (testString[j - 1] + testString[j]).ToString();
                            list.Add(currElement);
                            break;
                        case 2:
                            currElement = (testString[j - 2] + testString[j - 1] + testString[j]).ToString();
                            list.Add(currElement);
                            break;
                        case 3:
                            list.Add(testString);
                            break;
                    }
                }
            }
            list
                .ForEach(item => hashSet.Add(item.GetHashCode()));
            return hashSet
                .Distinct()
                .Count();
        }
    }
}
