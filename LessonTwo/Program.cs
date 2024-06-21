
Product ProductOne = new()
            {
                ProductName = "Iphone 14 Pro Max",
                IsDelivery = true,
                DeliveryPrice = 5.00,
                UnitPrice = 2799.99,
                IsDiscount = true,
                DiscountPrice = 1799.99,
                IsCash = true,
                CashDiscount = 180.0


            };



            Product ProductTwo = new()
            {
                ProductName = "Iphone 14 Pro Max",
                IsDelivery = true,
                DeliveryPrice = 5.00,
                UnitPrice = 2799.99,
                IsDiscount = true,
                DiscountPrice = 1799.99,
                IsCash = true,
                CashDiscount = 180.0


            };


            Product ProductThree = new()
            {
                ProductName = "Iphone 14 Pro Max",
                IsDelivery = true,
                DeliveryPrice = 5.00,
                UnitPrice = 2799.99,
                IsDiscount = false,
                DiscountPrice = 1799.99,
                IsCash = true,
                CashDiscount = 180.0


            };



            Product ProductFour = new()
            {
                ProductName = "Iphone 14 Pro Max",
                IsDelivery = true,
                DeliveryPrice = 5.00,
                UnitPrice = 2799.99,
                IsDiscount = false,
                DiscountPrice = 1799.99,
                IsCash = true,
                CashDiscount = 180.0


            };
            Product[] products= { ProductOne, ProductTwo, ProductThree, ProductFour };
            foreach(Product item in products)
            {
                Console.WriteLine($"{item.ProductName}  {item.CashDiscount}   {item.DiscountPrice}");
                ProductManager productManager = new();
                productManager.AddToCart(item);

            }









