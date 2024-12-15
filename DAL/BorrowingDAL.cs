using DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowingDAL
    {
        private string connectionString = @"Data Source=DELLVOSTRO;Initial Catalog=LibraryDB;Integrated Security=True;Trust Server Certificate=True";

        public bool AddBorrowing(BorrowingDTO borrowing)
        {
            string query = "INSERT INTO Borrowings (ReaderId, BookId, BorrowDate, ReturnDate) " +
                           "VALUES (@ReaderId, @BookId, @BorrowDate, @ReturnDate)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReaderId", borrowing.ReaderId);
                command.Parameters.AddWithValue("@BookId", borrowing.BookId);
                command.Parameters.AddWithValue("@BorrowDate", borrowing.BorrowDate);
                command.Parameters.AddWithValue("@ReturnDate", (object)borrowing.ReturnDate ?? DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public List<KeyValuePair<int, string>> GetReaders()
        {
            string query = "SELECT ReaderId, Name FROM Readers";
            List<KeyValuePair<int, string>> readers = new List<KeyValuePair<int, string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    readers.Add(new KeyValuePair<int, string>(
                        reader.GetInt32(0), reader.GetString(1)
                    ));
                }
            }
            return readers;
        }

        public List<KeyValuePair<int, string>> GetBooks()
        {
            string query = "SELECT BookId, Title FROM Books";
            List<KeyValuePair<int, string>> books = new List<KeyValuePair<int, string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new KeyValuePair<int, string>(
                        reader.GetInt32(0), reader.GetString(1)
                    ));
                }
            }
            return books;
        }
        public List<BorrowingHistoryDTO> GetBorrowingHistory()
        {
            string query = @"
        SELECT 
            r.Name AS ReaderName, 
            b.Title AS BookTitle, 
            br.BorrowDate, 
            br.ReturnDate
        FROM 
            Borrowings br
        INNER JOIN Readers r ON br.ReaderId = r.ReaderId
        INNER JOIN Books b ON br.BookId = b.BookId";

            List<BorrowingHistoryDTO> borrowingHistory = new List<BorrowingHistoryDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    borrowingHistory.Add(new BorrowingHistoryDTO
                    {
                        ReaderName = reader["ReaderName"].ToString(),
                        BookTitle = reader["BookTitle"].ToString(),
                        BorrowDate = Convert.ToDateTime(reader["BorrowDate"]),
                        ReturnDate = Convert.ToDateTime(reader["ReturnDate"])
                    });
                }
                reader.Close();
            }

            return borrowingHistory;
        }
        public bool IsBookBorrowedOnDate(int bookId, DateTime date)
        {
            string query = @"
        SELECT COUNT(*)
        FROM Borrowings
        WHERE BookId = @BookId
        AND @Date BETWEEN BorrowDate AND ReturnDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookId", bookId);
                command.Parameters.AddWithValue("@Date", date);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0; // True nếu có ít nhất 1 bản ghi mượn sách trong ngày
            }
        }
        public bool IsBookBorrowedInDateRange(int bookId, DateTime borrowDate, DateTime returnDate)
        {
            string query = @"
        SELECT COUNT(*)
        FROM Borrowings
        WHERE BookId = @BookId
        AND (
            (BorrowDate <= @ReturnDate AND ReturnDate >= @BorrowDate)
        )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookId", bookId);
                command.Parameters.AddWithValue("@BorrowDate", borrowDate);
                command.Parameters.AddWithValue("@ReturnDate", returnDate);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0; // True nếu có xung đột
            }
        }

    }
}
