public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int Counter = 0; 
		for(int i = 0 ; i < arr.Length; i ++)
		{
			if(arr[i] % 2 != 0)
				Counter++;
			else
				Counter = 0;
			if(Counter == 3)
				return true;
		}
		return false;
		
    }
}