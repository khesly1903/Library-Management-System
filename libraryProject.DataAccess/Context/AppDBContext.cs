using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace libraryProject.DataAccess.Context
{
    public class AppDBContext:DbContext
    {
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects{ get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // COMMITE EDERKEN VEYA PULL ETTİKTEN SONRA BURAYI KONTROL ETMEYİ UNUTMAYIN
            // DB HATASI ALIRSANIZ İLK OLARAK BURADAKİ CONNECTION STRING KISMINA BAKIN
            // İŞLEM YAPACAĞINIZ ZAMAN KENDİNİZ HARİÇ HERKESİ YORUM SATIRINA ALIN



            // BERKAY DB LOCAL
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=KAYAB\SQLEXPRESS;Initial Catalog=LibraryProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasKey(a => a.Id); // Define primary key for Author

            modelBuilder.Entity<Book>()
                .HasKey(b => b.Id); // Define primary key for Book

            modelBuilder.Entity<Shelf>()
                .HasKey(s => s.Id); // Define primary key for Shelf

            modelBuilder.Entity<Publisher>()
                .HasKey(p => p.Id); // Define primary key for Publisher

            modelBuilder.Entity<Subject>()
                .HasKey(s => s.Id); // Define primary key for Subject

            // Other configurations
        }

    }
}
