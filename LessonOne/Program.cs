////using System.ComponentModel;

////Console.WriteLine("Hello, World!");

//////DRY - dont repeat yourself

//////datatype key_name = value

//////string - type, String - class (majority of datatype also have classes)

////string helloMessage = "Hello";

////byte num1 = 255;

////sbyte numberMax = sbyte.MaxValue;
////sbyte numberMin = sbyte.MinValue;
////Console.WriteLine(numberMax);
////Console.WriteLine(numberMin);

////string firstName = "Kenan";
////string lastName = "Ehmedli";
////short age = 17;
////string natioalId = "1DF6TGD";
//////eger riyazi bir sey olmayacaqsa string cunki int RAM  da yer tutur.
////string phone = "+994554555656";

////string[] test = { "Murad", "Musali" };

////var t1 = "salam";
////var t2 = new
////{
////    firstName = "Eli"
////};

////Console.WriteLine(t2.firstName);

////for (int i = 0; i < test.Length; i++)
////{
////    Console.WriteLine(test[i]);
////}

////object test2 = new
////{
////    name = "murad",
////    age = 34,
////};

/////*
////var test2Type = test2.GetType();
////var nameProperty = test2Type.GetProperty("name").GetValue(test2, null);
////Console.WriteLine(nameProperty);
////*/
////Console.WriteLine(test2);

////Console.WriteLine($"Ad: {firstName} Soyad: {lastName} " +
////    $"Telefon: {phone} Fin kod: {natioalId} Yas {age + 10}");


////bool test3 = true;
////Console.WriteLine(Convert.ToInt32(test3));

////bool isLogged = false;

////if (isLogged)
////{
////    Console.WriteLine("Account has been entered");
////}
////else Console.WriteLine("Account has not been entered");

////decimal num2 = -34.77m;
////float num2435 = -45.67f;

//////Control Flow Condition
//////Switch case, if else else if

//////bool isLogged2 = false;

//////if (isLogged2) Console.WriteLine("Welcome");
//////else Console.WriteLine("Enter the account");

////string username = "admin";
////string password = "admin123";

////Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>Admin panele giris<<<<<<<<<<<<<<<<<<<<<<<<<<<");
////Console.Write("Enter your user name ");
//////dynamic olsa duz olacaq Console Read ne olacagini bilmir ve ascii kodunu goturur
//////?- bos ola biler, sql ! - mutleq dolmalidi

////string? setUserName = Console.ReadLine();
////Console.Write("Enter your user password ");
////string? setPassword = Console.ReadLine();

//////if(setUserName != "" && setPassword != "")
//////{
//////    if(setUserName == username && setPassword == password)
//////    {
//////        Console.WriteLine($"{username} Xos gelmisiniz");
//////    }
//////    else
//////    {
//////        Console.WriteLine("username ve ya password yanlisdir");
//////    }

//////}
//////else
//////{
//////    Console.WriteLine("Bosh gonderile bilmez");
//////}
//////Ternary operation 

//////setUserName == username  ? 34 : 56;

//////switch daha suretli

////short defaultAge = short.Parse(Console.ReadLine());

////switch (defaultAge)
////{
////    case < 18:
////        Console.WriteLine("cizgi filmi");
////        break;
////    case <= 36:
////        Console.WriteLine("qorxu filmi");
////        break;
////    default:
////        Console.WriteLine("dram film");
////        break;
////}

//////switch (defaultAge)
//////{
//////    case short num_:
//////        Console.WriteLine("Yasinizi daxil edin");
//////        num_ = short.Parse(Console.ReadLine());
//////        Console.WriteLine(num_);
//////        break;

//////}

//////Console.WriteLine(setUserName);
//////Console.WriteLine(setUserName.GetType());


////// LOOOPsssssss  for, while, foreach(iterable), while, do while(loop control flow)
////string[] lessons = { "front", "backend", "mobile", "full-stack", "data science", "cyber", "AI" };
//////problemsiz(dynamic, object okdi) isleyir var(variable qisaltmasidi) array yaratmaq olmur
////dynamic[] array = { 34, "apple" };
//////++i bir basa artirib girir.

////for (int i = 0; i < lessons.Length; i++)
////{
////    Console.WriteLine(lessons[i]);
////}
//////MVC project


//string[] array = { "heello","jsns","djdksl" };
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}



//class Nara
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nanjssk");
//        SayHi("Mark",16);
//        SayHi("Mark", 15);
//        SayHi("Alex", 14);            //////////////////////////////////////////////////////////
//        SayHi("Mark", 16);

//    }
//    static void SayHi(string name,int age)
//    {
//        Console.WriteLine("Hello world Im "+name+" and Im "+age);
//    }
//};




//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(Cube(2));
//    }

//    static double Cube(double x)
//    {
//        double a = x * x * x;
//        return a;
//    }
//}




//Console.WriteLine("Pls enter the number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Pls enter the operation: ");
//string op=Console.ReadLine();


//Console.WriteLine("Pls enter the number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());


//if (op == "+")
//{
//    Console.WriteLine(num1+"+"+num2+"="+(num1+num2));
//}else if (op == "-")
//{
//    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
//}else if(op == "*")
//{
//    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
//}else if (op == "/")
//{
//    Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
//}
//else
//{
//    Console.WriteLine("Invalid operation" );
//}


//int dayNum=Convert.ToInt32(Console.ReadLine());
//string dayName;

//switch (dayNum)
//{
//    case 0:
//        dayName="Sunday";
//        break;
//    case 1:
//        dayName = "Monday";
//        break;
//    case 2:
//        dayName = "Tuesday";
//        break;
//    case 3:
//        dayName = "Wednsday";
//        break;
//    case 4:
//        dayName = "Thursday";
//        break;
//    case 5:
//        dayName = "Friday";
//        break;
//    case 6:
//        dayName = "Saturday";
//        break;
//    default:
//        dayName = "Invalid day number";
//        break;
//}
//Console.WriteLine(dayName);


//static void Main(string[] args)
//{
//    Console.WriteLine(GetDay(9));
//}

//static string GetDay(int dayNum)
//{
//    string dayName;
//    switch (dayNum)
//    {
//        case 0:
//            dayName = "Sunday";
//            break;
//        case 1:
//            dayName = "Monday";
//            break;
//        case 2:
//            dayName = "Tuesday";
//            break;
//        case 3:
//            dayName = "Wednsday";
//            break;
//        case 4:
//            dayName = "Thursday";
//            break;
//        case 5:
//            dayName = "Friday";
//            break;
//        case 6:
//            dayName = "Saturday";
//            break;
//        default:
//            dayName = "Invalid day number";
//            break;
//    }

//    return dayName;
//} 


//List<string> products = new List<string>();

//products.Add("owdj");
//products.Add("owdj");

string[] names = new string[] {"Amin","Elmir" ,"Ramin"};
Array.Sort(names);
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] numbers = new int[] { 1,4,6,8};
Array.Sort(numbers);
foreach (int number in numbers)
{
    
}


//MUlti array

int[,] array =  

{
    { 1,2,3 },
    {4,5,6 }
};

foreach (int number in array)
{
    Console.WriteLine(number);
}



