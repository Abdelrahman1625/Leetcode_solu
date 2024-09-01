public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if (original.Length != m * n) {
            return new int[0][];
        }

        int[][] result = new int[m][];
        for (int i = 0; i < m; i++) {
            result[i] = new int[n];
        }

        for (int i = 0; i < original.Length; i++) {
            int row = i / n;
            int col = i % n;
            result[row][col] = original[i];
        }

        return result;
    }
}