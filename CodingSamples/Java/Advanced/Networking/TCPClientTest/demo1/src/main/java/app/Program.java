package app;

import app.models.ItemInfo;
import app.models.ShopModel;

public class Program {
    
    public static void main(String[] args) throws Exception {
        String item = args[0].toLowerCase();
        int quantity = Integer.parseInt(args[1]);
        var shop = new ShopModel(args[2]);
        ItemInfo info = shop.fetchItemInfo(item);
        if(quantity <= info.stock())
            System.out.printf("Total Payment: %.2f%n", 1.18 * quantity * info.cost());
        else
            System.out.println("Not in stock!");
    }

}

