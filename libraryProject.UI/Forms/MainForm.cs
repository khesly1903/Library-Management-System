using System;
using System.Windows.Forms;
using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;

namespace libraryProject.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void btnGoStudentAddForm_Click(object sender, EventArgs e)
        {
            var studentAddForm = new StudentAddForm();
            OpenFormInPanel(studentAddForm);
        }

        private void btnGoAuthorAddForm_Click(object sender, EventArgs e)
        {
            var authorAddForm = new AuthorAddForm();
            OpenFormInPanel(authorAddForm);
        }

        private void btnGoBookAddForm_Click(object sender, EventArgs e)
        {
            var bookAddForm = new BookAddForm2();
            OpenFormInPanel(bookAddForm);
        }

        private void btnGoPublisherAddForm_Click(object sender, EventArgs e)
        {
            var publisherAddForm = new PublisherAddForm();
            OpenFormInPanel(publisherAddForm);
        }

        private void btnGoLoanForm_Click(object sender, EventArgs e)
        {
            var loanForm = new LoanForm();
            OpenFormInPanel(loanForm);
        }

        private void btnGoReturnForm_Click(object sender, EventArgs e)
        {
            var returnForm = new ReturnForm();
            OpenFormInPanel(returnForm);
        }
    }
}
