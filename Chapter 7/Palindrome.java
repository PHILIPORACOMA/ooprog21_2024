import java.util.Scanner;

public class Palindrome {

    public static boolean isPalindrome(String str) {
        String cleanedString = str.replaceAll("[^a-zA-Z0-9]", "").toLowerCase();
        
        int left = 0, right = cleanedString.length() - 1;
        while (left < right) {
            if (cleanedString.charAt(left) != cleanedString.charAt(right)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter a string:\n");
        String input = scanner.nextLine();
        
        if (isPalindrome(input)) {
            System.out.println("This is a palindrome.");
        } else {
            System.out.println("This is not a palindrome.");
        }

        scanner.close();
    }
}