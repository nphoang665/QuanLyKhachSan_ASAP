using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_DichVu
    {
        DA_DichVu da;
        public BUS_DichVu() { 
        da= new DA_DichVu();
        }
        public void LoadDichVu(DataGridView dgv)
        {
            dgv.DataSource = da.LoadDichVu();
        }
    }
}
