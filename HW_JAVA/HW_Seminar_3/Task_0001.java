import java.util.*;

public class Task_0001 {

    public static void main(String[] args) {

        // 1. Реализовать алгоритм обратной сортировки списков компаратором.
        ArrayList<Integer> list_1 = new ArrayList<>();
        for (int i = 0; i < 12; i++)  list_1.add(new Random().nextInt(20));
        System.out.println("Исходный список - 1: " + list_1);
        list_1.sort(new Comparator<Integer>() {
            @Override
            public int compare(Integer o1, Integer o2) {
                return o2 - o1;
            }
        });
        System.out.println("Сортированный список: " + list_1 + "\n");


        // 2. Пусть дан произвольный список целых чисел, удалить из него чётные числа.
        ArrayList<Integer> list_2 = new ArrayList<>();
        for (int i = 0; i < 12; i++)  list_2.add(new Random().nextInt(-20, 20));
        System.out.println("Исходный список - 2: " + list_2);
        list_2.removeIf(integer -> integer % 2 == 0);
        System.out.println("Исключили честные числа: " + list_2 + "\n");


        // 3. Задан целочисленный список ArrayList. Найти минимальное, максимальное и среднее из этого списка.
        ArrayList<Integer> list_3 = new ArrayList<>();
        for (int i = 0; i < 13; i++)  list_3.add(new Random().nextInt(-20, 25));
        System.out.println("Исходный список - 3: " + list_3);
        int max_i = Integer.MIN_VALUE;
        int min_i = Integer.MAX_VALUE;
        int summ = 0;
        for (int i: list_3) {
            if (max_i < i) max_i = i;
            if (min_i > i) min_i = i;
            summ += i;
        }
        System.out.println("MAX: " + max_i + ", " + "MIN: " + min_i + ", " + "Average: ≈" + (double) Math.round(((double) summ / list_3.size())*100)/100 + ".\n");


        // 4. Дано два целочисленных списка, объеденить их не допуская элементы второго списка уже встречающиеся в первом.
        ArrayList<Integer> list_4 = new ArrayList<>();
        for (int i = 0; i < 8; i++)  list_4.add(new Random().nextInt(12));
        ArrayList<Integer> list_5 = new ArrayList<>();
        for (int i = 0; i < 8; i++)  list_5.add(new Random().nextInt(12));
        System.out.println("Исходные списки: \n" + list_4 + "\n" + list_5);
        list_5.removeAll(list_4);
        list_4.addAll(list_5);
        System.out.println("Результат объединение списков: " + list_4 + "\n");

        // 5. Создать ArrayList<Integer> и добавить нулевым эллементом ноль 10000 раз.
        ArrayList<Integer> list_6 = new ArrayList<>();
        long t50 = System.nanoTime();
        for (int i = 0; i<10000; i++) list_6.add(0, 0); 
        long t51 = System.nanoTime(); 
        System.out.print("Время выполнения с ArrayList<Integer> в нс: ");
        System.out.println(t51-t50);

        // 6. Создать LinkedList<Integer> и добавить нулевым эллементом ноль 10000 раз.
        LinkedList<Integer> list_7 = new LinkedList<>();
        long t60 = System.nanoTime();
        for (int i = 0; i<10000; i++) list_7.add(0, 0);  
        long t61 = System.nanoTime();
        System.out.print("Время выполнения с LinkedList<Integer> в нс: ");
        System.out.println(t61-t60);

        // 7. Сравнить время работы пятого и шестого пунктов.
        float def = (float) (t51 - t50) / (t61 - t60);
        System.out.printf("Время выполнения с LinkedList<Integer> в %.2f раза быстрей", def);
    }
}