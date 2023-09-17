using SLN8Dapper.MODEL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.SERVICE.IService
{
    public interface IUserRegistration
    {
        Task<int> RegisterUserAsync(UserRegistrationVM model, int? action);
        //// Task<List<CountryMasterViewModel>> GetCountriesList();
        //// Task<List<CountryStateMasterViewModel>> GetStatesList();
        Task<List<UserRegistrationVM>> GetUsersList(int? action);
        Task<UserRegistrationVM> GetUser(int? userId, int? action);
        Task<int?> UpdateUserAsync(UserRegistrationVM model, int? userId, int? action);
        //Task<int?> UpdateFieldsAsync(UserRegistrationVM model, int? userId);
        ////Task<int> RegisterUserAsync(UserRegistrationViewModel model, IFormFile file);
    }
}
