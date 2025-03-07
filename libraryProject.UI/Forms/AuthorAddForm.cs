using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;

namespace libraryProject.UI.Forms
{
    public partial class AuthorAddForm : Form
    {
        private readonly AuthorService _authorService;
        private readonly AuthorRepository _authorRepository;

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;
        Author? selected;

        public AuthorAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(_authorRepository);

            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            GetAllAuthor();
        }

        private void GetAllAuthor()
        {
            lstAuthorList.Items.Clear();
            _authorService.GetAll().ToList().ForEach(a => lstAuthorList.Items.Add(a));
        }

        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {
                    string authorName = txtAuthorName.Text;
                    if (_authorService.IfEntityExists(a => a.Name == authorName))
                    {
                        throw new Exception("Yazar zaten mevcut");
                    }

                    Author author = new Author()
                    {
                        Name = txtAuthorName.Text,
                        Surname = txtAuthorSurname.Text,
                    };

                    _authorService.Create(author);
                    GetAllAuthor();
                    MessageBox.Show("İşlem başarılı");

                    ClearForm();
                }
                else //update
                {
                    selected.Name = txtAuthorName.Text;
                    selected.Surname = txtAuthorSurname.Text;
                    _authorService.Update(selected);
                    GetAllAuthor();
                    MessageBox.Show("Güncellendi");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtAuthorName.Text = "";
            txtAuthorSurname.Text = "";
            selected = null;
        }

        private List<Book> GetAllBooksList()
        {
            var books = _bookService.GetAll().ToList();
            List<Book> bookList = new List<Book>();
            foreach (var book in books)
            {
                Book current_book = _bookService.GetById(book.Id);
                bookList.Add(current_book); // Add the book to the list
            }

            return bookList;
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {

            List<Book> books = new List<Book>();
            books = GetAllBooksList();

            foreach (Book book in books)
            {

                if (selected == book.Author)
                {
                    MessageBox.Show("Kitabı olan yazar silinemez");
                    return;
                }
            }

            if (selected != null)
            {
                _authorService.Delete(selected.Id);
                GetAllAuthor();
                MessageBox.Show("İşlem başarılı");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Yazar seçiniz");
            }
        }





        private void lstAuthorList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstAuthorList.SelectedIndex != -1)
            {
                selected = (Author)lstAuthorList.SelectedItem;
                txtAuthorName.Text = selected.Name;
                txtAuthorSurname.Text = selected.Surname;
            }
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
