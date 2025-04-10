public class Order{
	private Customer _customer;
	private List<Product> _products = new List<Product>();

	public Order(Customer customer, List<Product> products){
		_customer = customer;
		_products = products;
	}

	public double GetTotalCost(){
		int total = 0;
		foreach (Product p in _products)
			total += p.GetTotalCost();
		return total;
	}

	public string GetShippingLabel(){
		return $"{_customer.GetName()}\n{_customer.GetWholeAddress()}";
}
