using AbstractFactory.BusinessObject;
using AbstractFactory.Factory;
using System.Collections.Generic;

namespace AbstractFactory.Repo {
	internal class MyRepo {
		
		private IRestService _restService;

		public MyRepo(int Version) {
			IApiDtoFactory dtoFac;
			IWebClient webClient;

			switch (Version) {
				case 1:
					dtoFac = new ApiDtoFactoryV1();
					webClient = new WebClientV1();
					break;
				case 2:
					dtoFac = new ApiDtoFactoryV2();
					webClient = new WebClientV2();
					break;
				default:
					dtoFac = new ApiDtoFactoryV1();
					webClient = new WebClientV1();
					break;
			}

			_restService = new RestService(webClient, dtoFac);
		}

		public List<ICompany> GetCompanies() {
			var companyDtos = _restService.GetCompanies();
			
			var companies = new List<ICompany>();
			foreach(var dto in companyDtos) {
				companies.Add(this.GetNewCompany(dto));
			}
			
			return companies;
		}

		public ICompany GetNewCompany(ICompanyDto dto) {
			return new Company(dto);
		}
	}
}
