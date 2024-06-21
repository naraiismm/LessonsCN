using Homework1;

Product productOne = new() 

{
    Id = 1,
    ProductName="Iphone 14 Pro Max",
    ImgUrl="img1.jpg",
    Description="6 gb ram,memory-128gb,color=black",
    UnitPrice=3000,
    IsDelivery=true,
    DeliveryPrice=3.00,
    IsDiscount=true,
    DiscountPrice=2500,
    
};


Product productTwo = new()

{
    Id = 2,
    ProductName = "Iphone X Max",
    ImgUrl = "img2.jpg",
    Description = "8 gb ram,memory=256gb,color=white",
    UnitPrice = 1000,
    IsDelivery = true,
    DeliveryPrice = 5.00,
    IsDiscount = false,
    DiscountPrice = 900,

};
ProductManager productManager = new();


Product[] array = {productOne, productTwo};



Console.WriteLine("Mehsulun adini daxil edin: ");
string productName=Console.ReadLine();

int k = 0;

for (int i = 0; i < array.Length; i++)
{
    if (productName == array[i].ProductName)
    {
        productManager.ShowProduct(array[i]);
        ++k; 
    }
    
}


if (k == 0)
{
    Console.WriteLine("Bele bir mehsul yoxdur.\n1-mehsulu elave et\n2-cixis et\n3-butun mehsuallari goster");
    string number=Console.ReadLine();
    while (number == "1")
    {
        Product newProduct = new();

        Console.WriteLine("Mehsulun ID'sini daxil edin: ");
        newProduct.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Mehsulun adini daxil edin: ");
        newProduct.ProductName = Console.ReadLine();

        Console.WriteLine("Mehsulun sekil URL'sini daxil edin: ");
        newProduct.ImgUrl = Console.ReadLine();    

        Console.WriteLine("Mehsulun catdirilma xusisiyyetini daxil edin (true/false): ");
        newProduct.IsDelivery = Convert.ToBoolean(Console.ReadLine());
        if(newProduct.IsDelivery == true)
        {
            Console.WriteLine("Mehsulun catdirilma qiymetini daxil edin:");
            newProduct.DeliveryPrice = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Mehsulun endirim xusisiyyetini daxil edin (true/false): ");
        newProduct.IsDiscount = Convert.ToBoolean(Console.ReadLine());
        if (newProduct.IsDiscount == true)
        {
            Console.WriteLine("Mehsulun endirimli qiymetini daxil edin:");
            newProduct.DiscountPrice = Convert.ToDouble(Console.ReadLine());    
        }

        // Array kecmediyimiz ucun yeni product nece elave edeim bilmedim ve asagidaki iki setri internetden tapdim

        //////////////////////////////////////////////////////////
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = newProduct;
        //////////////////////////////////////////////////////////

        Console.WriteLine("Yeni mehsul elave edildi:");
        productManager.ShowProduct(newProduct);



        Console.WriteLine("Yeniden secim edin 1  2  ve ya 3");
        number=Console.ReadLine();
    }
    if(number == "2") { Console.WriteLine("Programdan cixis edin"); }
    else if (number=="3") 
    { for(int j=0;j<array.Length;j++)
        {
            Console.WriteLine("--------------------------------------------------------------");
            productManager.ShowProduct(array[j]);
            
        }
    }
    else
    {
        Console.WriteLine("Yanlis secim");
    }
}


