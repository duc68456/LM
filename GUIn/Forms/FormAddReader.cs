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
    public partial class FormAddReader : Form
    {
        private ReaderBLL readerBLL = new ReaderBLL();
        public delegate void ReaderAddedEventHandler();
        public event ReaderAddedEventHandler ReaderAdded;
        public FormAddReader()
        {
            InitializeComponent();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            ReaderDTO newReader = new ReaderDTO
            {
                Name = txtName.Text,
                Gender = txtGender.Text,
                IDNumber = txtIDNumber.Text
            };

            try
            {
                readerBLL.AddReader(newReader); // Gọi hàm thêm độc giả từ BLL
                MessageBox.Show("Thêm độc giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kích hoạt sự kiện thông báo độc giả mới đã được thêm (nếu cần)
                ReaderAdded?.Invoke();

                this.Close(); // Đóng form sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
