namespace DalList;
using DO;

internal static class DataSource
{
    // רשימות הנתונים בזיכרון עבור כל ישות
    internal static List<Product?> Products { get; } = [];
    internal static List<Customer?> Customers { get; } = [];
    internal static List<Sale?> Sales { get; } = [];

    // מחלקה פנימית לניהול מספרים מזהים רצים אוטומטיים
    internal static class Config
    {
        // מספר התחלתי למזהה מוצר 
        internal const int StartProductId = 100000;
        private static int s_nextProductId = StartProductId;
        internal static int NextProductId => s_nextProductId++;

        // מספר התחלתי למזהה מבצע
        internal const int StartSaleId = 1000;
        private static int s_nextSaleId = StartSaleId;
        internal static int NextSaleId => s_nextSaleId++;
    }
}