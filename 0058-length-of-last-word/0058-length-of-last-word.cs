public class Solution {
    public int LengthOfLastWord(string s) {
        var clean = s.Trim();// this remove the first and the end spaces 
        String [] str = clean.Split(" ");
        int ans = str[str.Length-1].Length;
        return ans;
    }
}