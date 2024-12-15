using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using DTO;
using BLL;
using Microsoft.Data.SqlClient;

namespace GUIn.Forms
{
    public partial class FormUpdateBook : Form
    {
        private BookBLL bookBLL = new BookBLL();
        private BookDTO bookToUpdate;
        //public delegate void BookAddedEventHandler();
        //public event BookAddedEventHandler BookUpdated;
        //public FormUpdateBook()
        //{
        //    InitializeComponent();
        //}
        public FormUpdateBook(BookDTO book)
        {
            InitializeComponent();
            bookToUpdate = book;

            // Gán giá trị ban đầu vào các TextBox
            txtTitle.Text = bookToUpdate.Title;
            txtAuthor.Text = bookToUpdate.Author;
            txtCategory.Text = bookToUpdate.Category;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            // Cập nhật lại thông tin sách
            bookToUpdate.Title = txtTitle.Text;
            bookToUpdate.Author = txtAuthor.Text;
            bookToUpdate.Category = txtCategory.Text;

            try
            {
                bookBLL.UpdateBook(bookToUpdate); // Gọi phương thức cập nhật
                MessageBox.Show("Cập nhật sách thành công!");
                this.Close(); // Đóng form sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
