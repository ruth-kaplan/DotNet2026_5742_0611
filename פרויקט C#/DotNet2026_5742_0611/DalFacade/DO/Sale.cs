namespace DO
{
    public record Sale
    {
        //מזהה המבצע
        public int ID { get; init; }
        //מזהה המוצר
        public int ProductID { get; init; }
        //כמות נדרשת לקבלת המבצע
        public int RequiredQuantity { get; init; }
        //מחיר כולל במבצע
        public double TotalPrice { get; init; }
        //האם המבצע מיועד רק לחברי מועדון
        public bool IsForClubMembers { get; init; }
        //תאריך תחילת המבצע
        public DateTime StartDate { get; init; }
        //תאריך סיום המבצע
        public DateTime EndDate { get; init; }

        public Sale()
        {
        }
        public Sale
            (int id, int productId, int requiredQuantity, double totalPrice, bool isForClubMembers, DateTime startDate, DateTime endDate)
        {
            this.ID = id;
            this.ProductID = productId;
            this.RequiredQuantity = requiredQuantity;
            this.TotalPrice = totalPrice;
            this.IsForClubMembers = isForClubMembers;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
