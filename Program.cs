using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Would you like to generate badges using the API?  Press Y if so:");
    string res = Console.ReadLine();

    List<Employee> employees;

    if(res == "Y" | res=="y"){
      employees = PeopleFetcher.GetFromApi();
    } else {
      employees = PeopleFetcher.GetEmployees();
    }

    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
    Util.MakeBadges(employees);
  }
}
}