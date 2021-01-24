using AbstractFactory.API;

namespace AbstractFactory.Repo {
	internal class WebClientV1 : IWebClient {
		public string GetCompanyResponse() {
			// mock web request 
			return ApiV1.GetCompanies();
		}
	}
}