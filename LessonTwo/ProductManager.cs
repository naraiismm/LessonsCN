

class ProductManager
{
    public ProductManager()
    {
        Console.WriteLine("hello world");
    }
    public ProductManager(string test)
    {
        
    }
    public void AddToCart(Product product)
    {
        Console.WriteLine($"uuuuuuuuuuuuuuuu{product.ProductName} adli mehsul sebete elave olundu,qiymeti:{(product.IsDiscount? product.DiscountPrice : product.UnitPrice)}");
    }
}

