using System;
using System.Collections.Generic;

namespace RockPaperScissors.Contract.ServiceLibrary.Entities
{
    public class UserEntity : BaseEntity
    {
        public List<MoveEntity> playsOfUser { get; set; }
        public DateTime createdUser { get; set; }
    }
}
