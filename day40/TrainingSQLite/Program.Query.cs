using Microsoft.EntityFrameworkCore;

namespace TrainingSQLite;

public partial class Program
{
    static void QueryingCategories()
    {
        using (Northwind db = new())
        {
            var categories = db.categories?
                            .Include(c => c.Products);
            if (categories == null || !categories.Any())
            {
                Fail("No Categories found");
            }
        }
    }
}
