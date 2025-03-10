﻿using libraryProject.Entities.Abstractions;
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

        public bool IsActive { get; set; } = false; // false ise kitap alındı, true ise alınmadı



        // referans bağlantılar

        public Student? Student { get; set; }

        public Book? Book { get; set; }

        public override string ToString()
        {
            return $"{Student} # {Book} # {LoanDate.ToShortDateString()}-{RetrunDate.ToShortDateString()}";
        }

    }
}
