using Lesson_8;

MyCollection collection = new MyCollection();

for (int i = 0; i < collection.Count(); i++)
{
    bool tryCatch = true;

    while(tryCatch == true)
    {
        try
        {
            Console.WriteLine($"Enter {i} value of Array");
            var value = Convert.ToInt16(Console.ReadLine());
            collection.Add(value, i);
            tryCatch = false;
        }
        catch
        {
            Console.WriteLine("Try again.");
            tryCatch = true;
        }
        
    }
  
}
bool cont = true;

while (cont == true)
{
    string menu = Menu.Menu1();
    
    switch (menu)
    {
        case "1":
            collection.ShowAllArray();
            cont = Menu.Continue();
            break;

        case "2":
            Console.WriteLine("Enter number of value");
            int j = Convert.ToInt16(Console.ReadLine());
            collection.ShowValueOfArray(j);
            cont = Menu.Continue();
            break;

        case "3":
            cont = Menu.Continue();
            break;

        case "4":
            Console.WriteLine($"Length of Array is { collection.Count()}");
            cont = Menu.Continue();
            break;

    }
}

