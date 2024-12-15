using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUIn.Forms
{
    public partial class FormBorrowing : Form
    {
        public FormBorrowing()
        {
            InitializeComponent();
        }
        private BorrowingBLL borrowingBLL = new BorrowingBLL();

        //private void LoadComboBoxData()
        //{
        //    // Load Readers
        //    var readers = borrowingBLL.GetReaders();
        //    comboBoxReaderId.DataSource = new BindingSource(readers, null);
        //    comboBoxReaderId.DisplayMember = "Value"; // Hiển thị tên độc giả
        //    comboBoxReaderId.ValueMember = "Key";    // Giá trị là ReaderId

        //    // Load Books
        //    var books = borrowingBLL.GetBooks();
        //    comboBoxBookId.DataSource = new BindingSource(books, null);
        //    comboBoxBookId.DisplayMember = "Value";  // Hiển thị tên sách
        //    comboBoxBookId.ValueMember = "Key";     // Giá trị là BookId
        //}
        private void LoadComboBoxData()
        {
            // Load Readers (hiển thị ReaderId)
            var readers = borrowingBLL.GetReaders();
            comboBoxReaderId.DataSource = new BindingSource(readers, null);
            comboBoxReaderId.DisplayMember = "Key"; // Hiển thị ID độc giả
            comboBoxReaderId.ValueMember = "Key";   // Giá trị là ReaderId

            // Load Books (hiển thị BookId)
            var books = borrowingBLL.GetBooks();
            comboBoxBookId.DataSource = new BindingSource(books, null);
            comboBoxBookId.DisplayMember = "Key";   // Hiển thị ID sách
            comboBoxBookId.ValueMember = "Key";     // Giá trị là BookId
        }
        private void FormBorrowing_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        //private void btnAddBorrowing_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        BorrowingDTO borrowing = new BorrowingDTO
        //        {
        //            ReaderId = (int)comboBoxReaderId.SelectedValue, // ID độc giả
        //            BookId = (int)comboBoxBookId.SelectedValue,     // ID sách
        //            BorrowDate = dateTimePickerBorrowDate.Value,
        //            ReturnDate = dateTimePickerReturnDate.Value
        //        };

        //        if (borrowingBLL.AddBorrowing(borrowing))
        //        {
        //            MessageBox.Show("Thêm giao dịch mượn sách thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm giao dịch thất bại!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}
        private void btnAddBorrowing_Click(object sender, EventArgs e)
        {
            //
            int bookId = int.Parse(TextBoxBookId.Text);
            int readerId = int.Parse(TextBoxReaderId.Text);
            //
            //int bookId = int.Parse(comboBoxBookId.SelectedValue.ToString()); // Lấy ID sách từ ComboBox
            //int readerId = int.Parse(comboBoxReaderId.SelectedValue.ToString()); // Lấy ID độc giả từ ComboBox
            DateTime borrowDate = dateTimePickerBorrowDate.Value.Date; // Lấy ngày mượn từ DateTimePicker
            DateTime returnDate = dateTimePickerReturnDate.Value.Date; // Lấy ngày trả từ DateTimePicker

            // Kiểm tra xem sách có đang được mượn trong khoảng thời gian không
            //if (borrowingBLL.IsBookBorrowedInDateRange(bookId, borrowDate, returnDate))
            //{
            //    MessageBox.Show("Sách đang được mượn trong thời gian này. Vui lòng chọn sách khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Nếu không có xung đột, thêm bản ghi mượn sách
            BorrowingDTO newBorrowing = new BorrowingDTO
            {
                BookId = bookId,
                ReaderId = readerId,
                BorrowDate = borrowDate,
                ReturnDate = returnDate
            };

            //borrowingBLL.AddBorrowing(newBorrowing); // Thêm bản ghi

            //
            int index = borrowingBLL.CheckBorrowing(newBorrowing);
            if (index == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin sách và người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (index == 1)
            {
                MessageBox.Show("Không tìm thấy thông tin sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (index == 2)
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //
            if (borrowingBLL.IsBookBorrowedInDateRange(bookId, borrowDate, returnDate))
            {
                MessageBox.Show("Sách đang được mượn trong thời gian này. Vui lòng chọn sách khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            borrowingBLL.AddBorrowing(newBorrowing);
            MessageBox.Show("Mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật lại giao diện nếu cần
            //LoadBorrowingHistory();
        }    


        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormBorrowingHistory formListBorrowing = new FormBorrowingHistory();
            formListBorrowing.ShowDialog();
        }
    }
}
