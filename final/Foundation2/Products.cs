public class Product
{
    private string name;
    private string productID;
    private float pricePerUnit;
    private int quantity;


    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }


    public float TotalCost()
    {
        return pricePerUnit * quantity;
    }

    public override string ToString()
    {
        return $"{name} ({productID})";
    }
}
