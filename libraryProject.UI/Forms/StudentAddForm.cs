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

        public StudentAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _studentRepository = new StudentRepository(context);
            _studentService = new StudentService(_studentRepository);
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
                    if (_studentService.IfEntityExists(s => s.StudentName == studentName))
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
                    MessageBox.Show("İşlem başarılı");
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

        }

       
    }
}
