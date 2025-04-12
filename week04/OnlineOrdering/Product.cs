public class Product{
	private string _name, _productId;
	private double _price, _quantity;

	public Product(string name, string productId, double price, double quantity){
		_name = name;
		_productId = productId;
		_price = price;
		_quantity = quantity;
	}

	public string GetName(){
		return _name;
	}

	public string GetProductId(){
		return _productId;
	}

	public double GetTotalCost(){
		return _price * _quantity;
	}
}
