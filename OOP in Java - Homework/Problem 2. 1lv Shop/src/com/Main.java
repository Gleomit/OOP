package com;

import Shop.Core.PurchaseManager;
import Shop.Customer;
import Shop.Enumerations.AgeRestriction;
import Shop.Interfaces.Expirable;
import Shop.Product;
import Shop.Products.ElectronicsProducts.Appliance;
import Shop.Products.ElectronicsProducts.Computer;
import Shop.Products.FoodProduct;

import java.util.ArrayList;
import java.util.Date;

public class Main {

    public static void main(String[] args) throws Exception {
        try {
            FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult, new Date(2015, 2, 12));
            Customer pecata = new Customer("Pecata", 17, 30.00);
            PurchaseManager.processPurchase(cigars, pecata);
            Customer gopeto = new Customer("Gopeto", 18, 0.44);
            PurchaseManager.processPurchase(cigars, gopeto);
        } catch (Exception exception) {
            System.out.println(exception.getMessage());
        }

        ArrayList<Product> products = new ArrayList<Product>();
        products.add(new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult, new Date(2015, 2, 12)));
        products.add(new Computer("Super, Mega PC", 1000, 10, AgeRestriction.Adult));
        products.add(new Appliance("Super Laser", 15.50, 100, AgeRestriction.Teenager));

        System.out.println("\n\nProduct with the soonest expirity date: ");
        System.out.println(products.stream()
                .filter(product -> product instanceof Expirable)
                .sorted((productOne, productTwo) ->
                        Long.compare(((Expirable) productOne).getExpirationDate().getTime(),
                                ((Expirable) productTwo).getExpirationDate().getTime()))
                .findFirst()
                .get());

        System.out.println("\n\nProducts for adults, ordered by price:");
        products.stream()
                .filter(product -> product.getAgeRestriction() == AgeRestriction.Adult)
                .sorted((productOne, productTwo) -> Double.compare(productOne.getPrice(), productTwo.getPrice()))
                .forEach(product -> System.out.println(product));
    }
}
