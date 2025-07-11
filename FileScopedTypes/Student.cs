using System.Runtime.CompilerServices;

namespace FileScopedTypes;

internal class Student
{
    public string GetStudentAddress()
    {
        return new Address().ReturnAddressDetails();
    }
}

file class Address
{
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string PostalCode { get; set; }

    public Address()
    {
        Address1 = "3012 William Nicol Drive";
        Address2 = "Bryanston";
        Address3 = "Johannesburg";
        PostalCode = "2191";
    }

    public string ReturnAddressDetails()
    {
        return PostalCode.StringIsInt() 
            ? $"{Address1}\n{Address2}\n{Address3}\n{PostalCode}" 
            : throw new Exception("Invalid address");
    }
}

file static class ClassExtensions
{
    public static bool StringIsInt(this string value)
    {
        return int.TryParse(value, out _);
    }
}