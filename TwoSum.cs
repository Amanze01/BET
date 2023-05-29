public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var dictMap = new Dictionary<int, int>();
        int[] toReturn = null;

        for (int i = 0; i < nums.Length; i++){
            int x = nums[i];
            int y = target - x;
            
            if (dictMap.ContainsKey(y)){
                toReturn = new int[] {dictMap[y], i};
            }
            dictMap[x] = i;         
        }
        string[] result = Array.
        ConvertAll(toReturn, x => x.ToString());

        Console.WriteLine("[" + String.Join(",", result) + "]");

        return toReturn;
    }      
}

//Example
//Given [2,7,11,15], target = 9
//Return indices [0,1]
