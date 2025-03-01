using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Publisher : Entity
    {
        public string? PublisherName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }



        //referans bağlantıar
        public ICollection<Book>? Book { get; set; }

        public override string ToString()
        {
            return $"{PublisherName} {Address} {ContactNumber}";



        }
    }
}
