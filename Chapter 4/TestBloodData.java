import java.util.Scanner;

public class TestBloodData {
    public static void main(String[] args) {
    
        Scanner input = new Scanner(System.in);
        
        BloodData patient = new BloodData();
        
        String bloodType;
        while (true) {
            System.out.print("Enter Blood Type: ");
            System.out.println();
            bloodType = input.nextLine().toUpperCase();  // Convert input to uppercase for consistency
            if (bloodType.equals("A") || bloodType.equals("B") || bloodType.equals("AB") || bloodType.equals("O")) {
                patient.setBloodType(bloodType);
                break;
            } else {
                System.out.println("Invalid blood type. Please enter A, B, AB, or O.");
            }
        }
        String rhFactor;
        while (true) {
            System.out.print("Enter Rh Factor: ");
            System.out.println();
            rhFactor = input.nextLine();
            if (rhFactor.equals("+") || rhFactor.equals("-")) {
                patient.setRhFactor(rhFactor);
                break;
            } else {
                System.out.println("Invalid Rh factor. Please enter + or -.");
            }
        }
        patient.displayBloodInfo();
        input.close();
    }
}