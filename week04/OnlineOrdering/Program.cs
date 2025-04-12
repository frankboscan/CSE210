using System;

class Program{
	static void Main(string[] args){
		string name0 = "Jose Perales", name1 = "Luis Perales";
		Address address0 = new Address("1 Main St.", "Provo", "UT", "USA");
		Address address1 = new Address("2 E St.", "Wilson", "QC", "Canada");
		Customer customer0 = new Customer(name0, address0);
		Customer customer1 = new Customer(name1, address1);
		List<Product> products0 = new List<Product>();
		List<Product> products1 = new List<Product>();
		products0.Add(new Product("milk", "AL2F", 1.23, 1));
		products0.Add(new Product("eggs", "GL3Z", 2.47, 1));
		products0.Add(new Product("meat", "UZ9P", 9.02, 1));
		products1.Add(new Product("gum", "BI1F", 0.99, 1));
		products1.Add(new Product("milk", "AL2F", 1.23, 1));
		Order order0 = new Order(customer0, products0);
		Order order1 = new Order(customer1, products1);

                Console.WriteLine($"Order 0: {order0.GetName()}\n");
                Console.WriteLine($"{order0.GetPackingLabel()}");
                Console.WriteLine($"{order0.GetShippingLabel()}");
                Console.WriteLine($"\nTotal: ${order0.GetTotalWithShipping()}");

		Console.WriteLine($"\n\nOrder 1: {order1.GetName()}\n");
		Console.WriteLine($"{order1.GetPackingLabel()}");
		Console.WriteLine($"{order1.GetShippingLabel()}");
		Console.WriteLine($"\nTotal: ${order1.GetTotalWithShipping()}");
	}
}
