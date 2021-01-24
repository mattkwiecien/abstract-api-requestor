using AbstractFactory.Factory;

namespace AbstractFactory.BusinessObject {
	internal class Company : ICompany {

		private ICompanyDto _dto;
		public Company(ICompanyDto CompanyDto) {
			_dto = CompanyDto;
		}

		public string Name { get => _dto.Name; set => _dto.Name = value; }
		public string Id { get => _dto.Id; set => _dto.Id = value; }
		public string Address { get => _dto.Address; set => _dto.Address = value; }
	}
}
