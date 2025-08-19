public class Solution {
    public int[] PlusOne(int[] digits) {
        // int number = 0;
        // for(int i = 0; i<digits.Length; i++){
        //     number = number * 10 + digits[i];    
        // }
        // number++;
        // string numberString = number.ToString();
        // int[] numarr = new int[numberString.Length];
        // for(int j = 0; j<numarr.Length; j++){
        //     numarr[j] = numberString[j] - '0';
        // }
        // return numarr;
        int n = digits.Length;
        for(int i = n - 1; i >= 0; i--){
            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] result = new int[n+1];
        result[0] = 1;
        return result;
    }
}