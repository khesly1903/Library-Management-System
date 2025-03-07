using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;

namespace libraryProject.UI
{
    public partial class StudentAddForm : Form
    {


        private readonly StudentService _studentService;
        private readonly StudentRepository _studentRepository;

        private readonly LoanService _loanService;
        private readonly LoanRepository _loanRepository;

        public StudentAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _studentRepository = new StudentRepository(context);
            _studentService = new StudentService(_studentRepository);


            _loanRepository = new LoanRepository(context);
            _loanService = new LoanService(_loanRepository);
        }
        private void StudentAddForm_Load(object sender, EventArgs e)
        {
            GetAllStudents();
        }


        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {

                    string studentName = txtStudentName.Text;
                    string studentSurname = txtStudentSurname.Text;
                    string studentNumber = txtStudentNumber.Text;
                    if (_studentService.IfEntityExists(s => s.StudentName == studentName) && _studentService.IfEntityExists(s => s.StudentSurname == studentSurname) && _studentService.IfEntityExists(s => s.StudentNumber == studentNumber))
                    {
                        throw new Exception("Öğrenci zaten mevcut");
                    }

                    Student student = new Student()
                    {
                        StudentName = txtStudentName.Text,
                        StudentSurname = txtStudentSurname.Text,
                        StudentNumber = txtStudentNumber.Text
                    };

                    _studentService.Create(student);
                    GetAllStudents();
                    MessageBox.Show("işlem başarılı");

                    ClearForm();
                }
                else //update
                {
                    selected.StudentName = txtStudentName.Text;
                    selected.StudentSurname = txtStudentSurname.Text;
                    selected.StudentNumber = txtStudentNumber.Text;
                    _studentService.Update(selected);
                    GetAllStudents();
                    MessageBox.Show("Güncellendi");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = GetAllLoansList();

            foreach (Loan loan in loans)
            {
                if (selected == loan.Student)
                {
                    MessageBox.Show("Kitap ödünç almış öğrenci silinemez");
                    return;
                }
            }


            if (selected != null)
            {
                _studentService.Delete(selected.Id);
                GetAllStudents();
                MessageBox.Show("İşlem başarılı");
                ClearForm();

            }
            else
            {
                MessageBox.Show("Öğrenci seçiniz");
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

        private void GetAllStudents()
        {
            lstStudentList.Items.Clear();
            _studentService.GetAll().ToList().ForEach(s => lstStudentList.Items.Add(s));
            ;
        }

        private void ClearForm()
        {
            txtStudentName.Text = "";
            txtStudentSurname.Text = "";
            txtStudentNumber.Text = "";
            selected = null;
        }

        Student? selected;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudentList.SelectedIndex != -1)
            {
                selected = (Student?)lstStudentList.SelectedItem;
                txtStudentName.Text = selected.StudentName;
                txtStudentSurname.Text = selected.StudentSurname;
                txtStudentNumber.Text = selected.StudentNumber;

            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtStudentName.Text);
        }
        private void LoadStudents(string searchText = "")
        {
            lstStudentList.Items.Clear();
            var students = _studentService.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                students = students.Where(s => s.StudentName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var student in students)
            {
                lstStudentList.Items.Add(student);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
