using AbstractFactory.Factory;
using System.Collections.Generic;

namespace AbstractFactory.Repo {
	internal class RestService : IRestService {

		private IApiDtoFactory _dtoFactory;
		private IWebClient _webClient;

		public RestService(IWebClient webClient, IApiDtoFactory dtoFactory) {
			_dtoFactory = dtoFactory;
			_webClient = webClient;
		}

		public List<ICompanyDto> GetCompanies()  {
			var responseJson = _webClient.GetCompanyResponse();
			var companyDtoList = _dtoFactory.CreateCompanyDtos(responseJson);
			return companyDtoList;
		}

	}
}
