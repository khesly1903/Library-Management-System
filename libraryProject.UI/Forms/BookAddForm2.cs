using System.Data;
using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;


namespace libraryProject.UI.Forms
{
    public partial class BookAddForm2 : Form
    {
        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;
        private readonly AuthorService _authorService;
        private readonly ShelfService _shelfService;
        private readonly AuthorRepository _authorRepository;
        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;
        private readonly ShelfRepository _shelfRepository;
        private readonly LoanService _loanService;
        private readonly LoanRepository _loanRepository;

        Book? selected;

        public BookAddForm2()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

            _authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(_authorRepository);

            _publisherRepository = new PublisherRepository(context);
            _publisherService = new PublisherService(_publisherRepository);

            _shelfRepository = new ShelfRepository(context);
            _shelfService = new ShelfService(_shelfRepository);


            _loanRepository = new LoanRepository(context);
            _loanService = new LoanService(_loanRepository);

        }

        private void BookAddForm2_Load(object sender, EventArgs e)
        {
            GetAllComboBoxData();
            GetAllBooks();
            //GetAllAuthors();
        }

        private void GetAllAuthors()
        {
            lstList.Items.Clear();
            var authors = _authorService.GetAll().ToList();

            foreach (var author in authors)
            {
                lstList.Items.Add(author.Books);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {
                    string bookControl = txtBookName.Text;
                    string bookControl2 = txtBookISBN.Text;
                    string bookControl3 = cmbBookShelf.Text;
                    if (_bookService.IfEntityExists(s => s.BookName == bookControl) )
                    {
                        throw new Exception("Bu kitap adı zaten mevcut");
                    }

                    if (_bookService.IfEntityExists(b => b.BookISBN == bookControl2))
                    {
                        throw new Exception("Bu ISBN zaten mevcut");
                    }

                    if (_bookService.IfEntityExists(b=> b.Shelf.ShelfDescription == bookControl3))
                    {
                        throw new Exception("Bu rafta bir kitap var");
                    }

                    Book book = new Book()
                    {
                        BookName = txtBookName.Text,
                        BookISBN = txtBookISBN.Text,
                        TotalCopies = Convert.ToInt32(numBookStock.Value),
                        Author = (Author)cmbBookAuthor.SelectedItem,
                        Publiser = (Publisher)cmbBookPublisher.SelectedItem,
                        Shelf = (Shelf)cmbBookShelf.SelectedItem
                    };
                   

                    _bookService.Create(book);

                    Author book_author = book.Author;
                    book_author.Books.Add(book);
                    MessageBox.Show("Kitap Eklendi");
                    ClearForm();

                }
                else
                {
                    selected.BookName = txtBookName.Text;
                    selected.BookISBN = txtBookISBN.Text;
                    selected.TotalCopies = Convert.ToInt32(numBookStock.Value);
                    selected.Author = (Author)cmbBookAuthor.SelectedItem;
                    selected.Publiser = (Publisher)cmbBookPublisher.SelectedItem;
                    selected.Shelf = (Shelf)cmbBookShelf.SelectedItem;

                    _bookService.Update(selected);
                    MessageBox.Show("Kitap Güncellendi");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                //\nInner Exception: {ex.InnerException?.Message}
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex != -1)
            {
                selected = (Book?)lstList.SelectedItem;
                txtBookName.Text = selected?.BookName;
                txtBookISBN.Text = selected?.BookISBN;
                numBookStock.Value = Convert.ToInt32(selected?.TotalCopies);
                cmbBookAuthor.SelectedItem = selected?.Author;
                cmbBookPublisher.SelectedItem = selected?.Publiser;
                cmbBookShelf.SelectedItem = selected?.Shelf;

                btnAdd.Text = "Güncelle";
            }
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
            txtBookName.Text = "";
            txtBookISBN.Text = "";
            numBookStock.Value = 0;
            cmbBookAuthor.SelectedItem = null;
            cmbBookPublisher.SelectedItem = null;
            cmbBookShelf.SelectedItem = null;

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtBookName.Text);
        }
        private void LoadBooks(string searchText = "")
        {
            lstList.Items.Clear();
            var books = _bookService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                books = books.Where(a => a.BookName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var book in books)
            {
                lstList.Items.Add(book);
            }
        }




        private void GetAllComboBoxData()
        {
            var authors = _authorService.GetAll().ToList();
            var publishers = _publisherService.GetAll().ToList();
            var shelfs = _shelfService.GetAll()
                        .OrderBy(s => s.ShelfDescription.Substring(0, 1))  // Harfe göre sırala (A-Z)
                        .ThenBy(s => int.Parse(s.ShelfDescription.Substring(1))) // Sayıya göre sırala (1-9)
                        .ToList();

            cmbBookAuthor.Items.Clear();
            cmbBookPublisher.Items.Clear();
            cmbBookShelf.Items.Clear();

            foreach (var author in authors)
            {
                cmbBookAuthor.Items.Add(author);
            }
            foreach (var publisher in publishers)
            {
                cmbBookPublisher.Items.Add(publisher);
            }
            foreach (var shelf in shelfs)
            {
                cmbBookShelf.Items.Add(shelf);
            }
        }

        private void cmbBookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAuthors();

        }

        private void LoadAuthors()
        {


            lstList.Items.Clear();
            var books = _bookService.GetAll();

            if (cmbBookAuthor.SelectedItem is Author selectedAuthor)
            {
                Author currentAuthor = selectedAuthor;

                books = books.Where(b => b.Author.Id == currentAuthor.Id).ToList();
            }
            foreach (var book in books)
            {
                lstList.Items.Add(book);
            }
        }

       


        private void cmbBookPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = GetAllLoansList();

            foreach (Loan loan in loans)
            {
                if (selected == loan.Book)
                {
                    MessageBox.Show("Ödünç alınmış kitap kaldırılamaz");
                    return;
                }
            }

            if (selected != null)
            {
                _bookService.Delete(selected.Id);
                MessageBox.Show("Kitap Silindi");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Silinecek kitap seçiniz");
            }
        }

        private List<Loan> GetAllLoansList()
        {

            var loans = _loanService.GetAll().ToList();
            List<Loan> loanList = new List<Loan>();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                loanList.Add(current_loan);
            }
            return loanList;

        }
    }
}