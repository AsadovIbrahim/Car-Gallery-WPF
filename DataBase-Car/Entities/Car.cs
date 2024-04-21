using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDB.Entities
{
    public class Car:BaseEntity
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? ImagePath { get; set; }



        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
