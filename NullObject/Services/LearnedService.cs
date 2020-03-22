using System.Collections.Generic;
using System.Linq;
using Arcaim.DesignPatterns.NullObject.Entities;

namespace Arcaim.DesignPatterns.NullObject.Services
{
    public class LearnedService : ILearnedService
    {
        private LearnedRepo _repo = new LearnedRepo();

        public ILearned GetLearnedById(int id)
        {
            var learned = _repo.GetLearnedById(id);

            return learned is null ? new NullLearned() : learned;
        }

        class LearnedRepo
        {
            private readonly IList<ILearned> _learners = new List<ILearned>
            {
                new Learned(1, "Konrad", "Dąbrowski"),
                new Learned(2, "Marta", "Kwiatkowska"),
                new Learned(4, "Robert", "Lewandowski"),
                new Learned(2, "Aldona", "Osa")
            };

            internal ILearned GetLearnedById(int id)
            {
                return _learners.Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}