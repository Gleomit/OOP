package Shop.Products.ElectronicsProducts;

import Shop.Enumerations.AgeRestriction;
import Shop.Products.ElectronicsProduct;

public class Computer extends ElectronicsProduct {
    public Computer(String name, double price, int quantity, AgeRestriction ageRestriction) throws Exception {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(24);
    }

    @Override
    public double getPrice(){
        if(this.getQuantity() > 1000) {
            return (95 * super.getPrice()) / 100;
        } else {
            return super.getPrice();
        }
    }

    @Override
    public String toString() {
        return (new StringBuilder())
                .append(super.toString())
                .append("Type - Computer")
                .toString();
    }
}
