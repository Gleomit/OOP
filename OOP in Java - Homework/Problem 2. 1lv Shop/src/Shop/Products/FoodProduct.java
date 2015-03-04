package Shop.Products;

import Shop.Enumerations.AgeRestriction;
import Shop.Interfaces.Expirable;
import Shop.Product;

import java.util.Calendar;
import java.util.Date;

public class FoodProduct extends Product implements Expirable {
    private Date expireDate;

    public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, Date expireDate) {
        super(name, price, quantity, ageRestriction);
        this.setExpireDate(expireDate);
    }

    @Override
    public Date getExpirationDate() {
        return this.expireDate;
    }

    @Override
    public double getPrice(){
        Date currentDate = new Date();

        Calendar calendar1 = Calendar.getInstance();
        Calendar calendar2 = Calendar.getInstance();

        calendar1.setTime(currentDate);
        calendar2.setTime(expireDate);

        long diffDays = (calendar2.getTimeInMillis() - calendar1.getTimeInMillis()) / (24 * 60 * 60 * 1000);

        if(diffDays <= 15) {
            return (70 * super.getPrice()) / 100;
        } else {
            return super.getPrice();
        }
    }

    private void setExpireDate(Date expireDate) {
        this.expireDate = expireDate;
    }

    @Override
    public String toString() {
        return (new StringBuilder())
                .append(super.toString())
                .append("\nType - Food Product\n")
                .append("Expire date: " + this.getExpirationDate().toString())
                .toString();
    }
}
