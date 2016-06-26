using AutoMapper;
using RockPaperScissors.Contract.ServiceLibrary;
using RockPaperScissors.Contract.ServiceLibrary.DTO;
using RockPaperScissors.Contract.ServiceLibrary.Entities;
using RockPaperScissors.Impl.ServiceLibrary.Helpers;
using RockPaperScissors.Impl.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Impl.ServiceLibrary.Services
{
    public class GameAppService : IGameAppService
    {
        public Random _random;
        public IRockPaperScissorsRepository _repository;

        #region .: Public methods :.

        public GameAppService(Random random, IRockPaperScissorsRepository repository)
        {
            _random = random;
            _repository = repository;
        }

        public MoveDto getMove(long id)
        {
            return fromMoveEntityToMoveDTO(_repository.getMove(id));
        }

        public MoveDto makeMove(MoveDto moveDto)
        {
            var moveEntity = getMoveFromIA(fromMoveDTOToMoveEntity(moveDto));
            _repository.saveMove(moveEntity);
            return fromMoveEntityToMoveDTO(moveEntity);
        }

        public MoveDto makeMove(IEnumerable<MoveDto> moves)
        {
            var moveEntity = getMoveFromIA(fromMoveDTOToMoveEntity(moves).ToList());
            _repository.saveMove(moveEntity);
            return fromMoveEntityToMoveDTO(moveEntity);
        }

        #endregion

        #region .: Private methods :.

        private MoveEntity getMoveFromIA(MoveEntity move)
        {
            var iaMove = getIaMove(move);
            move.computerMove = iaMove;
            move.playerWins = GameAppHelpers.getPlayerWins(iaMove, move.humanMove, move.gameType);
            return move;
        }

        private MoveEntity getMoveFromIA(IList<MoveEntity> moves)
        {
            var iaMove = getIaMove(moves);
            var lastMove = moves[moves.Count-1];

            lastMove.computerMove = iaMove;
            lastMove.playerWins = GameAppHelpers.getPlayerWins(iaMove, lastMove.humanMove, lastMove.gameType);
            return lastMove;
        }

        private int getIaMove(MoveEntity move)
        {
            if (move.difficultyType <= 1) //User always wins (0,1)
            {
                return GameAppHelpers.getMove(move.humanMove, move.gameType, 0);
            }

            if (move.difficultyType <= 5) //We use the random factor (2,5)
            {
                int gameMod = (int)GameModes.ClassicGameMove;
                if (move.gameType == 1)
                    gameMod = (int)GameModes.SpockGameMove;
                return _random.Next(0, gameMod-1);
            }

            if (move.difficultyType > 9) //User ALWAYS looses (10)
            {
                return GameAppHelpers.getMove(move.humanMove, move.gameType, 1);
            }

            return GameAppHelpers.getMove(move.humanMove, move.gameType,_random.Next(0,2));
        }

        private  int getIaMove(IList<MoveEntity> moves)
        {
            // future change to a mean prediction 
            return getIaMove(moves[moves.Count - 1]);
        }

        #region Mappers

        private MoveDto fromMoveEntityToMoveDTO(MoveEntity move)
        {
            var config = new MapperConfiguration(c => c.CreateMap<MoveEntity, MoveDto>());
            var mapper = config.CreateMapper();
            return mapper.Map<MoveDto>(move);
        }

        private MoveEntity fromMoveDTOToMoveEntity(MoveDto move)
        {
            var config = new MapperConfiguration(c => c.CreateMap<MoveDto, MoveEntity>());
            var mapper = config.CreateMapper();
            return mapper.Map<MoveEntity>(move);
        }

        private IEnumerable<MoveEntity> fromMoveDTOToMoveEntity(IEnumerable<MoveDto> move)
        {
            var config = new MapperConfiguration(c => c.CreateMap<MoveDto, MoveEntity>());
            var mapper = config.CreateMapper();
            yield return mapper.Map<MoveEntity>(move);
        }
        #endregion

        #endregion
    }
}
