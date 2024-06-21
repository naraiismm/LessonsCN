

using Collection;
using System.Globalization;

Admin admin = new();


Console.WriteLine(">>>>>>>>Welcome to the program<<<<<<<<");

AdminManager adminManager = new ();
MenuManager menuManager = new  ();
SellerManager sellerManager = new ();   

List<string> drugs = new List<string>();



void MenuCommand()
{
    Console.WriteLine(">>>>1.Login");
    Console.WriteLine(">>>>2.Exit");
    Console.WriteLine("Pls choose a number:");
    String setCommant=Console.ReadLine();
    switch (setCommant)
    {
        case "1":AdminCredential();
            break;
        case "2":
            Console.WriteLine("Click to the enter button to exit"); ; 
            break;
        default:
            Console.WriteLine("wrong input");
            break;
    }
        

}
MenuCommand();



void AdminCredential()
{
    Console.WriteLine("ENter your userName:");
    admin.Username = Console.ReadLine();
    Console.WriteLine("ENter your password:");
    admin.Password = Console.ReadLine();
    bool isLogged = adminManager.AdminLogin(admin);
    if (isLogged)
    {
        menuManager.AddMenu();
        string number = Console.ReadLine();

        while (number != "6")
        {

            switch (number)
            {
                case "1":
                    Console.WriteLine("Enter seller Full name");
                    string sellerFullname = Console.ReadLine();
                    Console.WriteLine("Enter seller username");
                    string sellerusername = Console.ReadLine();
                    Console.WriteLine("Enter seller password");
                    string sellerPassword = Console.ReadLine();

                    Seller seller = new Seller()
                    {
                        Id = 1,
                        Name = sellerFullname,
                        Password = sellerPassword,
                        Username = sellerusername

                    };
                    adminManager.AddSeller(seller);
                    break;
                case "2":
                    Console.WriteLine("Enter  Medicine name");
                    string medicineName = Console.ReadLine();
                    Console.WriteLine("Enter medicine price");
                    double medicinePrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter medicine count");
                    int medicineCount = Convert.ToInt32(Console.ReadLine());

                    Products product = new Products()
                    {
                        Id = 1,
                        ProductName = medicineName,
                        Count = medicineCount,
                        Price = medicinePrice

                    };

                    drugs.Add(medicineName);
                    adminManager.AddMedicine(product);
                    break;
                case "3":


                    if (drugs.Count == 0)
                    {
                        Console.WriteLine("There is no drugs to remove.");
                        menuManager.AddMenu();
                    }
                    else
                    {
                        Console.WriteLine("Enter the drug that you want remove from the list");
                        Console.WriteLine("Name:");
                        string drugName = Console.ReadLine();
                        Console.WriteLine("Count:");
                        int drugCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Price:");
                        double drugPrice = Convert.ToDouble(Console.ReadLine());


                        Products product1 = new Products()
                        {
                            Id = 1,
                            ProductName = drugName,
                            Count = drugCount,
                            Price = drugPrice

                        };

                        drugs.Remove(drugName);
                        adminManager.RemoveMedicine(product1);
                    };
                    break;
                case "4":
                    foreach (var item in drugs)
                    {
                        Console.WriteLine(item);
                    }
                    if (drugs.Count == 0)
                    {
                        Console.WriteLine("There is no medicine");
                        menuManager.AddMenu();
                    }

                    break;
                case "5":
                    Console.WriteLine("You are a seller\n Enter ur name:");
                    string usernameInp = Console.ReadLine();
                    sellerManager.SellerMenu();
                    string number2 = Console.ReadLine();

                    while (number2 != "3")
                    {

                        switch (number2)
                        {

                            case "1":
                                Console.WriteLine("Enter  Medicine name");
                                string medicineNameForSeller = Console.ReadLine();
                                Console.WriteLine("Enter medicine price");
                                double medicinePriceForSeller = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter medicine count");
                                int medicineCountForSeller = Convert.ToInt32(Console.ReadLine());

                                Products product2 = new Products()
                                {
                                    Id = 1,
                                    ProductName = medicineNameForSeller,
                                    Count = medicineCountForSeller,
                                    Price = medicinePriceForSeller

                                };

                                drugs.Add(medicineNameForSeller);
                                adminManager.AddMedicine(product2);
                                break;

                            case "2":
                                foreach (var item in drugs)
                                {
                                    Console.WriteLine(item);
                                }

                                break;


                            default:
                                break;
                        }
                        sellerManager.SellerMenu();
                        number2 = Console.ReadLine();
                    }
                    break ;


            }

        }
    }
}









