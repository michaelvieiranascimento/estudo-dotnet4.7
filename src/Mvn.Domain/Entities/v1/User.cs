using System;

namespace Mvn.Domain.Entities.v1
{
    public class User
    {
        public long Id { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}