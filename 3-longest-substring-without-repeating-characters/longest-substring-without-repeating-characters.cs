public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //sliding window technique

        HashSet<char> stringSet=new HashSet<char>();
        var leftPointer=0;
        var rightPointer=0;
        var maxLen=0;

        while(rightPointer<s.Length){
            if(!stringSet.Contains(s[rightPointer])){
                stringSet.Add(s[rightPointer]);
                rightPointer++;
                maxLen=Math.Max(maxLen,rightPointer-leftPointer);
            }
            else{
                stringSet.Remove(s[leftPointer]);
                leftPointer++;
            }
        }

        return maxLen;
    }
}