
best Solution 
public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            } else {
                digits[i] = 0;
            }
        }
        
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1; 
        return newDigits;
    }
}

Solution Where are your ear, Juha?
  
public class Solution {
    public int[] PlusOne(int[] digits) {
        bool carry = true;

        for (int i = digits.Length - 1; carry && i >= 0; i--) {
            carry = digits[i] == 9;
            digits[i] = carry ? 0 : digits[i] + 1;
        }

        if (carry) {
            int[] tmp = new int[digits.Length + 1];
            tmp[0] = 1;
            Array.Copy(digits, 0, tmp, 1, digits.Length);
            digits = tmp;
        }

        return digits;
    }
}
