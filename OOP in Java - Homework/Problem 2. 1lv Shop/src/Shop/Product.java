package Shop;

import Shop.Enumerations.AgeRestriction;
import Shop.Interfaces.Buyable;

public class Product implements Buyable {
    private String name;
    private AgeRestriction ageRestriction;
    private double price;
    private int quantity;

    public Product(String name,double price, int quantity, AgeRestriction ageRestriction){
        this.setName(name);
        this.setAgeRestriction(ageRestriction);
        this.setPrice(price);
        this.setQuantity(quantity);
    }
    @Override
    public double getPrice() {
        return this.price;
    }

    @Override
    public String toString() {
        return (new StringBuilder())
                .append("\nProduct:\n")
                .append("Price: " + this.getPrice() + " $")
                .append("\nQuantity: " + this.getQuantity())
                .append("\nAge Restriction: " + this.getAgeRestriction().toString())
                .toString();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }
}
