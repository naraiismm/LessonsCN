

//operation class -serviceclass,buisness class emeliyyatlari 

using LessonThree;

Product productOne  = new Product() { Id=1,ProductName="Iphone", Description="8 gbram,256 gb yaddas ,reng=qara",UnitPrice=2300,PhotoUrl="img1.png"};

Product productTwo = new Product() { Id = 2, ProductName = "HP envy x360", Description = "16 gbram,256 gb yaddas ,i7-13th,reng=qara",UnitPrice=4000 };



ProductManager productManager = new ProductManager();

productManager.ProductAddtoCart(productOne);
productManager.ProductAddtoCart(productTwo);
productManager.GetProduct(productOne);


Calculations calculate=new ();
calculate.Plus(3, 5);
Console.WriteLine(calculate.PlusTwo(4,5));


