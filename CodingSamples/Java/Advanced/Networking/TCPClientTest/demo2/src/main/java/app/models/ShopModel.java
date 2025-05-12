package app.models;

import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class ShopModel {
    
    private String server;

    public ShopModel(String remote) {
        server = remote;
    }

    public ItemInfo fetchItemInfo(String name) throws Exception {
        URI address = new URI("http://" + server + "/shop/" + name);
        var client = HttpClient.newHttpClient();
        var request = HttpRequest.newBuilder(address)
            .GET()
            .header("User-Agent", "TCPClient-demo/2.0")
            .header("Accept", "text/plain")
            .build();
        var response = client.send(request, HttpResponse.BodyHandlers.ofString());
        if(response.statusCode() == 200)
            return ItemInfo.parse(response.body());
        return new ItemInfo(0, 0);
    }
}
