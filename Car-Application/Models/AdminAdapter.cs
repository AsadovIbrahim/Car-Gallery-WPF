using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public class AdminAdapter : Person
    {
        public List<CarAdapter> Cars { get; set; } = new();
        public AdminAdapter(string username, string password) : base(username, password){ }
    }
}
