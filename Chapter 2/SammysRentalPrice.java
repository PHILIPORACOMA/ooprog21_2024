import java.util.Scanner;

public class SammysRentalPrice {
    
    public static void showMotto() {
        System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
        System.out.println("S Sammy's makes it fun in the sun. S");
        System.out.println("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
    }    
        
    public static void main(String[] args) {
        
        showMotto();
        
        Scanner input = new Scanner(System.in);
        
        System.out.print("\nEnter the number of minutes you rented the equipment: ");
        int totalMinutes = input.nextInt();
          for (int i = 0;i < 50;i++){
                   System.out.println();
                }
        int hours = totalMinutes / 60;
        int Minutes = totalMinutes % 60;

        
        int totalCost = (hours * 40) + Minutes;
         /*  
            if (totalMinutes < 60){
             totalCost = 40;
           } 
         */  //   Remove Multi-line comment symbols to enable same hour rate if minutes are below 60
        showMotto();
        System.out.println("\nHours: " + hours);
        System.out.println("Minutes: " + Minutes);
        System.out.println("Total price: $" + totalCost);
    }
}
