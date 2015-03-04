package Shop.Products;

import Shop.Enumerations.AgeRestriction;
import Shop.Product;

public class ElectronicsProduct extends Product{
    private int guaranteePeriod;

    public ElectronicsProduct(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }

    protected void setGuaranteePeriod(int months) throws Exception {
        if(this.guaranteePeriod < 0){
            throw new Exception("Guarantee period cannot be negative number.");
        }
        this.guaranteePeriod = months;
    }

    @Override
    public String toString() {
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Electronic product")
                .append("\nGuarantee period: " + this.getGuaranteePeriod())
                .toString();
    }

    /**
     * Returns guarantee period in monts
     * @return
     */
    public int getGuaranteePeriod(){
        return this.guaranteePeriod;
    }
}
