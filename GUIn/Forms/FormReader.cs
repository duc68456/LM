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
    public partial class FormReader : Form
    {
        public delegate void ReaderAddedEventHandler();
        public event ReaderAddedEventHandler ReaderAdded;
        private ReaderBLL readerBLL = new ReaderBLL();
        public FormReader()
        {
            InitializeComponent();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            FormAddReader formAddReader = new FormAddReader();

            // Đăng ký sự kiện BookAdded để cập nhật danh sách sách
            formAddReader.ReaderAdded += LoadReaders;

            formAddReader.ShowDialog();
        }
        private void LoadReaders()
        {
            try
            {
                List<ReaderDTO> readers = readerBLL.GetAllReaders(); // Lấy danh sách độc giả từ BLL
                dataGridViewReaders.DataSource = readers; // dataGridViewReaders là DataGridView hiển thị danh sách độc giả
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReader_Load(object sender, EventArgs e)
        {
            LoadReaders();
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            if (dataGridViewReaders.SelectedRows.Count > 0)
            {
                int readerId = Convert.ToInt32(dataGridViewReaders.SelectedRows[0].Cells["ReaderId"].Value);

                try
                {
                    readerBLL.DeleteReader(readerId); // Gọi hàm xóa từ BLL
                    MessageBox.Show("Xóa độc giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReaders(); // Tải lại danh sách độc giả
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn không
            if (dataGridViewReaders.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewReaders.SelectedRows[0].Index;

                // Lấy ID của độc giả đang được chọn
                int readerId = Convert.ToInt32(dataGridViewReaders.Rows[selectedRowIndex].Cells["ReaderId"].Value);

                // Lấy thông tin độc giả từ CSDL thông qua BLL
                ReaderDTO selectedReader = readerBLL.GetReaderById(readerId);

                if (selectedReader != null)
                {
                    // Mở FormUpdateReader để sửa thông tin độc giả
                    FormUpdateReader formUpdateReader = new FormUpdateReader(selectedReader);

                    // Hiển thị FormUpdateReader và chờ khi form này đóng lại
                    formUpdateReader.ShowDialog();

                    // Sau khi sửa, làm mới lại DataGridView
                    LoadReaders();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả trong cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một độc giả để sửa.");
            }
        }
    }
}
