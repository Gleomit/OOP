package Shop.Products.ElectronicsProducts;

import Shop.Enumerations.AgeRestriction;
import Shop.Products.ElectronicsProduct;

public class Appliance extends ElectronicsProduct{
    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction) throws Exception {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(6);
    }

    @Override
    public double getPrice(){
        if(this.getQuantity() < 50) {
            return (105 * super.getPrice()) / 100;
        } else {
            return super.getPrice();
        }
    }

    @Override
    public String toString() {
        return (new StringBuilder())
                .append(super.toString())
                .append("Type - Appliance")
                .toString();
    }
}
