public class Solution {
    public int FirstUniqChar(string s) {
        // create Skipped array for the Skipped chars with the size of s.Length
        char[] skippedChars = new char[s.Length];
        int skippedChars_Index = 0;
        int firstNonRepeatedChars_Index = -1;

        for (int i = 0; i < s.Length; i++) {
            // Skip characters already checked
            bool isSkipped = false;
            for (int k = 0; k < skippedChars_Index; k++) {
                if (s[i] == skippedChars[k]) {
                    isSkipped = true;
                    break;
                }
            }
            if (isSkipped) continue;

            bool isRepeated = false;
            for (int j = i; j < s.Length; j++) {
                if (i != j && s[i] == s[j]) {
                    skippedChars[skippedChars_Index++] = s[i];
                    isRepeated = true;
                    break;
                }
            }

            if (!isRepeated) {
                firstNonRepeatedChars_Index = i;
                return firstNonRepeatedChars_Index;
            }
        }

        return -1;
    }
}


//----------------------

// public class Solution {
//     public int FirstUniqChar(string s) {
//         // create Skipped array for the Skipped chars with the size of s.length / 2
//         char[] skippedChars = new char[s.length];
//         int skippedChars_Index = -1;
//         int firstNonRepeatedChars_Index = default;
//         for(int i = 0; i < s.length ; i ++)
//         {
//             for(int k = 0; k < skippedChars_Index; k++)
//             {
//                 if(s[k] == skippedChars[k])
//                 ++i;
//             }

//             for(int j = i+1 ; j < s.length - 1; j++)
//             {
//                 if(s[i] == s[j])
//                 {
//                 skippedChars[skippedChars_Index] = s[j];
//                 ++skippedChars_Index;
//                 }
//                 else
//                 {
//                     firstNonRepeatedChar_Index = i;                    
//                 }
//             }    
//             if(firstNonRepeatedChars != -1)
//             return firstNonRepeatedChars_Index;  
//         }
//          return -1;
//     }
// }