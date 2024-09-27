class Billing{
 
   static double computeBill(double price){
    double total = price * 1.08;
    System.out.printf("The total price for the bill is: $%.3f",total);
    return total;
   }
   static double computeBill(double price, int quantity){
    double total =price * quantity * 1.08;
    System.out.printf("\nThe total price for the bill is: $%.3f", total);
   return total;
   }
   static double computeBill(double price, int quantity , int coupon){
    double total = price * quantity * 1.08 - coupon;
    System.out.printf("\nThe total price for the bill is: $%.3f", total);
   return price * 1.08;
   }

 
   public static void main(String[] a){
    computeBill(23.2);
    computeBill(24.4,2);
    computeBill(25.17655,3,5);
    }
 }
   
   
   