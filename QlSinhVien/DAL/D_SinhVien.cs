using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class D_SinhVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllSinhVien",Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertSV(Class1 sv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenSv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Ngaysinh", SqlDbType.Date);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Diem", SqlDbType.Float);
            command.Parameters.Add("@XepLoai", SqlDbType.NVarChar, 50);
            command.Parameters["@MaSV"].Value = sv.MaSV1;
            command.Parameters["@TenSV"].Value = sv.TenSV1;
            command.Parameters["@Ngaysinh"].Value = sv.NgaySinh1;
            command.Parameters["@DiaChi"].Value = sv.DiaChi1;
            command.Parameters["@Diem"].Value = sv.Diem1;
            command.Parameters["@XepLoai"].Value = sv.Xeploai1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static void UpdateSV(Class1 sv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenSv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Ngaysinh", SqlDbType.Date);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Diem", SqlDbType.Float);
            command.Parameters.Add("@XepLoai", SqlDbType.NVarChar, 50);
            command.Parameters["@MaSV"].Value = sv.MaSV1;
            command.Parameters["@TenSV"].Value = sv.TenSV1;
            command.Parameters["@Ngaysinh"].Value = sv.NgaySinh1;
            command.Parameters["@DiaChi"].Value = sv.DiaChi1;
            command.Parameters["@Diem"].Value = sv.Diem1;
            command.Parameters["@XepLoai"].Value = sv.Xeploai1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static void DeleteSV(string masv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSv", SqlDbType.NVarChar, 50);
            command.Parameters["@MaSV"].Value = masv;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }

    }
}
