using Grpc.Core;
using Grpc.Core.Utils;
using Sales;
using ServerApp.Data.Shopping;

namespace ServerApp.Services;

public class OrderManagerService(ShopDbContext shop) : OrderManager.OrderManagerBase
{
    public override async Task<OrderStatus> PlaceOrder(OrderInput request, ServerCallContext context)
    {
        var ctr = await shop.Counters.FindAsync("order");
        var order = new Order 
        {
            Id = ++ctr.CurrentValue + ctr.SeedValue,
            OrderDate = DateOnly.FromDateTime(DateTime.Today),
            CustomerId = request.CustomerCode,
            ProductId = request.ItemCode,
            Quantity = request.ItemCount
        };
        shop.Orders.Add(order);
        try
        {
            await shop.SaveChangesAsync();
            return new OrderStatus { ConfirmationCode = order.Id };
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            context.Status = new Status(StatusCode.Internal, "Order Failed");
            return new OrderStatus { ConfirmationCode = -1 };
        }
    }

    public override async Task FetchOrders(CustomerInput request, IServerStreamWriter<CustomerOrder> responseStream, ServerCallContext context)
    {
        var messages = from e in shop.Orders
            where e.CustomerId == request.CustomerCode
            select new CustomerOrder 
            {
                ItemCode = e.ProductId,
                ItemCount = e.Quantity,
                ConfirmationDate = e.OrderDate.ToString("yyyy-MM-dd")
            };
        await responseStream.WriteAllAsync(messages);
    }
}
