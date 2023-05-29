package HW_Seminar1;


public class Mars extends Product {
    public Mars(String kind, double price, Long id) {
        super(kind, price, id);
    }

    @Override
    public String toString() {
        return String.format("У шоколадки Марс: %s, %s, %s", getKind(), getPrice(), getId());
    }
}
