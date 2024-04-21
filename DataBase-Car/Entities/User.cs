using System.Collections.Generic;

namespace CarDB.Entities
{
    public class User:BaseEntity
    {
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public string ?Username { get; set; }
        public string ?Password { get; set; }

        public ICollection<Car> ?Cars { get; set; }
    }
}
