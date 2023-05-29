package HW_Seminar1;


public class Coffee extends HotDrink {

    public Coffee(String kind, double price, Long id, int temperature) {
        super(kind, price, id, temperature);
    }

    @Override
    public String toString() {
        return String.format("У Кофе: %s, ID = %s, price = %s, t⁰C = %s ", getKind(), getId(), getPrice(), getTemperature());
    }
}
