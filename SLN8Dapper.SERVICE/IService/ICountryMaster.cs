using SLN8Dapper.MODEL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.SERVICE.IService
{
    public interface ICountryMaster
    {
        Task<List<CountryMasterVM>> GetAllCountries();
        Task<int> AddCountries(CountryMasterVM model);
        Task<int> UpdateCountry(int Id, CountryMasterVM model);
        Task<int> DeleteCountry(int Id);
    }
}
