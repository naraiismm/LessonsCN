


string[] names = new string[] { "Murad", "Elmir", "Abbas" };

Array.Sort(names);
foreach (string name in names)
{
    Console.WriteLine(name);
}

string[,] colors = 
{
    { "red", "blue ","green" },
    {"black","pink"," silver" }
};

for (int i = 0; i < colors.GetLength(0); i++)
{
    for (int j = 0; j < colors.GetLength(1); j++)
    {
        Console.WriteLine(colors[i,j]);
    }
        
    
}

Console.WriteLine(colors[0, 2]);