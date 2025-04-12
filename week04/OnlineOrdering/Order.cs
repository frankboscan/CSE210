public class Order{
	private Customer _customer;
	private List<Product> _products = new List<Product>();

	public Order(Customer customer, List<Product> products){
		_customer = customer;
		_products = products;
	}

	public double GetTotalCost(){
		double total = 0.0;
		foreach (Product p in _products)
			total += p.GetTotalCost();
		return total;
	}

	public string GetShippingLabel(){
		return "SHIPPING LABEL\n\n" +
			_customer.GetName() + "\n" +
			_customer.GetAddress();
	}

	public string GetPackingLabel(){
		string label = "PACKING LABEL\n\nname, (product ID)\n";
		foreach (Product p in _products)
			label += $"{p.GetName()} ({p.GetProductId()})\n";
		return label;
	}

	public double GetTotalWithShipping(){
		double cost = GetTotalCost();
		if (_customer.InUsa())
			return cost + 5;
		return cost + 35;
	}

	public string GetName(){
		return _customer.GetName();
	}
}
