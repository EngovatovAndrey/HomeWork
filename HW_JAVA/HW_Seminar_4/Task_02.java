import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Task_02 {

    public static void main(String[] args) {

        try (Scanner iScanner = new Scanner(System.in)) {
        System.out.printf("Введите через пробелы Ф,И,О, возраст, пол: ");
        String data = iScanner.nextLine();
        
        try (FileWriter fw = new FileWriter("HW_Seminar_4/test.txt", true)) {
            fw.append(data+"\n");
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }
    }
}