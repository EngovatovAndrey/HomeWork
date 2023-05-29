// 1. Создать наследника реализованного класса ГорячийНапиток с дополнительным полем int температура.
// 2. Создать класс ГорячихНапитковАвтомат реализующий интерфейс ТорговыйАвтомат и реализовать
// перегруженный метод getProduct(int name, int volume, int temperature), выдающий продукт соответствующий имени,
// объёму и температуре
// 3. В main проинициализировать несколько ГорячихНапитков и ГорячихНапитковАвтомат и воспроизвести логику,
// заложенную в программе
// 4. Всё вышеуказанное создать согласно принципам ООП, пройденным на семинаре



package HW_Seminar1;

public class Main {
    public static void main(String[] args) {

        Vending vending = new FoodVending();

        Product product1 = new Apple("Apple", 20, 1L);
        Product product2 = new Mars("Mars", 25, 2L);

        vending.addProduct(product1);
        vending.addProduct(product2);


        System.out.println(vending.getProduct("Apple"));
        System.out.println(vending.getProduct("Mars"));

        System.out.println();
        System.out.println(vending.getProduct(1L));
        System.out.println(vending.getProduct(2L));

        
        VendingDrink vendDrink = new VendingDrink();
        HotDrink drink1 = new Tea("Tea", 6,10L, 70);
        HotDrink drink2 = new Coffee("Coffee", 11,12L, 65);
        
        vendDrink.addHotDrink(drink1);
        vendDrink.addHotDrink(drink2);

        System.out.println();
        System.out.println(vendDrink.getHotDrink("Tea"));
        System.out.println(vendDrink.getHotDrink("Coffee"));

        System.out.println();
        System.out.println(vendDrink.getHotDrink(10L));
        System.out.println(vendDrink.getHotDrink(12L));
    
        System.out.println();
        System.out.println(vendDrink.getHotDrink(70));
        System.out.println(vendDrink.getHotDrink(65));

    }
}
