namespace Arcaim.DesignPatterns.NullObject.Entities
{
    public class NullLearned : ILearned
    {
        public int Id => -1;
        public string Name => "Unknown name";

        public string Surname => "Unknow surname";
    }
}