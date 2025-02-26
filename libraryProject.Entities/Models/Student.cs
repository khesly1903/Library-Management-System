using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Student : Entity
    {
        public string?  StudentName{ get; set; }
        public string? StudentSurname { get; set; }
        public string? StudentNumber { get; set; }


        //referans bağlantılar
        public ICollection<Loan>? Loan { get; set; }


    }
}
