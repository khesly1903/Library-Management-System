using System.Data;
using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;


namespace libraryProject.UI.Forms
{
    public partial class LoanForm : Form
    {

        private readonly StudentService _studentService;
        private readonly StudentRepository _studentRepository;

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;

        private readonly AuthorService _authorService;
        private readonly AuthorRepository _authorRepository;

        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;

        private readonly LoanService _loanService;
        private readonly LoanRepository _loanRepository;

        Student? selectedStudent;
        Book? selectedBook;
        Loan? selectedLoan;


        public LoanForm()
        {
            InitializeComponent();
            var context = new AppDBContext();

            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

            _studentRepository = new StudentRepository(context);
            _studentService = new StudentService(_studentRepository);

            _authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(_authorRepository);

            _publisherRepository = new PublisherRepository(context);
            _publisherService = new PublisherService(_publisherRepository);

            _loanRepository = new LoanRepository(context);
            _loanService = new LoanService(_loanRepository);



        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
           // GetAllBooks();
           // GetAllAuthors();
            GetAllLoans();
        }

        private void GetAllLoans()
        {
            lstLoans.Items.Clear();
            var loans = _loanService.GetAll().ToList();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                lstLoans.Items.Add(loan);
            }
        }


        private void GetAllBooks()
        {
            lstBooks.Items.Clear();
            var books = _bookService.GetAll().ToList();
            foreach (var book in books)
            {
                Book current_book = _bookService.GetById(book.Id);
                
                lstBooks.Items.Add(current_book);
                
            }
        }

       

        private void GetAllAuthors()
        {
            lstBooks.Items.Clear();
            var authors = _authorService.GetAll().ToList();
            
            foreach (var author in authors)
            {
                lstBooks.Items.Add(author.Books);
            }
        }




        private void dateTimeLoanDate_ValueChanged(object sender, EventArgs e)
        {

        }
        // ----------------------------------------------------------
        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtStudentSearch.Text);
        }
        private void LoadStudents(string searchText = "")
        {
            lstStudents.Items.Clear();
            var students = _studentService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                students = students.Where(s => s.StudentName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var student in students)
            {
                lstStudents.Items.Add(student);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is Student student)
            {

                txtStudentSearch.Text = $"{student.StudentName} {student.StudentSurname} - {student.StudentNumber}";

                selectedStudent = student;
            }
        }
        // ----------------------------------------------------------
        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtBookSearch.Text);
        }

       
        // çalışıyor
        private List<Book> GetAllBooksList()
        {
            lstBooks.Items.Clear();
            var books = _bookService.GetAll().ToList();
            List<Book> bookList = new List<Book>();
            foreach (var book in books)
            {
                Book current_book = _bookService.GetById(book.Id);
                bookList.Add(current_book);
            }

            return bookList;
        }
        // çalışıyor
        private void LoadBooks(string searchText = "")
        {
            lstBooks.Items.Clear();
           var books = GetAllBooksList();

            if (!string.IsNullOrEmpty(searchText))
            {

                 books = _bookService.GetAll().Where(a => a.BookName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is Book book)
            {
                txtBookSearch.Text = $"{book.BookName} - {book.Author}";

                selectedBook = book;

            }
        }
        // ----------------------------------------------------------

        private void btnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBook != null && selectedStudent != null)
                {

                    Loan loan = new Loan()
                    {

                        LoanDate = clndrStartDate.SelectionStart,
                        RetrunDate = clndrEndDate.SelectionStart,
                        Student = (Student?)selectedStudent,
                        Book = (Book?)selectedBook
                    };

                    _loanService.Create(loan);
                    // messagebox ile hangi öğrenciye hangi kitabı ödünç verdiğini göster
                    MessageBox.Show($"Öğrenci: {selectedStudent.StudentName} {selectedStudent.StudentSurname} {Environment.NewLine} Kitap: {selectedBook.BookName} {Environment.NewLine} Başlangıç Tarihi: {clndrStartDate.SelectionStart.ToShortDateString()} {Environment.NewLine} Biriş Tarihi {clndrEndDate.SelectionStart.ToShortDateString()}");

                    ClearForm();

                }
                else
                {
                    MessageBox.Show("Öğrenci ve kitap seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }

        private void ClearForm()
        {
            txtBookSearch.Text = "";
            txtStudentSearch.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadLoans(textBox1.Text);
        }

        private List<Loan> GetAllLoansList()
        {
            lstLoans.Items.Clear();
            var loans = _loanService.GetAll().ToList();
            List<Loan> loanList = new List<Loan>();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                loanList.Add(current_loan);
            }
            return loanList;
        }

        private void LoadLoans(string searchText = "")
        {
            lstLoans.Items.Clear();
            var loans = GetAllLoansList();

            if (!string.IsNullOrEmpty(searchText))
            {

                loans = loans.Where(a => a.Student.StudentName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var loan in loans)
            {
                lstLoans.Items.Add(loan);
            }
        }







        private void lstLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedLoan = (Loan)lstLoans.SelectedItem;
            if (selectedLoan != null)
            {
                _loanService.Delete(selectedLoan.Id);
                GetAllLoans();
                MessageBox.Show("İşlem başarılı");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Öğrenci seçiniz");
            }
        }




        // ----------------------------------------------------------


    }
}
