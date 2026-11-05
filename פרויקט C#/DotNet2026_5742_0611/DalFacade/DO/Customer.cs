namespace DO;

public record Customer
{
    //מזהה לקוח
    public int ID { get; init; }
    //שם לקוח
    public string Name { get; init; }
    //כתובת לקוח
    public string Address { get; init; }
    //טלפון לקוח
    public string Phone { get; init; }
    public Customer()
    {
    }
    public Customer(int id, string name, string address, string phone)
    {
        this.ID = id;
        this.Name = name;
        this.Address = address;
        this.Phone = phone;
    }
}
