namespace Count_by_X
{
    public static class Kata
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            for (int k = 0; k < n; k++) {
                z[k] = (k + 1) * x;
            }
            return z;
        }
    }
}