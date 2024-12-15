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
using static GUIn.Forms.FormAddBook;
using DAL;

namespace GUIn.Forms
{
    public partial class FormBook : Form
    {
        BookBLL bookBLL = new BookBLL();
        BorrowingBLL borrowingBLL = new BorrowingBLL();
        public event BookAddedEventHandler BookUpdated;
        public FormBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();

            // Đăng ký sự kiện BookAdded để cập nhật danh sách sách
            formAddBook.BookAdded += LoadBooks;

            formAddBook.ShowDialog();
        }
        //public void LoadBooks()
        //{
        //    List<BookDTO> books = bookBLL.GetAllBooks();
        //    dataGridViewBooks.DataSource = books;
        //}

        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
            UpdateBookStatus();
        }
        //
        private void LoadBooks()
        {
            try
            {
                List<BookDTO> books = bookBLL.GetBooks();
                dataGridViewBooks.DataSource = books; // dgvBooks là DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["BookId"].Value);

                try
                {
                    bookBLL.DeleteBook(bookId);
                    MessageBox.Show("Xóa sách thành công!");
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!");
            }
        }

        //private void btnUpdateBook_Click(object sender, EventArgs e)
        //{
        //    FormUpdateBook formUpdateBook = new FormUpdateBook();

        //    // Đăng ký sự kiện BookAdded để cập nhật danh sách sách
        //    formUpdateBook.BookUpdated += LoadBooks;

        //    formUpdateBook.ShowDialog();
        //}
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn không
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewBooks.SelectedRows[0].Index;

                // Lấy ID của sách đang được chọn
                int bookId = Convert.ToInt32(dataGridViewBooks.Rows[selectedRowIndex].Cells["BookId"].Value);

                // Lấy thông tin sách từ CSDL thông qua BLL
                BookDTO selectedBook = bookBLL.GetBookById(bookId);

                if (selectedBook != null)
                {
                    // Mở FormUpdateBook để sửa sách
                    FormUpdateBook formUpdateBook = new FormUpdateBook(selectedBook);

                    // Hiển thị FormUpdateBook và chờ khi form này đóng lại
                    formUpdateBook.ShowDialog();

                    // Sau khi sửa, làm mới lại DataGridView
                    LoadBooks();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách trong cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để sửa.");
            }
        }

        private void Today_ValueChanged(object sender, EventArgs e)
        {
            UpdateBookStatus();
        }
        private void UpdateBookStatus()
        {
            DateTime selectedDate = Today.Value.Date;
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                if (row.Cells["BookId"] != null && int.TryParse(row.Cells["BookId"].Value.ToString(), out int bookId))
                {
                    bool isBorrowed = borrowingBLL.IsBookBorrowedOnDate(bookId, selectedDate);
                    row.Cells["Status"].Value = isBorrowed ? "Đang được mượn" : "Còn Sách";
                }
            }
        }

        private void dataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang xử lý cột "Trạng Thái"
            if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Đang được mượn")
                {
                    e.CellStyle.ForeColor = Color.Red; // Chữ màu đỏ
                    e.CellStyle.BackColor = Color.LightPink; // Nền hồng nhạt
                }
                else if (status == "Còn Sách")
                {
                    e.CellStyle.ForeColor = Color.Green; // Chữ màu xanh lá
                    e.CellStyle.BackColor = Color.LightGreen; // Nền xanh lá nhạt
                }
            }
        }
    }
}
