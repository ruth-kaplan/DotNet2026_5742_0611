namespace DalList;

using DalFacade.DalApi;
using DO;

internal class ProductImplementation : IProduct
{
    //הוספת מוצר לרשימת המוצרים ומחזירה את המספר שלו
    public int Create(Product item)
    {
        Product copy = item with { ID = DataSource.Config.NextProductId };
        DataSource.Products.Add(copy);
        return copy.ID;
    }
    //מחזירה את המוצר עם המספר המסויים אם לא קיים מחזירה null
    public Product? Read(int id)
    {
        return DataSource.Products.FirstOrDefault(p => p?.ID == id);
    }
    //מחזירה עותק של הרשימה של המוצרים
    public IEnumerable<Product?> ReadAll()
    {
        return DataSource.Products.ToList();
    }
    //מעדכנת מוצר
    public void Update(Product item)
    {
        Product? existing = DataSource.Products.FirstOrDefault(p => p?.ID == item.ID);
        if (existing == null)
            throw new KeyNotFoundException($"Product with ID {item.ID} does not exist.");

        DataSource.Products.Remove(existing);
        DataSource.Products.Add(item);
    }
    // מוחקת את המוצר המבוקש מהרשימה
    public void Delete(int id)
    {
        Product? existing = DataSource.Products.FirstOrDefault(p => p?.ID == id);
        if (existing == null)
            throw new KeyNotFoundException($"Product with ID {id} does not exist.");

        DataSource.Products.Remove(existing);
    }
}