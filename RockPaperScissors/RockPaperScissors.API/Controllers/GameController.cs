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
    public class GameController : ApiController
    {
        #region .: Properties :.

        private IGameAppService _gameAppService;

        #endregion

        #region .: Constructor :.

        public GameController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }

        #endregion

        #region .: Public Methods :.

        // GET 
        public HttpResponseMessage GetMove(long id)
        {
            try
            {
                var move = _gameAppService.getMove(id);
                if (move == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No moves found");
                return Request.CreateResponse(HttpStatusCode.OK, fromMoveDTOToMove(move));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // POST 
        public HttpResponseMessage MakeMove(Move move)
        {
            try
            {
                var moveresponse = _gameAppService.makeMove(fromMoveToMoveDTO(move));
                if (moveresponse == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Problem making the move");
                return Request.CreateResponse(HttpStatusCode.OK, fromMoveDTOToMove(moveresponse));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        #endregion

        #region .: Private Methods :.

        private MoveDto fromMoveToMoveDTO(Move move)
        {
            var config = new MapperConfiguration(c => c.CreateMap<Move, MoveDto>());
            var mapper = config.CreateMapper();
            return mapper.Map<MoveDto>(move);
        }

        private Move fromMoveDTOToMove(MoveDto move)
        {
            var config = new MapperConfiguration(c => c.CreateMap<MoveDto, Move>());
            var mapper = config.CreateMapper();
            return mapper.Map<Move>(move);
        }

        #endregion
    }
}
