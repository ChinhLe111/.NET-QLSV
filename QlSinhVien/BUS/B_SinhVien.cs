using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_SinhVien
    {
     public static DataTable GetAllSinhVien()
        {
            return D_SinhVien.getData();
        }
        public static void InsertSinhVien(Class1 sv)
        {
            D_SinhVien.InsertSV(sv);
        }
        public static void UpdateSinhVien(Class1 sv)
        {
            D_SinhVien.UpdateSV(sv);
        }
        public static void DeleteSinhVien(string masv)
        {
            D_SinhVien.DeleteSV(masv);
        }
    }
}
