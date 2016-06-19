using RockPaperScisors.Contracts.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RockPaperScisors.Controllers
{
    public class GameController : ApiController
    {
        #region .: Properties :.

        private IUserAppService _userAppService;
        private IGameAppService _gameAppService;

        #endregion

        #region .: Constructor :.

        public GameController(IUserAppService userAppService , IGameAppService gameAppService)
        {
            _userAppService = userAppService;
            _gameAppService = gameAppService;
        }

        #endregion

        #region .: Public Methods :.

        public IHttpActionResult GetUser(long id)
        {
            return Ok();
        }

        #endregion

        #region .: Private Methods :.

        #endregion
    }
}
