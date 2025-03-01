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
        Author? selected;

        public AuthorAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(_authorRepository);
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
                    MessageBox.Show("İşlem başarılı");
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

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
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
