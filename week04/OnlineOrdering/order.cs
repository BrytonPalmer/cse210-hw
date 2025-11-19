// Constructor:
//     Order(Customer customer, List<Product> products)

//         Properties:
//             Customer customer
//             List<Product> products

//         methods:
//             getCustomerName();
//             addProduct(Product product): void
//             getProducts(): List<Product>

using System.Text;

class Order
{
    private Customer customer;
    private List<Product> products;


    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public Customer GetCustomer()
    {
        return customer;
    }

    public List<Product> GetProducts()
    {
        return products;
    }

    private double GetProductTotal()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetProductPrice() * product.GetProductQuantity();
        }
        return total;
    }

    private double GetShippingFee()
    {
        return customer.InTheUSA() ? 5 : 35;
    }

    public double GetOrderTotal()
    {
        return GetProductTotal() + GetShippingFee();
    }


    public string CreatePackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label:");
        label.AppendLine("______________________");

        foreach (Product product in products)
        {
            label.AppendLine(product.ToString());
        }
        return label.ToString();
    }

    public string CreateShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Shipping Label:");
        label.AppendLine("_____________________");
        label.AppendLine($"Customer: {customer.GetCustomerName()}");
        label.AppendLine(customer.GetCustomerAddress().GetFormattedAddress());

        return label.ToString();

    }

    public override string ToString()
    {
        return $"{CreateShippingLabel()}\n{CreatePackingLabel()}\nTotal: ${GetOrderTotal():F2}";
    }

}