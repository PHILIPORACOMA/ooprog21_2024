import java.util.Scanner;

 public class CarlysEventPrice {
      
        public static void showMotto(){
        
         System.out.println("*************************************");
         System.out.println("* Carly's makes the food that makes *");
         System.out.printf("*%12sit a party%13s*\n","","");
         System.out.println("*************************************");
 }
 
        public static void main(String[] args){
            int PRICE_PER_GUEST = 35;
            int EVENT_LIMIT = 50;
            
            Scanner Input = new Scanner(System.in);
            
            showMotto();
            
            System.out.printf("\nEnter amount of guests: ");
              int numberOfGuests = Input.nextInt();
                for (int i = 0;i < 50;i++){
                   System.out.println();
                }
              int totalPrice = numberOfGuests * PRICE_PER_GUEST;
              
              showMotto();
              
              System.out.println("Number of guests: " + numberOfGuests);
              System.out.println("Price per guest: $" + PRICE_PER_GUEST);
              System.out.println("Total price: $" + totalPrice);
              
              boolean isEvent = numberOfGuests >= EVENT_LIMIT;
              System.out.println("Is this a large event? " + isEvent);
          }
    }  
  
            