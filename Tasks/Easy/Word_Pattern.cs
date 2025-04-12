namespace Tasks.Tasks.Easy;

public class Word_Pattern
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var split = s.Split();

        if (pattern.Length != split.Length)
        {
            return false;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.ContainsKey(pattern[i]))
            {
                if (dict[pattern[i]] != split[i])
                {
                    return false;
                }
            } 
            else
            {
                if (dict.ContainsValue(split[i]))
                {
                    return false;
                }
                dict[pattern[i]] = split[i];
            }
        }
        return true;
    }
}