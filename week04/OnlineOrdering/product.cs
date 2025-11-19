// Constructor:
//     Product(string productName, float price, int quantity)

//         Properties:
//             string productName
//             double productPrice
//             int quantity

//         methods:
//             getProductName(): string
//             getProductPrice(): double
//             getProductQuantity(): int

using System.Runtime.CompilerServices;

class Product
{
    private string productName;
    private double productPrice;
    private int quantity;
    private string id;



    public Product(string aProductName, double aProductPrice, int aQuantity, string aId)
    {
        productName = aProductName;
        productPrice = aProductPrice;
        quantity = aQuantity;
        id = aId;
        
    }

    public string GetProductName()
    {
        return productName;
    }

    public double GetProductPrice()
    {
        return productPrice;
    }

    public int GetProductQuantity()
    {
        return quantity;
    }

    public string GetProductId()
    {
        return id;
    }

    public override string ToString()
    {
        return $"Product Name: {productName}, Product ID: {id}";
    }
}