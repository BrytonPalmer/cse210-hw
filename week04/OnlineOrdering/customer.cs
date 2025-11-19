// Constructor:
//     Customer(string name, Address address)

//         Properties:
//             string customerName
//             Address address

//         methods:
//             getCustomerName(): string
//             getCustomerAddress(): Address

using System.Net.Sockets;

class Customer
{
    private string customerName;
    private Address address;
    public Customer(string aCustomerName, Address address)
    {
        customerName = aCustomerName;
        this.address = address;
    }

    public string GetCustomerName()
    {
        return customerName;
    }

    public Address GetCustomerAddress()
    {
        return address;
    }

    public bool InTheUSA()
    {
        return address.InTheUSA();
    }

}