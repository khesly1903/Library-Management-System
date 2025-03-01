using libraryProject.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Models
{
    public class Book : Entity
    {
        public string? BookName { get; set; }

        public string? BookTitle { get; set; }

        public string? BookISBN { get; set; }

        
        public int TotalCopies { get; set; }



        // bağlantı referansları

        public int AvailableCopies { get; set; }
        public Author? Author { get; set; }
        public Shelf? Shelf { get; set; }
        public Subject? Subject{ get; set; }
        public Publisher? Publiser { get; set; }


       
            public override string ToString()
            {
                return $"{BookName} - {Author?.Name} {Author?.Surname}";
            }
        }


    };

