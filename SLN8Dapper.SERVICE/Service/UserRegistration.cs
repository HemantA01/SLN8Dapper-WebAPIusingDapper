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
using static System.Collections.Specialized.BitVector32;

namespace SLN8Dapper.SERVICE.Service
{
    public class UserRegistration : IUserRegistration
    {
        private readonly DapperContext _context;
        public UserRegistration(DapperContext context)
        {
            _context = context;
        }
        #region Get All users list
        public async Task<List<UserRegistrationVM>> GetUsersList(int? action)
        {
            try
            {
                DynamicParameters param = new();
                param.Add("@Action", action);
                using (IDbConnection conn = _context.CreateConnection())
                {
                    var getallusers = await conn.QueryAsync<UserRegistrationVM>("sp_UserRegistration", param, commandType: CommandType.StoredProcedure);
                    return getallusers.ToList();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Get individual user list
        public async Task<UserRegistrationVM> GetUser(int? userId, int? action)
        {
            try
            {
                DynamicParameters param = new();
                param.Add("@Id", userId);
                param.Add("@Action", action);
                using (IDbConnection conn = _context.CreateConnection())
                {
                    var getdetail = await conn.QuerySingleAsync<UserRegistrationVM>("sp_UserRegistration", param, commandType: CommandType.StoredProcedure);
                    return getdetail;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Insert new user
        public async Task<int> RegisterUserAsync(UserRegistrationVM model, int? action)
        {
            try
            {
                int getdetails = -1;
                DynamicParameters param = new();
                param.Add("@Firstname", model.Firstname);
                param.Add("@Lastname", model.Lastname);
                param.Add("@UserContact", model.UserContact);
                param.Add("@EmailId", model.EmailId);
                param.Add("@BirthDate", model.BirthDate);
                param.Add("@Gender", model.Gender);
                param.Add("@Nationality", model.Nationality);
                param.Add("@TempAddress", model.TempAddress);
                param.Add("@PermanentAddress", model.PermanentAddress);
                param.Add("@CountryId", model.CountryId);
                param.Add("@StateId", model.StateId);
                param.Add("@City", model.City);
                param.Add("@CreatedBy", model.CreatedBy);
                param.Add("@Action", action);
                using (IDbConnection conn = _context.CreateConnection())
                {
                    getdetails = await conn.ExecuteAsync("sp_UserRegistration", param, commandType: CommandType.StoredProcedure);
                    return getdetails;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Update user details
        public async Task<int?> UpdateUserAsync(UserRegistrationVM model, int? userId, int? action)
        {
            try
            {
                int getdetails = -1;
                DynamicParameters param = new();
                param.Add("@Id", userId);
                param.Add("@Firstname", model.Firstname);
                param.Add("@Lastname", model.Lastname);
                param.Add("@UserContact", model.UserContact);
                param.Add("@EmailId", model.EmailId);
                param.Add("@BirthDate", model.BirthDate);
                param.Add("@Gender", model.Gender);
                param.Add("@Nationality", model.Nationality);
                param.Add("@TempAddress", model.TempAddress);
                param.Add("@PermanentAddress", model.PermanentAddress);
                param.Add("@CountryId", model.CountryId);
                param.Add("@StateId", model.StateId);
                param.Add("@City", model.City);
                param.Add("@ModifiedBy", model.CreatedBy);
                param.Add("@Action", action);
                using (IDbConnection conn = _context.CreateConnection())
                {
                    getdetails = await conn.ExecuteAsync("sp_UserRegistration", param, commandType: CommandType.StoredProcedure);
                    return getdetails;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
