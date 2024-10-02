public class MathTest {
    public static void main(String[] args) {

        double sqrtResult = Math.sqrt(37.0);
        System.out.println("SQRT: " + sqrtResult);
        
        double sinResult = Math.sin(181);
        double cosResult = Math.cos(91);
        System.out.println("SIN: " + sinResult);
        System.out.println("COS: " + cosResult);
        
        double floorResult = Math.floor(22.9);
        System.out.println("FLOOR: " + floorResult);
        
        double ceilResult = Math.ceil(22.1);
        System.out.println("CEIL: " + ceilResult);
        
        long roundResult = Math.round(22.5);
        System.out.println("ROUND: " + roundResult);
        
        int maxResult = Math.max(68, 71);
        int minResult = Math.min(68, 71);
        System.out.println("MAX: " + maxResult);
        System.out.println("MIN: " + minResult);
        
        double randomResult = Math.random() * 100;
        System.out.println("RANDOM: " + randomResult);
    }
}