namespace DO;

public record Product
{
    //מזהה מוצר
    public int ID { get; init; }
    //שם מוצר
    public string Name { get; init; }
    //כטגוריית מוצר
    public Category Category { get; init; }
    //מחיר המוצר
    public double Price { get; init; }
    //כמות במלאי של המוצר
    public int InStock { get; init; }
    public Product()
    {
    }

    public Product(int id, string name, Category category, double price, int inStock)
    {
        this.ID = id;
        this.Name = name;
        this.Category = category;
        this.Price = price;
        this.InStock = inStock;
    }

}