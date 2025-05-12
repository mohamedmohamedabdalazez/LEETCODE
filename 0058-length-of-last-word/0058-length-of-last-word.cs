public class Solution {
    public int LengthOfLastWord(string ss) {
        var clean = ss.Trim();// this remove the first and the end spaces 
        String [] str = clean.Split(" ");
        int ans = str[str.Length-1].Length;
        return ans;
    }
}