using AbstractFactory.Factory;
using System.Collections.Generic;

namespace AbstractFactory.Repo {
	public interface IRestService {

		List<ICompanyDto> GetCompanies();

	}
}