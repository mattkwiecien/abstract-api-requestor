using System.Collections.Generic;

namespace AbstractFactory.API {
	internal class ApiV1 {
		public static string GetCompanies() {
			var entities = new List<ApiCompanyV1> {
				new ApiCompanyV1 {
					Name = "Test 1",
					Id = "1",
					Address = "1234 Fake Ave, Chicago, IL, 60606"
				},
				new ApiCompanyV1 {
					Name = "Test 2",
					Id = "2",
					Address = "1234 Fake Ave, Chicago, IL, 60606"
				},
				new ApiCompanyV1 {
					Name = "Test 3",
					Id = "3",
					Address = "1234 Fake Ave, Chicago, IL, 60606"
				},
			};

			return Newtonsoft.Json.JsonConvert.SerializeObject(entities);
		}
	}
}
