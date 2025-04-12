namespace Tasks.Tasks.Easy;

public class Palindrome_Number {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }
        if(x % 10 == x){
            return true;
        }
        int n = 0;
        for(int i = x; i % 10 != i; i /= 10){
            n++;
        }
        for(int i = n; i > 0; i -= 2){
            if((x % 10) != (x / (int)Math.Pow(10,i))){
                return false;
            }
            x = x % (int)Math.Pow(10,i) / 10;
        }
        return true;
    }
}