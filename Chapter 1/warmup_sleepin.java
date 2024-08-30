public class warmup_sleepin {
    public static boolean sleepIn(boolean weekday, boolean vacation) {
        return !weekday || vacation;
    }
    public static void main(String[] args) {
        System.out.printf("SleepIn(false,false)-> %b ",sleepIn(false, false)); // true
        System.out.printf("\nSleepIn(true,false)-> %b",sleepIn(true, false));  // false
        System.out.printf("\nSleepIn(false,true)-> %b",sleepIn(false, true));  // true
    }
}