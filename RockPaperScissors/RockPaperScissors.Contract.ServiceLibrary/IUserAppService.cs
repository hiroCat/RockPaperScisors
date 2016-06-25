using RockPaperScissors.Contract.ServiceLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contract.ServiceLibrary
{
    public interface IUserAppService
    {
        UserDto getUser(long id);
        bool UpdateUser(UserDto user);
    }
}
