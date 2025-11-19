// Address(string streetAddress, string city, string stateProvince, string country)

//             Properties:
//                 string streetAddress
//                 string city
//                 string stateProvince
//                 string country

//             methods:
//                 getStreetAddress(): string
//                 getCity(): string
//                 getStateProvince(): string
//                 getCountry(): string

using System.Diagnostics;
using System.Security.Cryptography;

class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    private const string USA_COUNTRY = "USA";

    public Address(string aStreetAddress, string aCity, string aStateProvince, string aCountry)
    {
        streetAddress = aStreetAddress;
        city = aCity;
        stateProvince = aStateProvince;
        country = aCountry;
    }

    public string GetStreetAddress()
    {
        return streetAddress;
    }

    public string GetCity()
    {
        return city;
    }

    public string GetStateProvince()
    {
        return stateProvince;
    }

    public string GetCountry()
    {
        return country; 
    }

    public bool InTheUSA()
    {
       return country.ToUpper() == USA_COUNTRY;
    }
    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}\n{stateProvince}\n{country}";
    }

    public string GetFormattedAddress()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}