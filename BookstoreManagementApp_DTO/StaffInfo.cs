using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementApp_DTO
{
    // Lớp để thao tác lưu trữ thông tin của nhân viên trong database
    public class StaffInfo
    {
        private string _staffName;

        public string StaffName
        {
            get { return _staffName; }
            set { _staffName = value; }
        }

        private string _staffID;

        public string StaffID
        {
            get { return _staffID; }
            set { _staffID = value; }
        }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private int _staffSalry;

        public int StaffSalary
        {
            get { return _staffSalry; }
            set { _staffSalry = value; }
        }

        private int _worksDate;

        public int WorksDay
        {
            get { return _worksDate; }
            set { _worksDate = value; }
        }

    }
}
