package HW_Seminar1;


public abstract class HotDrink extends Product {

    protected int temperature;
    public HotDrink(String kind, double price, Long id, int temperature) {
        super(kind, price, id);
        this.temperature = temperature;
    }

    public int getTemperature() { return temperature; }
}
