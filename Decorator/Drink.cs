namespace Arcaim.DesignPatterns.Decorator
{
    public abstract class Drink
    {
        protected string description = "Unknown drink";
        
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Price();
    }
}