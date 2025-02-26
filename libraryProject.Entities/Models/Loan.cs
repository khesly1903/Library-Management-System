using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Loan : Entity
    {
        public DateTime LoanDate { get; set; }
        public DateTime RetrunDate { get; set; }





        // referans bağlantılar

        public Student? Student { get; set; }

        public Guid BookId { get; set; }

    }
}
