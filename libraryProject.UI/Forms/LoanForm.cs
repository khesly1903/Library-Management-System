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
    }
}
