using System.Collections.Generic;

namespace AbstractFactory.Factory {
	public interface IApiDtoFactory  {
		List<ICompanyDto> CreateCompanyDtos(string Json);
	}

}
