using ShopLibrary;

#region ListVsArray
//int[] numbers = new int[5];

//for (int i = 0; i < 5; i++)
//{
//  numbers[i] = i;
//}

//foreach (var item in numbers)
//{
//  Console.WriteLine(item);
//}
//List<string> sList = new();
//sList.Add("JavaScript");
//sList.Add("Python");
//sList.Add("C#");
//sList.Sort();
//Console.WriteLine("Sortierte Liste:");
//foreach (var s in sList)
//{
//  Console.WriteLine(s);
//}
//sList.Insert(0, "C++");
//foreach (var s in sList)
//{
//  Console.WriteLine(s);
//}
//sList.Remove("C#");
//foreach (var s in sList)
//{
//  Console.WriteLine(s);
//}
//sList.Clear();

//Console.WriteLine(sList[1]);
#endregion


List<IProductModel> cart = AddSampleData();
CustomerModel customer = GetCustomer();

foreach (IProductModel product in cart)
{
  product.ShipItem(customer);
}


static CustomerModel GetCustomer()
{
  return new CustomerModel
  {
    FirstName = "Max",
    LastName = "Muster",
    City = "Heilbronn",
    EmailAddress = "mm@aol.de",
    PhoneNumber = "555-6273"
  };
}

List<IProductModel> AddSampleData()
{
  List<IProductModel> products = new();

  // Physical Products
  products.Add(new PhysicalProductModel { Title = "500GB Sata SSD" });
  products.Add(new PhysicalProductModel { Title = "1 TB M.2 SSD" });
  products.Add(new PhysicalProductModel { Title = "4 TB HDD 7200RPM" });

  // Digital Products
  products.Add(new DigitalProductModel { Title = "SE-GL Course" });
  products.Add(new DigitalProductModel { Title = "SE Vertiefung Course" });
  products.Add(new DigitalProductModel { Title = "Javascript Basics Course" });

  return products;
}