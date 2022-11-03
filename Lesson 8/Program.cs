using Lesson_8;

MyCollection collection = new MyCollection();
MyCollection collection1 = new MyCollection();

bool tryCatch = true;
bool moreEnter = true;
int i = 0;

while (moreEnter == true)
{
    tryCatch = true;


    while (tryCatch == true)
    {
        try
        { 
            Console.WriteLine($"Enter {i} value of Array");
            var value = Convert.ToInt16(Console.ReadLine());
            collection.Add(value, i);
            i++;

            moreEnter = Menu.Continue();
            if (moreEnter == true)
            {
                collection.Increase();
            }
      
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
            Console.WriteLine($"{j} element of the Array is {collection.GetItem(j)}");
            
            cont = Menu.Continue();
            break;

        case "3":
            Console.WriteLine("Choose index of value to remove.");
            int remove = Convert.ToInt16(Console.ReadLine());
            collection.Remove(remove);
            collection.ShowRemovedArray();
            cont = Menu.Continue();
            break;

        case "4":
            Console.WriteLine($"Length of Array is { collection.Count()}");
            cont = Menu.Continue();
            break;

    }
}

 
