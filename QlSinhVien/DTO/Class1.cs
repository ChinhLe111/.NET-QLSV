using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class1
    {
        private String MaSV;
        private String TenSV;
        private DateTime NgaySinh;
        private String DiaChi;
        private float Diem;
        private String Xeploai;

        public Class1(string maSV, string tenSV, DateTime ngaySinh, string diaChi, float diem, string xeploai)
        {
            MaSV = maSV;
            TenSV = tenSV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Diem = diem;
            Xeploai = xeploai;
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public float Diem1 { get => Diem; set => Diem = value; }
        public string Xeploai1 { get => Xeploai; set => Xeploai = value; }
    }
}
