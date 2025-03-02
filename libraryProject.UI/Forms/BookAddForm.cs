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
        private readonly AuthorService _authorService;
        private readonly AuthorRepository _authorRepository;
        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;

        Book? selected;

        public BookAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

            _authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(_authorRepository);

            _publisherRepository = new PublisherRepository(context);
            _publisherService = new PublisherService(_publisherRepository);

        }


        
        
        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex != -1)  // Eğer bir kitap seçildiyse
            {
                selected = (Book?)lstList.SelectedItem;  // Seçilen kitabı al

                if (selected is Book)
                {
                    txtBookTitle.Text = selected.BookName;
                    txtBookISBN.Text = selected.BookISBN;
                    numUdStock.Value = Convert.ToInt32(selected.TotalCopies);
                    txtBookAuthorName.Text = selected.Author?.Name;
                    txtBookAuthorSurname.Text = selected.Author?.Surname;
                    txtBookPublisher.Text = selected.Publiser?.PublisherName;
                    txtBookType.Text = selected.Subject?.SubjectName;
                    txtBookLocation.Text = selected.Shelf?.ShelfDescription;

                    btnAdd.Text = "Güncelle";
                }
                else
                {
                    MessageBox.Show("Lütfen bir kitap seçiniz");
                }

            }
        }
        //Bu metot, kullanıcı bir kitap seçtiğinde formdaki alanları otomatik olarak doldurarak kullanıcının seçilen kitabın bilgilerini görmesini sağlar.
        //Bu sayede kullanıcı, seçilen kitabın bilgilerini düzenleyebilir veya silebilir.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (selected == null)
                {
                    string bookname = txtBookTitle.Text;
                    if (_bookService.IfEntityExists(b => b.BookName == bookname))
                    {
                        throw new Exception("Kitap zaten mevcut");
                    }
                    string authorname = txtBookAuthorName.Text;
                    string authorsurname = txtBookAuthorSurname.Text;

                    // eğer mevcut author varsa buraya atanır
                    Author book_author = null;
                    var existingAuthor = _authorService.GetAll().FirstOrDefault(a => a.Name == authorname && a.Surname == authorsurname);
                    if (existingAuthor != null)
                    {
                        
                        book_author = existingAuthor;
                    }
                    else
                    {
                        book_author = new Author
                        {
                            Name = txtBookAuthorName.Text,
                            Surname = txtBookAuthorSurname.Text
                        };
                    }

                    // eğer mevcut publisher varsa buraya atanır
                    Publisher book_publisher = null;
                    var existingPublisher = _publisherService.GetAll().FirstOrDefault(p => p.PublisherName == txtBookPublisher.Text);
                    if (existingPublisher != null)
                    {
                        book_publisher = existingPublisher;
                    }
                    else
                    {
                        book_publisher = new Publisher
                        {
                            PublisherName = txtBookPublisher.Text
                        };
                    }



                    Book book = new Book()
                    {
                        BookName = txtBookTitle.Text,
                        BookISBN = txtBookISBN.Text,
                        TotalCopies = Convert.ToInt32(numUdStock.Value),

                        Author = book_author,
                        Publiser = book_publisher,
                        Subject = new Subject
                        {
                            SubjectName = txtBookType.Text
                        },
                        Shelf = new Shelf
                        {
                            ShelfDescription = txtBookLocation.Text
                        }

                    };

                    _bookService.Create(book);
                    GetAllBooks();
                    MessageBox.Show("Kitap başarıyla eklendi");
                }
                else // güncelleme
                {
                    selected.BookName = txtBookTitle.Text;
                    selected.BookISBN = txtBookISBN.Text;
                    selected.TotalCopies = Convert.ToInt32(numUdStock.Value);
                    selected.Author.Name = txtBookAuthorName.Text;
                    selected.Author.Surname = txtBookAuthorSurname.Text;
                    selected.Publiser.PublisherName = txtBookPublisher.Text;
                    selected.Subject.SubjectName = txtBookType.Text;
                    selected.Shelf.ShelfDescription = txtBookLocation.Text;

                    _bookService.Update(selected);
                    GetAllBooks();
                    MessageBox.Show("Kitap başarıyla güncellendi");
                }

                // Formu temizle
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }







        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (selected != null)
                {
                    // Seçilen kitabı sil
                    _bookService.Delete(selected.Id);
                    selected.TotalCopies = 0;
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
            lstList.Items.Clear();
            var books = _bookService.GetAll().ToList();
            foreach (var book in books)
            {
                lstList.Items.Add(book);
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
            numUdStock.Value = 0;

        }







        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            //LoadBooks();
        }
        /*
        private void LoadBooks(string searchText = "")
        {
            lstList.Items.Clear();
            var books = _bookService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                books = books.Where(b => b.BookName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var book in books)
            {
                lstList.Items.Add(book);
            }
        }
        */
        private void txtBookPublisher_TextChanged(object sender, EventArgs e)
        {
            LoadPublishers(txtBookPublisher.Text);
        }
        private void LoadPublishers(string searchText = "")
        {
            lstHelp.Items.Clear();
            var publishers = _publisherService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                publishers = publishers.Where(p => p.PublisherName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var publisher in publishers)
            {
                lstHelp.Items.Add(publisher);
            }
        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {
            LoadAuthors(txtBookAuthorName.Text);
        }

        private void LoadAuthors(string searchText = "")
        {
            lstHelp.Items.Clear();
            var authors = _authorService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                authors = authors.Where(a => a.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var student in authors)
            {
                lstHelp.Items.Add(student);
            }
        }

        
        

        private void lstHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex != null)
            {
                if (lstHelp.SelectedItem is Author author)
                {
                    
                    txtBookAuthorName.Text = author.Name;
                    txtBookAuthorSurname.Text = author.Surname;
                    lstHelp.Items.Clear();

                }
                else if (lstHelp.SelectedItem is Publisher publisher)
                {
                    
                    txtBookPublisher.Text = publisher.PublisherName;
                    lstHelp.Items.Clear();

                }
            }
            else
            {
                lstHelp.Items.Clear();
            }

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

        private void numUdStock_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
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
    }
}
