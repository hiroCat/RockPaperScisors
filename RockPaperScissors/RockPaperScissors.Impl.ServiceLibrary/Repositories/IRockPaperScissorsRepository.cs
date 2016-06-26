using RockPaperScissors.Contract.ServiceLibrary.Entities;

namespace RockPaperScissors.Impl.ServiceLibrary.Repositories
{
    public interface IRockPaperScissorsRepository
    {
        MoveEntity getMove(long id);
        void saveMove(MoveEntity moveEntity);
    }
}
