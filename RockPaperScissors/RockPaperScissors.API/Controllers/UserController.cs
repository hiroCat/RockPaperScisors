using RockPaperScissors.API.Models;
using RockPaperScissors.Contract.ServiceLibrary;
using System.Web.Http;

namespace RockPaperScissors.API.Controllers
{
    public class UserController : ApiController
    {
        #region .: Properties :.

        private IUserAppService _userAppService;

        #endregion

        #region .: Constructor :.

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        #endregion

        #region .: Public Methods :.

        // GET 
        public IHttpActionResult GetUser(long id)
        {
            return Ok();
        }

        // POST 
        public IHttpActionResult ModifyUser(User user)
        {
            return Ok();
        }

        #endregion

        #region .: Private Methods :.

        #endregion
    }
}
