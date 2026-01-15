class Solution {
public:
    bool canPlaceFlowers(vector<int>& flowerbed, int n) {
         int ans = 0; 
        int size = flowerbed.size();

        for (int i = 0; i < size; i++) {
            
            if (flowerbed[i] == 0) {
                
               
                bool prevEmpty = (i == 0) || (flowerbed[i - 1] == 0);

              
                bool nextEmpty = (i == size - 1) || (flowerbed[i + 1] == 0);

               
                if (prevEmpty && nextEmpty) {
                    flowerbed[i] = 1; 
                    ans++;            
                }
            }
        }

        return ans >= n;
    }
};