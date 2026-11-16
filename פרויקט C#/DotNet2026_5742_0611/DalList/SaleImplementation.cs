namespace DalList;

using DalFacade.DalApi;
using DO;

internal class SaleImplementation : ISale
{
    //הוספת מבצע לרשימת המבצעים ומחזירה את המספר שלו
    public int Create(Sale item)
    {
        Sale copy = item with { ID = DataSource.Config.NextSaleId };
        DataSource.Sales.Add(copy);
        return copy.ID;
    }
    //מחזירה את המבצע עם המספר המסויים אם לא קיים מחזירה null
    public Sale? Read(int id)
    {
        return DataSource.Sales.FirstOrDefault(s => s?.ID == id);
    }
    //מחזירה עותק של הרשימה של המבצעים
    public IEnumerable<Sale?> ReadAll()
    {
        return DataSource.Sales.ToList();
    }
    //מעדכנת מבצע
    public void Update(Sale item)
    {
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s?.ID == item.ID);
        if (existing == null)
            throw new KeyNotFoundException($"Sale with ID {item.ID} does not exist.");

        DataSource.Sales.Remove(existing);
        DataSource.Sales.Add(item);
    }
    // מוחקת את המבצע המבוקש מהרשימה
    public void Delete(int id)
    {
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s?.ID == id);
        if (existing == null)
            throw new KeyNotFoundException($"Sale with ID {id} does not exist.");

        DataSource.Sales.Remove(existing);
    }

}
