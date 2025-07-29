public class Solution {
    public int AddDigits(int num) {
        // Declare a counter = 0; 
        // get the last digit in the number --> % 10
        // get rid of the last digit in the number --> / 10
        // repeat until the original number = 0 

        int sum = 0;
        while(num > 0)
        {
            // get the last digit and add it to the sum 
            sum += (num % 10);

            // get rid of the last digit 
            num /= 10;
        } 
        if(sum / 10 > 0)
        return AddDigits(sum);
        return sum;
    }
}

// ------------ Your Error is 

 // if(sum % 10 > 0) // as this condition is always true and you will get a stackorver flow :) 