namespace Dictionary_Practise;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> dict = new Dictionary<int, int> {{1,2}, {3, 4}};

        IList<IList<string>> grouped_anagrams = new List<IList<string>>();


        dict.Add(5, 4);
        dict.Remove(2);
        
        int x = 2;

        string num = x.ToString();

        char[] letters = new char[26];
    


        Console.WriteLine(dict.ContainsKey(5));

    }
}
