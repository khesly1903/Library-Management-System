using System.Data;
using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;


namespace libraryProject.UI.Forms
{
    public partial class ReturnForm : Form
    {
        private readonly StudentService _studentService;
        private readonly StudentRepository _studentRepository;

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;

        private readonly LoanService _loanService;
        private readonly LoanRepository _loanRepository;

        Loan? selectedLoan;

        public ReturnForm()
        {
            InitializeComponent();
            var context = new AppDBContext();

            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

            _studentRepository = new StudentRepository(context);
            _studentService = new StudentService(_studentRepository);

            _loanRepository = new LoanRepository(context);
            _loanService = new LoanService(_loanRepository);
        }

        private void RetrunForm_Load(object sender, EventArgs e)
        {
            GetAllLoans();
        }
        private void GetAllLoans()
        {
            lstList.Items.Clear();
            var loans = _loanService.GetAll().ToList();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                Student loan_student = _studentService.GetById(loan.Student.Id);
                Book loan_book = _bookService.GetById(loan.Book.Id);
                string loan_date = loan.LoanDate.ToShortDateString();
                string retrun_date = loan.RetrunDate.ToShortDateString();
                //lstList.Items.Add($"{loan_student} # {loan_book} # {loan_date} # {retrun_date}");
                lstList.Items.Add(loan);
            }
        }

        private List<Loan> GetAllLoansList()
        {
            lstList.Items.Clear();
            var loans = _loanService.GetAll().ToList();
            List<Loan> loanList = new List<Loan>();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                loanList.Add(current_loan);
            }
            return loanList;

        }
        private void LoadLoansByStudentName(string searchText = "")
        {
            lstList.Items.Clear();
            var loans = GetAllLoansList();

            if (!string.IsNullOrEmpty(searchText))
            {
                loans = loans.Where(a => a.Student.StudentName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var loan in loans)
            {
                Student loan_student = _studentService.GetById(loan.Student.Id);
                Book loan_book = _bookService.GetById(loan.Book.Id);
                string loan_date = loan.LoanDate.ToShortDateString();
                string retrun_date = loan.RetrunDate.ToShortDateString();
                //lstList.Items.Add($"{loan_student} # {loan_book} # {loan_date} # {retrun_date}");
                lstList.Items.Add(loan);
            }
        }

        private void LoadLoansByBookName(string searchText = "")
        {
            lstList.Items.Clear();
            var loans = GetAllLoansList();
            if (!string.IsNullOrEmpty(searchText))
            {
                loans = loans.Where(a => a.Book.BookName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            foreach (var loan in loans)
            {
                Student loan_student = _studentService.GetById(loan.Student.Id);
                Book loan_book = _bookService.GetById(loan.Book.Id);
                string loan_date = loan.LoanDate.ToShortDateString();
                string retrun_date = loan.RetrunDate.ToShortDateString();
                //lstList.Items.Add($"{loan_student} # {loan_book} # {loan_date} # {retrun_date}");
                lstList.Items.Add(loan);
            }
        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLoansByStudentName(txtStudentSearch.Text);
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLoansByBookName(txtBookSearch.Text);
        }


        

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem is Loan loan)
            {
                selectedLoan = loan;
            }

            
        }

        private void btnRetrun_Click(object sender, EventArgs e)
        {
            Loan loan = _loanService.GetById(selectedLoan.Id);
            loan.Book.TotalCopies++;

            _loanService.Delete(loan.Id);

            MessageBox.Show("İşlem başarıyla tamamlandı");
            GetAllLoans();
        }
    }
}
