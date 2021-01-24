using System.Collections.Generic;

namespace AbstractFactory.API {
	internal class ApiV2 {
		public static string GetCompanies() {
			var entities = new List<ApiCompanyV2> {
				new ApiCompanyV2 {
					Name = "Test 1",
					Id = "1",
					StAddress = "1234 Fake Ave",
					City = "Chicago",
					St = "IL",
					Zip = "60606"
				},
				new ApiCompanyV2 {
					Name = "Test 2",
					Id = "2",
					StAddress = "1234 Fake Ave",
					City = "Chicago",
					St = "IL",
					Zip = "60606"
				},
				new ApiCompanyV2 {
					Name = "Test 3",
					Id = "3",
					StAddress = "1234 Fake Ave",
					City = "Chicago",
					St = "IL",
					Zip = "60606"
				},
			};

			return Newtonsoft.Json.JsonConvert.SerializeObject(entities);
		}
	}
}
