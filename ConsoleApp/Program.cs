using Domain.Models;
using Infrastructure.Services;
var grService = new GroupService();
while(true)
{
    
    System.Console.WriteLine("For creating group : list");
    System.Console.WriteLine("For creating group : add");
    System.Console.WriteLine("For creating group : edit");
    System.Console.WriteLine("For creating group : delete");
    System.Console.WriteLine("For creating group : exit");

    string command = Console.ReadLine();

    if (command == "add")
    {
        var group1 = new Group();
        group1.FirstName = Console.ReadLine();
        group1.LastName = Console.ReadLine();
        group1.BirthDay = Convert.ToDateTime(Console.ReadLine());
        group1.Salary = Convert.ToDecimal(Console.ReadLine());
        grService.CreateGroup(group1);
    }   
    else if (command == "list")
    {
        foreach (var item in grService.GetGroups())
        {
            System.Console.WriteLine(item.FirstName);
            System.Console.WriteLine(item.LastName);
            System.Console.WriteLine(item.BirthDay);
            System.Console.WriteLine(item.Salary);
            System.Console.WriteLine("-----------------------");
        }
    }
    else if (command == "edit")
    {
        var group1 = new Group();
        group1.FirstName = Console.ReadLine();
        group1.LastName = Console.ReadLine();
        group1.BirthDay = Convert.ToDateTime(Console.ReadLine());
        group1.Salary = Convert.ToDecimal(Console.ReadLine());
        System.Console.WriteLine(grService.UpdateGroup(group1));
    }
    else if (command == "delete")
    {
        string firstName = Console.ReadLine();
        System.Console.WriteLine(grService.DeleteGroup(firstName));
    }
    else if (command == "exit") break;
}





