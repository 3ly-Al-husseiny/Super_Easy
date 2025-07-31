public class Solution {
    public int SubtractProductAndSum(int n) {
        string number = n.ToString();
		int Product = 1;
		int Sum = 0 ;
		for(int i = 0; i < number.Length; i++)
		{
			Product *= (int)number[i];
			Sum += (int)number[i];
		}
		return Product - Sum;
    }
}