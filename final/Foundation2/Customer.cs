public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool Domestic()
    {
        return address.Domestic();
    }

    public override string ToString()
    {
        return $"{name}\n{address}";
    }
}
