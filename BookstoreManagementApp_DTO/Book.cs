using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    public class Book // Lớp để lưu trữ thông tin sách
    {
        private string _bookID;

        public string BookID
        {
            get { return _bookID; }
            set { _bookID = value; }
        }

        private string _bookName;

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private string _bookAuthorName;

        public string BookAuthorName
        {
            get { return _bookAuthorName; }
            set { _bookAuthorName = value; }
        }

        private string _bookTranslatorName;

        public string BookTranslatorName
        {
            get { return _bookTranslatorName; }
            set { _bookTranslatorName = value; }
        }

        private DateTime _bookPublishedDay;

        public DateTime BookPublishedDay
        {
            get { return _bookPublishedDay; }
            set { _bookPublishedDay = value; }
        }

        private int _bookRepublisedTime;

        public int BookRepublishedTime
        {
            get { return _bookRepublisedTime; }
            set { _bookRepublisedTime = value; }
        }

        private int _bookPrice;

        public int BookPrice
        {
            get { return _bookPrice; }
            set { _bookPrice = value; }
        }

        private string _bookType;

        public string BookType
        {
            get { return _bookType; }
            set { _bookType = value; }
        }

        private string _bookTitleCode;

        public string BookTitleCode
        {
            get { return _bookTitleCode; }
            set { _bookTitleCode = value; }
        }

    }
}
