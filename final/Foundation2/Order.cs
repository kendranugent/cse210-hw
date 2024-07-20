using System.Text;
public class Order
{
    private List<Product> products;
    private Customer customer;


    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        products.Add(product);
    }


    public float TotalCost()
    {
        float total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        //shipping cost
        total += customer.Domestic() ? 5 : 35;

        return total;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (var product in products)
        {
            label.AppendLine(product.ToString());
        }
        return label.ToString();
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{customer}";
    }
}
