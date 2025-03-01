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


        public LoanForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);
            _studentRepository = new StudentRepository(context);
            _studentService = new StudentService(_studentRepository);


        }

        private void LoanForm_Load(object sender, EventArgs e)
        {

        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeLoanDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtStudentSearch.Text);
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtBookSearch.Text);
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

        private void LoadBooks(string searchText = "")
        {
            lstBooks.Items.Clear();
            var books = _bookService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                books = books.Where(b => b.BookName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }

       

        
    }
}
