public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int p1 =0;int p2 =0;string ans ="";
        int mn = Math.Min(word1.Length,word2.Length);
        while(p1 != mn && p2 != mn)
        {
            ans+=word1[p1];
            p1++;
            ans+=word2[p2];
            p2++;
        }
        while(p1!=word1.Length)
        {
             ans+=word1[p1];
            p1++;
        }
         while(p2!=word2.Length)
        {
             ans+=word2[p2];
            p2++;
        }
        return ans;
    }
}