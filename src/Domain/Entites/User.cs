using Domain.Common;

namespace Domain.Entites
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
    }
}
