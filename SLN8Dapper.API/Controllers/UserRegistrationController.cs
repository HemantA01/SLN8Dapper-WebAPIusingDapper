using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SLN8Dapper.MODEL.ViewModel;
using SLN8Dapper.SERVICE.IService;

namespace SLN8Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistration _iuserregister;
        public UserRegistrationController(IUserRegistration iuserregister) 
        {
            _iuserregister= iuserregister;
        }
        #region Get all users list
        [HttpGet]
        public async Task<IActionResult> GetAllUsers() 
        {
            try
            {
                var getdetails = await _iuserregister.GetUsersList(1);
                if (getdetails == null)
                {
                    return NotFound("No record exists");
                }
                else
                {
                    return Ok(getdetails);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Get user details by Id
        [HttpGet, Route("get-userdetail")]
        public async Task<IActionResult> GetUsersById(int? userId)
        {
            try
            {
                var getdetail = await _iuserregister.GetUser(userId, 4);
                if (getdetail == null)
                {
                    return NotFound("No record exists");
                }
                else
                {
                    return Ok(getdetail);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Insert new user
        [HttpPost, Route("insert-newuser")]
        public async Task<IActionResult> InsertNewUser(UserRegistrationVM model)
        {
            try
            {
                var getStatus = await _iuserregister.RegisterUserAsync(model, 2);
                if (getStatus != null)
                {
                    return Ok(getStatus);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Update user details
        [HttpPut, Route("update-user")]
        public async Task<IActionResult> UpdateUser(UserRegistrationVM model, int? userId)
        {
            try
            {
                var getStatus = await _iuserregister.UpdateUserAsync(model, userId, 3);
                if (getStatus != null)
                {
                    return Ok(getStatus);
                }
                else
                {
                    return BadRequest();
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
