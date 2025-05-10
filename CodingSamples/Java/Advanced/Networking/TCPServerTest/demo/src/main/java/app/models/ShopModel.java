package app.models;

import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;

import com.google.gson.Gson;

public class ShopModel {
    
    private ItemInfo[] items;

    public ShopModel() {
        try(var reader = new FileReader("EviTek.store")){
            var serializer = new Gson();
            items = serializer.fromJson(reader, ItemInfo[].class);
        }catch(IOException e){
            throw new RuntimeException(e);
        }
    }

    public ItemInfo getItemInfo(String name) {
        return Arrays.stream(items)
            .filter(i -> i.id().equals(name))
            .findFirst()
            .orElse(null);
    }
}
