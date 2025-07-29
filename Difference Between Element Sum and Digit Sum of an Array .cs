// --------------------My Solution-------------------------------
public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int Esum = 0;
		int Dsum = 0;
		
		for(int i = 0; i < nums.Length; i++)
		{
			Esum += nums[i];
            string number = nums[i].ToString();
			for(int j = 0; j < number.Length; j++)
			{
				Dsum += (int)number[j] - '0';
			}
		}
		return Math.Abs(Esum - Dsum);
    }
}

//------------------------ Another Best Solve -------------------------
public class Solution {
    public int DifferenceOfSum(int[] nums)
    {
        int answer = 0;
        int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            temp = nums[i];
            answer += temp;
            while (temp > 0)
            {
                answer -= temp % 10;
                temp /= 10;
            }
        }
        return answer;
    }
}