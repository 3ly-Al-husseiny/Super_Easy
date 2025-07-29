public class Solution {
    public int MostWordsFound(string[] sentences) {
        int MaxWords = 0;
        for(int i = 0 ; i < sentences.Length; i++)
        {
            string sentence = sentences[i];
            if(MaxWords < sentence.Split(' ').Length)
            MaxWords = sentence.Split(' ').Length;
        }
        return MaxWords;
    }
}