public class Solution {
    public int CountDigits(int num) {
        int Counter = 0 ; 
        string number = num.ToString();
        for (int i = 1; i <= number.Length; i++)
        {
            if(num % ((int)number[i-1] - '0') == 0)   
            Counter++;      
        }
        return Counter;
    }
}