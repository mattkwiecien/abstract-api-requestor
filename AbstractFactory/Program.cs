using AbstractFactory.Repo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
	class Program {
		static void Main(string[] args) {

			// Get company list from V1 of API 
			var myRepo = new MyRepo(1);
			var companyList = myRepo.GetCompanies();

			// Get company list from V2 of API which has a different schema than V1.
			myRepo = new MyRepo(2);
			var companyList2 = myRepo.GetCompanies();

			Debugger.Break();
		}
	}
}
