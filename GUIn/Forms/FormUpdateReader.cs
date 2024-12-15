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
    public partial class FormUpdateReader : Form
    {
        private ReaderDTO selectedReader;
        private ReaderBLL readerBLL = new ReaderBLL();
        public FormUpdateReader(ReaderDTO reader)
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện

            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            selectedReader = reader;

            // Hiển thị thông tin của độc giả lên giao diện
            txtName.Text = selectedReader.Name;
            txtGender.Text = selectedReader.Gender;
            txtIDNumber.Text = selectedReader.IDNumber;
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            selectedReader.Name = txtName.Text;
            selectedReader.Gender = txtGender.Text;
            selectedReader.IDNumber = txtIDNumber.Text;

            try
            {
                readerBLL.UpdateReader(selectedReader); // Gọi hàm cập nhật từ BLL
                MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
