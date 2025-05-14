package app;

import app.shopping.data.ProductEntity;
import jakarta.persistence.Persistence;

public class Program {
    
    public static void main(String[] args) throws Exception {
        var emf = Persistence.createEntityManagerFactory("app.data");
        try(var em = emf.createEntityManager()){
            if(args.length == 0){
                var query = em.createQuery("SELECT e FROM ProductEntity e WHERE e.stock >= ?1", ProductEntity.class);
                var products = query.setParameter(1, 18)
                    .getResultList();
                for(var item : products)
                    System.out.printf("%-6d%12.2f%8d%n", item.getProductNo(), item.getPrice(), item.getStock());
            }else{
                int pid = Integer.parseInt(args[0]);
                var product = em.find(ProductEntity.class, pid);
                if(product != null){
                    for(var entry : product.getOrders())
                        System.out.printf("%s\t%d\t%s%n", entry.getCustomerId(), entry.getQuantity(), entry.getOrderDate());
                }
            }
        }
    }
}

