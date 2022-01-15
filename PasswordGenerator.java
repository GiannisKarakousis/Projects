package passwordgenerator;

import java.util.Random;
import java.util.Scanner;

public class PasswordGenerator {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        System.out.println("How many characters do you want your password to be?");
        int num = input.nextInt();
        System.out.println(generatePass(num));
    }
    
    public static char[] generatePass(int num){
        System.out.print("Your password is: ");
        String charCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String chars = "abcdefghijklmnopqrstuvwxyz";
        String nums = "0123456789";
        String symbols = "!@#$%^&*";
        
        String passSymbols = charCaps + chars + nums + symbols;
        Random rnd = new Random();
        
        char[] password = new char[num];
        for(int i=0;i<num;i++){
            password[i]=passSymbols.charAt(rnd.nextInt(passSymbols.length()));
        }
        return password;
    }
}
