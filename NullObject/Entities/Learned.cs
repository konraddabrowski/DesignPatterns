namespace Arcaim.DesignPatterns.NullObject.Entities
{
    public class Learned : ILearned {
        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }

        public Learned (int id, string name, string surname) {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}