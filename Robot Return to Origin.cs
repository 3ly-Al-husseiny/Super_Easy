public class Solution {
    public bool JudgeCircle(string moves) {
		int D = 0 , U = 0, L = 0, R = 0; 
        for(int i = 0; i < moves.Length; i ++)
		{
			if(moves[i] == 'U')
			{	
			U++;
			continue;
			}
			if(moves[i] == 'D')
			{	
			D++;
			continue;
			}
			if(moves[i] == 'L')
			{	
			L++;
			continue;
			}
			if(moves[i] == 'R')
			{	
			R++;
			continue;
			}
		}
		if(U == D && R == L) return true;
		else return false;
    }
}