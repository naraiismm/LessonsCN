

using MarketProject;

List<Users> cashier=new List<Users>();
List<Users> seller = new List<Users>();
List<Users> admin = new List<Users>();
List<Product> products = new List<Product>();
List<Product>sellingList = new List<Product>();

AdminManager adminManager = new AdminManager();
CashierManager cashierManager = new CashierManager();

// Create a Product object
Product product1 = new Product
{
    Id = 1,
    ProductName = "Sample Product",
    UnitPrice = 10.99,
    
};
Product product2 = new Product
{
    Id = 2,
    
    ProductName = "Cay",
    };

Product product4= new Product
{
    Id = 2,

    ProductName = "Cay",
};

Product product3 = new Product
{
    Id = 4,
    ProductName = "ciyelek",
    UnitPrice=10


};


adminManager.AddProduct(product1, products);
adminManager.AddProduct(product2, products);
adminManager.AddProduct(product3, products);

//adminManager.RemoveProduct(product1, products);
//adminManager.GetAll(products);

//adminManager.GetById(10,products);

//Product updatedProduct = new Product { Id = 1, ProductName = "Updated Laptop", UnitPrice = 1099.99};

//adminManager.Update(1, updatedProduct,products);

//adminManager.GetAll(products);
//adminManager.GetByCatagory(2,products);

SellerManager sellerManager = new SellerManager();
sellerManager.Selling(product1, products,sellingList);
adminManager.GetAll(products);
cashierManager.ReturnTheSellingProduct(sellingList,products);
adminManager.GetAll(products);

