import java.util.Arrays;
import java.util.Random;

public class Task_001 {


    public static void main(String[] args) {

        int i = new Random().nextInt(0,2001);
        String s = "Случайное число i = "; 
        System.out.println( s + i);


        int n = Integer.toBinaryString(i).length(); 
        String s1 = "Номер старшего значащего бита выпавшего числа = "; 
        System.out.println(s1 + n);


        int n0 = ((i - 1) / n + 1) * n; 
        int n1 = (Short.MAX_VALUE / n) * n; 
        short[] m1 = new short[(n1 - n0) / n + 1];  
        for (int l = n0; l <= n1; l += n) {         
            m1[(l - n0) / n] = (short) l; 
        }
        System.out.println(Arrays.toString(m1));

        int k = (i  / n ) + (Short.MIN_VALUE / n ) * (-1) + 1; 
        short[] m2 = new short[i - Short.MIN_VALUE + 1 - k];   
        int m = 0;
        for (int l = Short.MIN_VALUE; l <= i; l++) {
            if (l % n != 0) {
                m2[m] = (short) l;
                m++;
            }
        }
    System.out.println(Arrays.toString(m2));

    }
}