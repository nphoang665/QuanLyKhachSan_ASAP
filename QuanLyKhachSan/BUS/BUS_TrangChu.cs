using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_TrangChu
    {
        DA_TrangChu da;
        public BUS_TrangChu() { 
            da= new DA_TrangChu();
        }
        public dynamic LayTen(string tk)
        {
         string kq=   da.LayTenTk(tk);
            
            return kq;

        }
    }
}
