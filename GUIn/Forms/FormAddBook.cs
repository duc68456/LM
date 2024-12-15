using BLL;
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

namespace GUIn.Forms
{
    public partial class FormAddBook : Form
    {
        public delegate void BookAddedEventHandler();
        public event BookAddedEventHandler BookAdded;

        private BookBLL bookBLL = new BookBLL();
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            BookDTO newBook = new BookDTO
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Category = txtCategory.Text
            };

            try
            {
                bookBLL.AddBook(newBook);
                MessageBox.Show("Thêm sách thành công!");

                // Kích hoạt sự kiện thông báo sách mới đã được thêm
                BookAdded?.Invoke();

                this.Close(); // Đóng form sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
