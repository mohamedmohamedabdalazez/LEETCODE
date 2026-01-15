class Solution {
public:
    vector<bool> kidsWithCandies(vector<int>& candies, int extraCandies) {
 int mx = *max_element(candies.begin(), candies.end());
    
    vector<bool> ans;
    
    
    for (int current : candies) {
        ans.push_back(current + extraCandies >= mx);
    }
    
    return ans;    }
};