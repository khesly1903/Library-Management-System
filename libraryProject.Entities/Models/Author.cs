using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Author: Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Biography1{ get; set; }


        // bağlantı referansları
        public ICollection<Book>? Books { get; set; }
    }
}
