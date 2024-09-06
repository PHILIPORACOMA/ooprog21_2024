    

public class prelim{

 public static void fibonacci(int n){
      
      int num1 = 0, num2 = 1;

          for(int i = 0;i <= n;i++){
           System.out.printf("fibonacci("+i+")-> " +num1+"\n");
             int num3 = num1 + num2;
                 num1=num2;
                 num2=num3;               
                     
         }
     } 

    public static void main(String args[]){
    
      int n=7;
     
      fibonacci(n);                                
                     
}}