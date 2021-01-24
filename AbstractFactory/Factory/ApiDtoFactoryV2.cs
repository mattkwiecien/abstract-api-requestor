using System.Collections.Generic;
using System.Linq;

namespace AbstractFactory.Factory {
	public class ApiDtoFactoryV2 : IApiDtoFactory {

		public List<ICompanyDto> CreateCompanyDtos(string Json) {
			var companyDtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CompanyV2>>(Json);
			return companyDtos.Cast<ICompanyDto>().ToList();
		}

	}

}
