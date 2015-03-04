package Shop.Core;

import Shop.Customer;
import Shop.Enumerations.AgeRestriction;
import Shop.Product;
import Shop.Products.ElectronicsProduct;
import Shop.Products.FoodProduct;

import java.util.Date;

public class PurchaseManager {
    public static void processPurchase(Product product, Customer customer) throws Exception {
        if(product.getQuantity() <= 0) {
            throw new Exception("The product is out of stock");
        } else if(product instanceof FoodProduct &&
                ((FoodProduct) product).getExpirationDate().getTime() < (new Date()).getTime()) {
            throw new Exception("The product is expired");
        } else if(customer.getBalance() < product.getPrice()) {
            throw new Exception("You do not have enough money to buy this product!");
        } else if(product.getAgeRestriction() == AgeRestriction.Adult && customer.getAge() < 18) {
            throw new Exception("You are too young to buy this product!");
        } else {
            product.setQuantity(product.getQuantity() - 1);
            customer.setBalance(customer.getBalance() - product.getPrice());
        }
    }
}
