namespace AbstractFactory.Factory {
	public class CompanyV2 : ICompanyDto {
		public string Name { get; set; }
		public string Id { get; set; }
		public string StAddress { get; set; }
		public string City { get; set; }
		public string St { get; set; }
		public string Zip { get; set; }

		//Address was removed and broken into multiple properties in API V2
		public string Address {
			get {
				return $"{StAddress}, {City}, {St}, {Zip}";
			}
			set {
				// Do nothing
			}
		}
	}
}