package app.services;

import java.util.ArrayList;

import io.grpc.ManagedChannelBuilder;
import io.grpc.StatusRuntimeException;
import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;
import sales.OrderManagerGrpc;
import sales.OrderManagerOuterClass.CustomerInput;
import sales.OrderManagerOuterClass.OrderInput;

@Path("/api/sales")
public class OrderManagerApi {

    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response readOrders(@PathParam("id") String customerId) {
        var channel = ManagedChannelBuilder.forAddress("localhost", 4030)
            .usePlaintext()
            .build();
        var stub = OrderManagerGrpc.newBlockingStub(channel);
        try{
            var request = CustomerInput.newBuilder()
                .setCustomerCode(customerId)
                .build();
            var reply = stub.fetchOrders(request);
            var resources = new ArrayList<OrderResource>();
            reply.forEachRemaining(message -> {
                var resource = new OrderResource();
                resource.productNo = message.getItemCode();
                resource.quantity = message.getItemCount();
                resource.orderDate = message.getConfirmationDate();
                resources.add(resource);
            });
            return resources.size() > 0 
                ? Response.ok(resources).build()
                : Response.status(404).build();
        }finally{
            channel.shutdown();
        }
    }

    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Response createOrder(OrderResource resource) {
        var channel = ManagedChannelBuilder.forAddress("localhost", 4030)
            .usePlaintext()
            .build();
        var stub = OrderManagerGrpc.newBlockingStub(channel);
        try{
            var request = OrderInput.newBuilder()
                .setCustomerCode(resource.customerId)
                .setItemCode(resource.productNo)
                .setItemCount(resource.quantity)
                .build();
            var reply = stub.placeOrder(request);
            resource.orderNo = reply.getConfirmationCode();
            return Response.ok(resource).build();
        }catch(StatusRuntimeException e){
            return Response.status(500, "Order Failed").build();
        }finally{
            channel.shutdown();
        }
    }
}


