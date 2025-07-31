//-----------------------------------------My Solution---------------------------
public class Solution {
    public string ToLowerCase(string s) {
        return s.ToLowerCase();
    }
}

//--------------------Best Solution -------------------

using System.Text;

public class Solution {
    public string ToLowerCase(string s)
    {
        int offset = 'A' - 'a';
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
            if (s[i] >= 'A' && s[i] <= 'Z')
                sb.Append((char)(s[i] - offset));
            else
                sb.Append(s[i]);
        return sb.ToString();
    }
}