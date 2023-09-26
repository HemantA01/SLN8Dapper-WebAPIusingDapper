using Dapper;
using SLN8Dapper.DATA.DBContext;
using SLN8Dapper.MODEL.ViewModel;
using SLN8Dapper.SERVICE.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.SERVICE.Service
{
    public class CountryMaster : ICountryMaster
    {
        private readonly DapperContext _context;
        public CountryMaster(DapperContext context)
        {
            _context = context;
        }

        #region Get List of Countries
        public async Task<List<CountryMasterVM>> GetAllCountries()
        {
            try
            {
                DynamicParameters param = new();
                param.Add("@Action", 1);
                param.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
                using (IDbConnection conn = _context.CreateConnection())
                {
                    var getcountrieslist = await conn.QueryAsync<CountryMasterVM>("sp_CountryMaster", param, commandType: CommandType.StoredProcedure);
                    return getcountrieslist.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Insert country
        public Task<int> AddCountries(CountryMasterVM model)
        {
            try
            {
                return Task.FromResult(0);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Update country details
        public Task<int> UpdateCountry(int Id, CountryMasterVM model)
        {
            try
            {
                return Task.FromResult(0);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Delete country
        public Task<int> DeleteCountry(int Id)
        {
            try
            {
                return Task.FromResult(0);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
