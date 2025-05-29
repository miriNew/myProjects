using BO;
namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(BO.Order order,int productId,int quantity);
    void CalcTotalPriceForProduct(BO.ProductInOrder product);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void SearchSaleForProduct(BO.ProductInOrder product, bool existCustomer);
}
