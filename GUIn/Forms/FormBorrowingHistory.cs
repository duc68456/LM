using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIn.Forms
{
    public partial class FormBorrowingHistory : Form
    {
        private BorrowingBLL borrowingBLL = new BorrowingBLL();
        public FormBorrowingHistory()
        {
            InitializeComponent();
        }

        private void FormBorrowingHistory_Load(object sender, EventArgs e)
        {
            LoadBorrowingHistory();
        }
        private void LoadBorrowingHistory()
        {
            List<BorrowingHistoryDTO> borrowingHistory = borrowingBLL.GetBorrowingHistory();
            dataGridViewBorrowings.DataSource = borrowingHistory;

            // Đặt tên cột hiển thị
            dataGridViewBorrowings.Columns["ReaderName"].HeaderText = "Tên Độc Giả";
            dataGridViewBorrowings.Columns["BookTitle"].HeaderText = "Tên Sách";
            dataGridViewBorrowings.Columns["BorrowDate"].HeaderText = "Ngày Mượn";
            dataGridViewBorrowings.Columns["ReturnDate"].HeaderText = "Ngày Trả";

            // Định dạng ngày tháng
            dataGridViewBorrowings.Columns["BorrowDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewBorrowings.Columns["ReturnDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
