w
import java.util.*;

public class HW {

    public static void main(String[] args) {

        
        HashMap<String, String> map1 = new HashMap<>();
        map1.put("1", "Квадрат");
        map1.put("2", "Прямоугольник");
        map1.put("3", "Элипс");
        map1.put("4", "Круг");
        map1.put("5", "Треугольник");
        map1.put("6", "Трапеция");

       
        Iterator<String> iter = map1.keySet().iterator();
        while (iter.hasNext()){
            String key = iter.next();
            System.out.println(map1.get(key));   
        }

        for (String key: map1.keySet()) {
            map1.compute(key, (k, v) -> v+"!");
        }

        
        HashMap<String, String> map2 = new HashMap<>();
        map2.put("1", "10х10");
        map2.put("2", "6х10 ");
        map2.put("3", "Похож на яйцо");
        map2.put("4", "Радиус 12мм");
        map2.put("5", "15х3х5");
        map2.put("7", "Шар");
        map2.put("8", "Пирамида");

        
        var m1 = new HashSet<>(map1.keySet());
        m1.addAll(map2.keySet());                         

        HashMap<String, String> map3 = new HashMap<>();
        for (String key: m1)  map3.put(key, map1.getOrDefault(key, "") +
                (map1.containsKey(key) && map2.containsKey(key) ? " : " : "")     
                + map2.getOrDefault(key, ""));

        System.out.println();
        for (String key : map3.keySet())  System.out.println(key + " - " + map3.get(key));
    }
}