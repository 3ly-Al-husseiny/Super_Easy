public class Solution {
    public int CalPoints(string[] operations) {
        int[] score = new int[operations.Length];
        int index = 0;

        for (int i = 0; i < operations.Length; i++) {
            if (int.TryParse(operations[i], out int num)) {
                score[index++] = num;
            } else if (operations[i] == "C") {
                index--;
                score[index] = 0;
            } else if (operations[i] == "D") {
                score[index] = score[index - 1] * 2;
                index++;
            } else if (operations[i] == "+") {
                score[index] = score[index - 1] + score[index - 2];
                index++;
            }
        }

        int sum = 0;
        for (int i = 0; i < index; i++) {
            sum += score[i];
        }

        return sum;
    }
}

// ----------------------------Your Previous Answer without Index (Wrong Answer) -------------------


public class Solution {
    public int CalPoints(string[] operations) {
        int[] Score = new int[operations.Length]; 
		for(int i =0; i < operations.Length; i++)
		{
			if( int.TryParse(operations[i],out int temp) == true)
				Score[i] = temp;
			else if(operations[i] == "+")
				Score[i] = Score[i-1] + Score[i-2];
			else if(operations[i] == "C")
			{	
			Score[i-1] = 0; 
			i--;
			}
			else if(operations[i] == "D")
				Score[i] = Score[i-1] * 2;
		}
		int sum = 0; 
		for(int i = 0 ; i < Score.Length; i++)
		{
			sum += Score[i];
		}
		return sum;
		
    }
}