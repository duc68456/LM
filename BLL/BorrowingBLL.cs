using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BorrowingBLL
    {
        private BorrowingDAL borrowingDAL = new BorrowingDAL();
        //
        private BookBLL bookBLL = new BookBLL();
        private ReaderBLL readerBLL = new ReaderBLL();
        //
        public int CheckBorrowing(BorrowingDTO borrowing)
        {
            BookDTO book = new BookDTO();
            ReaderDTO reader = new ReaderDTO();
            book = bookBLL.GetBookById(borrowing.BookId);
            reader = readerBLL.GetReaderById(borrowing.ReaderId);
            if (book == null && reader == null)
                return 0;
            else if (book == null)
                return 1;
            else if (reader == null)
                return 2;
            return 3;
        }
        public bool AddBorrowing(BorrowingDTO borrowing)
        {
            if (borrowing.ReaderId <= 0 || borrowing.BookId <= 0 || borrowing.BorrowDate == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid borrowing information.");
            }
            return borrowingDAL.AddBorrowing(borrowing);
        }
        //public int AddBorrowing(BorrowingDTO borrowing)
        //{
        //    if (borrowing.ReaderId <= 0 || borrowing.BookId <= 0 || borrowing.BorrowDate == DateTime.MinValue)
        //    {
        //        throw new ArgumentException("Invalid borrowing information.");
        //    }
        //    BookDTO book = new BookDTO();
        //    ReaderDTO reader = new ReaderDTO();
        //    book = bookBLL.GetBookById(borrowing.BookId);
        //    reader = readerBLL.GetReaderById(borrowing.ReaderId);
        //    if (book == null && reader == null)
        //        return 0;
        //    else if (book == null)
        //        return 1;
        //    else if (reader == null)
        //        return 2;
        //    else
        //    {
        //        borrowingDAL.AddBorrowing(borrowing);
        //        return 3;
        //    }
        //}
        public List<KeyValuePair<int, string>> GetReaders()
        {
            return borrowingDAL.GetReaders();
        }

        public List<KeyValuePair<int, string>> GetBooks()
        {
            return borrowingDAL.GetBooks();
        }
        public List<BorrowingHistoryDTO> GetBorrowingHistory()
        {
            return borrowingDAL.GetBorrowingHistory();
        }
        public bool IsBookBorrowedOnDate(int bookId, DateTime date)
        {
            return borrowingDAL.IsBookBorrowedOnDate(bookId, date);
        }
        public bool IsBookBorrowedInDateRange(int bookId, DateTime borrowDate, DateTime returnDate)
        {
            return borrowingDAL.IsBookBorrowedInDateRange(bookId, borrowDate, returnDate);
        }

    }
}
