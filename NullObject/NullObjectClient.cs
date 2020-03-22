using Arcaim.DesignPatterns.NullObject.Entities;
using Arcaim.DesignPatterns.NullObject.Services;
using Arcaim.DesignPatterns.NullObject.View;

namespace Arcaim.DesignPatterns.NullObject
{
    public static class NullObjectClient
    {
        public static void Run()
        {
            ILearnedService learnedService = new LearnedService();
            ILearned learned = learnedService.GetLearnedById(1);

            var view = new LearnedView(learned);
            view.RenderView();
        }
    }
}