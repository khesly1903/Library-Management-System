using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;

namespace libraryProject.UI.Forms
{
    public partial class PublisherAddForm : Form
    {

        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;

        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;

        Publisher? selected;
        public PublisherAddForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _publisherRepository = new PublisherRepository(context);
            _publisherService = new PublisherService(_publisherRepository);


            _bookRepository = new BookRepository(context);
            _bookService = new BookService(_bookRepository);

        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {

            GetAllPublisher();
        }

        private void GetAllPublisher()
        {
            lstPublisherList.Items.Clear();
            _publisherService.GetAll().ToList().ForEach(p => lstPublisherList.Items.Add(p));
        }

        private void btnPublisherSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {
                    string publisherName = txtPublisherName.Text;
                    if (_publisherService.IfEntityExists(p => p.PublisherName == publisherName))
                    {
                        throw new Exception("Yayınevi zaten mevcut");
                    }
                    Publisher publisher = new Publisher()
                    {
                        PublisherName = txtPublisherName.Text,
                        ContactNumber = txtContactNumber.Text,
                        Address = txtPublisherAddress.Text
                    };
                    _publisherService.Create(publisher);
                    GetAllPublisher();
                    MessageBox.Show("işlem başarılı");

                    ClearForm();
                }
                else //update
                {
                    selected.PublisherName = txtPublisherName.Text;
                    selected.ContactNumber = txtContactNumber.Text;
                    selected.Address = txtPublisherAddress.Text;
                    _publisherService.Update(selected);
                    GetAllPublisher();
                    MessageBox.Show("Güncellendi");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPublisherDelete_Click(object sender, EventArgs e)
        {


            List<Book> books = new List<Book>();
            books = GetAllBooksList();

            foreach (Book book in books)
            {
                if (selected == book.Publiser)
                {
                    MessageBox.Show("Kitabı olan yayın evi silinemez");
                    return;
                }
            }
            if (selected != null)
            {
                _publisherService.Delete(selected.Id);
                GetAllPublisher();
                MessageBox.Show("işlem başarılı");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Yayınevi seçiniz");
            }
        }

        private List<Book> GetAllBooksList()
        {

            var books = _bookService.GetAll().ToList();
            List<Book> bookList = new List<Book>();
            foreach (var book in books)
            {
                Book current_book = _bookService.GetById(book.Id);
                bookList.Add(current_book);
            }

            return bookList;
        }
        private void ClearForm()
        {
            txtPublisherName.Text = "";
            txtContactNumber.Text = "";
            txtPublisherAddress.Text = "";
            selected = null;
        }

        private void lstPublisherList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPublisherList.SelectedIndex != -1)
            {
                selected = (Publisher)lstPublisherList.SelectedItem;
                txtPublisherName.Text = selected.PublisherName;
                txtContactNumber.Text = selected.ContactNumber;
                txtPublisherAddress.Text = selected.Address;
            }
        }

        private void txtPublisherName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
