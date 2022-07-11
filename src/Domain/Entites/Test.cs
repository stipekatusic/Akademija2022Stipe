using Domain.Common;

namespace Domain.Entites
{
    public class Test : AuditableEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
