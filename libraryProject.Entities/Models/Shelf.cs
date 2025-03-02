using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Shelf : Entity
    {
        public Guid ShelftID { get; set; }
        public string? ShelfDescription { get; set; }

        //referans bağlantılar
        public ICollection<Book>? Book { get; set; }

        public override string ToString()
        {
            return $"{ShelfDescription}";
        }
    }
}
