namespace AbstractFactory.Factory {
	// Version independent Company Dto
	public interface ICompanyDto {
		string Name { get; set; }
		string Id { get; set; }
		string Address { get; set; }
	}
}