using Arcaim.DesignPatterns.NullObject.Entities;

namespace Arcaim.DesignPatterns.NullObject.Services
{
    public interface ILearnedService
    {
        ILearned GetLearnedById(int id);
    }
}