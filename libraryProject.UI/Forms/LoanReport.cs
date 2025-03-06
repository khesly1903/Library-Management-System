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

using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace libraryProject.UI.Forms
{
    public partial class LoanReport : Form
    {
        private readonly StudentService _studentService;
        private readonly StudentRepository _studentRepository;

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;

        private readonly LoanService _loanService;
        private readonly LoanRepository _loanRepository;

        Loan? selectedLoan;
        public LoanReport()
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

        private void LoanReport_Load(object sender, EventArgs e)
        {
            GeneralReport();
        }

        private void GeneralReport()
        {
            List<Loan> loans = GetAllLoansList();
            List<Student> students = _studentService.GetAll().ToList();
            List<Book> books = _bookService.GetAll().ToList();

            int studentcount = students.Count;
            int bookcount = books.Count;
            int loancount = loans.Count;

            int activeLoanCount = 0;
            foreach (var loan in loans)
            {
                if (loan.IsActive)
                {
                    activeLoanCount++;
                }
            }

            lblToatalLoan.Text = loancount.ToString();
            lblTotalActiveLoan.Text = activeLoanCount.ToString();
            lblTotalStudent.Text = studentcount.ToString();
            lblTotalBook.Text = bookcount.ToString();


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



        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        private void btnGetAllLoans_Click(object sender, EventArgs e)
        {
            LoadAllLoansToDataGridView();
        }

        private List<Loan>? _allLoansList = new List<Loan>();
        private void LoadAllLoansToDataGridView()
        {

            dGV.DataSource = null;
            dGV.Rows.Clear();
            dGV.Columns.Clear();


            List<Loan> loans = GetAllLoansList();

            var _allLoansList = loans
                .OrderByDescending(l => l.LoanDate)
                .Select(l => new
                {
                    Student = l.Student.StudentName + " " + l.Student.StudentSurname,
                    BookName = l.Book.BookName,
                    LoanDate = l.LoanDate.ToShortDateString(),
                    ReturnDate = l.RetrunDate.ToShortDateString(),
                    Status = l.IsActive ? "İade Edildi" : "Devam Ediyor"
                })
                .ToList();

            if (dGV.Columns.Count == 0)
            {
                dGV.AutoGenerateColumns = true;
            }
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            dGV.DataSource = _allLoansList;
        }
        
        //--------------------------------------------------------------------------------
        private void btnDueDateCheck_Click(object sender, EventArgs e)
        {
            GetAllLoansWithRemainingDays();
        }
        private void GetAllLoansWithRemainingDays()
        {

            dGV.DataSource = null;
            dGV.Rows.Clear();
            dGV.Columns.Clear();

            var loans = GetAllLoansList().Where(l => !l.IsActive).ToList();

            var loanWithRemainingDays = loans
                .Select(l => new
                {
                    StudentFullName = l.Student.StudentName + " " + l.Student.StudentSurname,
                    BookName = l.Book.BookName,
                    RemainingDays = (l.RetrunDate - DateTime.Now).Days
                })
                .OrderBy(x => x.RemainingDays)
                .ToList();

            // DataGridView için kolonları manuel olarak ekleyelim
            dGV.AutoGenerateColumns = false;

            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Öğrenci Adı",
                DataPropertyName = "StudentFullName"
            });

            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Kitap Adı",
                DataPropertyName = "BookName"
            });
            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Kalan Gün",
                DataPropertyName = "RemainingDays"
            });

            //dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dGV.Columns[0].Width = 300;
            dGV.Columns[1].Width = 300;
            dGV.Columns[2].Width = 300;

            dGV.DataSource = loanWithRemainingDays;
        }



        //--------------------------------------------------------------------------------
        private void btnStudentHighestCheck_Click(object sender, EventArgs e)
        {
            GetAllStudentsByHighestLoan();
        }

        private void GetAllStudentsByHighestLoan()
        {
            dGV.DataSource = null;
            dGV.Rows.Clear();
            dGV.Columns.Clear();
            var loans = GetAllLoansList();

            var studentLoanCounts = loans
                .GroupBy(l => l.Student)
                .Select(g => new
                {
                    StudentFullName = g.Key.StudentName + " " + g.Key.StudentSurname,
                    StudentNumber = g.Key.StudentNumber,
                    LoanCount = g.Count()
                })
                .OrderByDescending(x => x.LoanCount)
                .ToList();

            // DataGridView için kolonları manuel olarak ekleyelim
            dGV.AutoGenerateColumns = false;

            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Öğrenci",
                DataPropertyName = "StudentFullName"
            });
            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Öğrenci No",
                DataPropertyName = "StudentNumber"
            });
            dGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ödünç Kitap Sayısı",
                DataPropertyName = "LoanCount"
            });

            //dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dGV.Columns[0].Width = 300;
            dGV.Columns[1].Width = 300;
            dGV.Columns[2].Width = 300;
            // Veriyi bağla
            dGV.DataSource = studentLoanCounts;
        }

        
    }
}
