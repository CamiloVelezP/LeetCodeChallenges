public class Solution {
    public int GetMaximumGold(int[][] grid) {
        int gold = 0;
        int CheckPath(int row, int col, int sum){
            if(row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == 0) return sum; 
            int currentGold = grid[row][col];
            sum += currentGold;
            grid[row][col]=0;
            int[] possibleValues = new int[4];
            possibleValues[0] = CheckPath(row+1,col,sum);
            possibleValues[1] = CheckPath(row-1,col,sum);
            possibleValues[2] = CheckPath(row,col+1,sum);
            possibleValues[3] = CheckPath(row,col-1,sum);
            grid[row][col] = currentGold;
            return possibleValues.Max();
        }

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if(grid[row][col]!=0){
                    gold = Math.Max(gold, CheckPath(row,col,0));
                }
            }
        }
        return gold;
    }
}