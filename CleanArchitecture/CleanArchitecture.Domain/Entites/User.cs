namespace CleanArchitecture.Domain.Entites
{
    public sealed class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}
