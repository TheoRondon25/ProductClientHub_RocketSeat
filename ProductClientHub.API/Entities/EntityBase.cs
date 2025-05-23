namespace ProductClientHub.API.Entities
{
    public abstract class EntityBase
    {
        // sempre que é chamado, o id inicia com um novo ID
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
