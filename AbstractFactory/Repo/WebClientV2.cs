using AbstractFactory.API;

namespace AbstractFactory.Repo {
	internal class WebClientV2 : IWebClient {
		public string GetCompanyResponse() {
			// mock web request 
			return ApiV2.GetCompanies();
		}
	}
}