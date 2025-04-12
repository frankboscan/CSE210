public class Customer{
	private string _name;
	private Address _address = new Address("", "", "", "");

	public Customer(string name, Address address){
		_name = name;
		_address = address;
	}

	public string GetName(){
		return _name;
	}

	public string GetAddress(){
		return _address.GetAddress();
	}
	
	public bool InUsa(){
		return _address.InUsa();
	}

	public double GetShippingCost(){
		if (_address.InUsa())
			return 0.0;
		else 
			return 35.0;
	}
}
