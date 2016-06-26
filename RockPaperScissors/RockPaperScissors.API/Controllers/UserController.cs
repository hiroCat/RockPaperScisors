using AutoMapper;
using RockPaperScissors.API.Models;
using RockPaperScissors.Contract.ServiceLibrary;
using RockPaperScissors.Contract.ServiceLibrary.DTO;
using System;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage Get()
        {
            try
            {
                var user = _userAppService.getUser();
                if (user == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Problem creating the user");
                return Request.CreateResponse(HttpStatusCode.OK, fromUserDTOToUser(user));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET 
        public HttpResponseMessage GetUser(long id)
        {
            try
            {
                var user = _userAppService.getUser(id);
                if (user == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No user found");
                return Request.CreateResponse(HttpStatusCode.OK, fromUserDTOToUser(user));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // POST 
        public IHttpActionResult ModifyUser(User user)
        {
            return Ok();
        }

        #endregion

        #region .: Private Methods :.

        private UserDto fromUserToUserDTO(User user)
        {
            var config = new MapperConfiguration(c => c.CreateMap<User, UserDto>());
            var mapper = config.CreateMapper();
            return mapper.Map<UserDto>(user);
        }

        private User fromUserDTOToUser(UserDto user)
        {
            var config = new MapperConfiguration(c => c.CreateMap<UserDto, User>());
            var mapper = config.CreateMapper();
            return mapper.Map<User>(user);
        }

        #endregion
    }
}
