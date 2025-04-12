public class Address{
	private string _streetAddress, _city, _stateProvince, _country;

	public Address(string street, string city, string state, string country){
		_streetAddress = street;
		_city = city;
		_stateProvince = state;
		_country = country;
	}

	public bool InUsa(){
		return _country == "USA";
	}

	public string GetAddress(){
		return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
	}
}
