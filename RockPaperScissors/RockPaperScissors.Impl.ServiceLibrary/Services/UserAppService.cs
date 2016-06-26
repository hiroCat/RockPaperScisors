using AutoMapper;
using RockPaperScissors.Contract.ServiceLibrary;
using RockPaperScissors.Contract.ServiceLibrary.DTO;
using RockPaperScissors.Contract.ServiceLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Impl.ServiceLibrary.Services
{
    public class UserAppService : IUserAppService
    {
        #region .: Public methods :.

        public UserDto getUser()
        {
            var newUser = new UserEntity
            {
                createdUser = DateTime.Now,
                playsOfUser = new List<MoveEntity>()
            };
            return fromUserEntityToUserDTO(newUser);
        }

        public UserDto getUser(long id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region .: Private methods :.

        private UserDto fromUserEntityToUserDTO(UserEntity user)
        {
            var config = new MapperConfiguration(c => c.CreateMap<UserEntity, UserDto>());
            var mapper = config.CreateMapper();
            return mapper.Map<UserDto>(user);
        }

        private UserEntity fromUserDTOToUserEntity(UserDto user)
        {
            var config = new MapperConfiguration(c => c.CreateMap<UserDto, UserEntity>());
            var mapper = config.CreateMapper();
            return mapper.Map<UserEntity>(user);
        }

        #endregion

    }
}
