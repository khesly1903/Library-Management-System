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
            GetAllLoans();
        }

        private void GetAllLoans()
        {
            lstReport.Items.Clear();
            var loans = _loanService.GetAll().ToList();
            foreach (var loan in loans)
            {
                Loan current_loan = _loanService.GetById(loan.Id);
                Student loan_student = _studentService.GetById(loan.Student.Id);
                Book loan_book = _bookService.GetById(loan.Book.Id);
                string loan_date = loan.LoanDate.ToShortDateString();
                string retrun_date = loan.RetrunDate.ToShortDateString();
                //lstList.Items.Add($"{loan_student} # {loan_book} # {loan_date} # {retrun_date}");

                if (loan.IsActive == false)
                {
                    lstReport.Items.Add(loan);
                }
                
            }
        }
    }
}
