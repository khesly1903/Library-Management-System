using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace libraryProject.UI.Forms
{
    public partial class BookAddForm : Form
    {

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;
        public BookAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);
        }

      
        private void txtBookTotalCopies_TextChanged(object sender, EventArgs e)
        {

        }
        Book? selected;
        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)  // Eğer bir kitap seçildiyse
            {
                selected = (Book?)lstBooks.SelectedItem;  // Seçilen kitabı al
                txtBookTitle.Text = selected.BookName;
                txtBookISBN.Text = selected.BookISBN;
                txtBookTotalCopies.Text = selected.TotalCopies.ToString();
                txtBookAuthorName.Text = selected.Author?.Name;
                txtBookAuthorSurname.Text = selected.Author?.Surname;
                txtBookPublisher.Text = selected.Publiser?.PublisherName;
                txtBookType.Text = selected.Subject?.SubjectName;
                txtBookLocation.Text = selected.Shelf?.ShelfDescription;

            }
        }
        //Bu metot, kullanıcı bir kitap seçtiğinde formdaki alanları otomatik olarak doldurarak kullanıcının seçilen kitabın bilgilerini görmesini sağlar.
        //Bu sayede kullanıcı, seçilen kitabın bilgilerini düzenleyebilir veya silebilir.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni kitap ekle
                var book = new Book
                {
                    Id = Guid.NewGuid(),
                    BookName = txtBookTitle.Text,
                    BookISBN = txtBookISBN.Text,
                    TotalCopies = int.Parse(txtBookTotalCopies.Text),
                    AvailableCopies = int.Parse(txtBookTotalCopies.Text),
                    Author = new Author
                    {
                        Name = txtBookAuthorName.Text,
                        Surname = txtBookAuthorSurname.Text
                    },
                    Publiser = new Publisher
                    {
                        PublisherName = txtBookPublisher.Text
                    },
                    Subject = new Subject
                    {
                        SubjectName = txtBookType.Text
                    },
                    Shelf = new Shelf
                    {
                        ShelfDescription = txtBookLocation.Text
                    }
                };


                // Kitabı servise ekle
                _bookService.Create(book);
                GetAllBooks();
                MessageBox.Show("Kitap başarıyla eklendi");

                // Formu temizle
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected != null)
                {
                    // Seçilen kitabın bilgilerini güncelle
                    selected.BookName = txtBookTitle.Text;
                    selected.BookISBN = txtBookISBN.Text;
                    selected.TotalCopies = int.Parse(txtBookTotalCopies.Text);
                    selected.AvailableCopies = int.Parse(txtBookTotalCopies.Text);
                    selected.Author = new Author
                    {
                        Name = txtBookAuthorName.Text,
                        Surname = txtBookAuthorSurname.Text
                    };
                    selected.Publiser = new Publisher
                    {
                        PublisherName = txtBookPublisher.Text
                    };
                    selected.Subject = new Subject
                    {
                        SubjectName = txtBookType.Text
                    };
                    selected.Shelf = new Shelf
                    {
                        ShelfDescription = txtBookLocation.Text
                    };

                    // Kitabı servise güncelle
                    _bookService.Update(selected);
                    GetAllBooks();
                    MessageBox.Show("Kitap başarıyla güncellendi");

                    // Formu temizle
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek için bir kitap seçin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (selected != null)
                {
                    // Seçilen kitabı sil
                    _bookService.Delete(selected.Id);
                    GetAllBooks();
                    MessageBox.Show("Kitap başarıyla silindi");

                    // Formu temizle
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir kitap seçin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void BookAddForm_Load(object sender, EventArgs e)
        {
            GetAllBooks();

        }
        private void GetAllBooks()
        {
            lstBooks.Items.Clear();
            var books = _bookService.GetAll().ToList();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }


        private void ClearForm()
        {
            txtBookTitle.Text = "";
            txtBookAuthorName.Text = "";
            txtBookAuthorSurname.Text = "";
            txtBookISBN.Text = "";
            txtBookType.Text = "";
            txtBookPublisher.Text = "";
            txtBookLocation.Text = "";
            txtBookTotalCopies.Text = "";
           
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBookID_Click(object sender, EventArgs e)
        {

        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblBookAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblBookISBN_Click(object sender, EventArgs e)
        {

        }

        private void lblBookType_Click(object sender, EventArgs e)
        {

        }

        private void lblBookLocation_Click(object sender, EventArgs e)
        {

        }

        private void lblBookTotalCopies_Click(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookLocation_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
