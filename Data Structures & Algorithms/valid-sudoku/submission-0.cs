public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> unique = new();

        for(int i=0; i< board.Length; i++)
        {
            for(int j =0; j< board[i].Length; j++)
            {
                char current = board[i][j];
                if (current == '.') continue;
                var colId = $"c{j}{current}";
                var rowId = $"r{i}{current}";
                var boxId = $"b{i/3}{j/3}{current}";

                if(!unique.Add(colId)) return false;
                if(!unique.Add(rowId)) return false;
                if(!unique.Add(boxId)) return false;

            }
        }
        return true;
    }
}
