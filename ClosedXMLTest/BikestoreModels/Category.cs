using System;
using System.Collections.Generic;

namespace ClosedXMLTest.BikestoreModels;

public partial class Category
{
    public int CategorySk { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
