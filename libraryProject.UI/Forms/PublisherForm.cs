﻿using libraryProject.Business.Services;
using libraryProject.DataAccess.Context;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;

namespace libraryProject.UI.Forms
{
    public partial class PublisherForm : Form
    {

        private readonly PublisherService _publisherService;
        private readonly PublisherRepository _publisherRepository;
        Publisher? selected;
        public PublisherForm()
        {
            InitializeComponent();
            var context = new AppDBContext();
            _publisherRepository = new PublisherRepository(context);
            _publisherService = new PublisherService(_publisherRepository);
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
                    MessageBox.Show("işlem başarılı");
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
