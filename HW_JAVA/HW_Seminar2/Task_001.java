// Написать метод принимающий строку, ищущий в ней основание и степень 
// После этого расчитывающий результат и выводящий в консоль строку параметра + ответ. 
// Пример строки: "Основание -12б степень 7, результат". Попробовать с разными входящими строками.
// Сравнить скорость работы реплейса классов String и StringBuilder.

public class Task_001 {
    public static void main(String[] args) {
        String st0 = "Если бы это было так, это бы ещё ничего. Если бы, конечно, оно так и было. Но так как это не так, так оно и не этак. Такова логика вещей.";

        String old_word = "было";
        String new_word = "стало";

        long t3 = System.nanoTime();
        String st1 = st0.replace(old_word, new_word);
        System.out.println(st1);
        System.out.println(System.nanoTime() - t3);

        long t6 = System.nanoTime();
        StringBuilder stf0 = new StringBuilder(st0);
        StringBuilder delStr = new StringBuilder(st0);
        int count_n = 0;
        int ind1 = delStr.indexOf(old_word);
        while (ind1 != -1)
        {
            ind1 = delStr.indexOf(old_word);
            count_n += ind1;
            stf0.replace(count_n, count_n + old_word.length(), new_word);
            count_n += new_word.length();
            delStr.delete(0, ind1+old_word.length());
        }
        System.out.println(stf0);
        System.out.println(System.nanoTime() - t6);


        
    }
    
}
