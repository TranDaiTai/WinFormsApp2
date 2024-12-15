using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    public class Table
    {
        private int _id { get; set; }
        private string _status { get; set; }
        public Table(int id, string status)
        {
            _id = id;
            _status = status;
        }
    }
}
