package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

import app.models.ItemInfo;
import app.models.ShopModel;

public class Program {

    private static ShopModel shop = new ShopModel();

    public static void main(String[] args) throws Exception {
        //Step 1
        try(var listener = new ServerSocket(4000)){
            System.out.println("Shop server started on TCP port 4000...");
            while(true){
                //Step 2
                var client = listener.accept();
                communicateWith(client);
            }
        }
    }

    private static void communicateWith(Socket connection) {
        try{
            //Step 3
            var receiver = connection.getInputStream();
            var reader = new BufferedReader(new InputStreamReader(receiver));
            var sender = connection.getOutputStream();
            var writer = new PrintWriter(sender, true);
            writer.println("Welcome to EviTek computers");
            String name = reader.readLine();
            ItemInfo info = shop.getItemInfo(name);
            if(info != null)
                writer.printf("cost=%.2f&stock=%d%n", info.cost(), info.stock());
            writer.close();
            reader.close();
            //Step 4
            connection.close();
        }catch(IOException e){
            System.out.printf("Communication failure: %s%n", e);
        }
    }

}

