using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace PhanmemQLKTXSV
{
    class clsConnect
    {
        SqlConnection con;
        string connect = @"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True";
        DataTable dt;

        //viết hàm đóng mở kết nối
        public SqlConnection OpenConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection CloseConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }


        //hàm load dữ liệu
        public DataTable LoadData()//để vào đây
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("LoadDL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        //hàm tìm kiếm + thêm điều kiện
        public DataTable Timkiem( string Chuoitimkiem)
        {
            OpenConnect();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("TKtheoten", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("hoten", SqlDbType.NVarChar)).Value = Chuoitimkiem;//họ tên là biến trong stored
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;

        }
    }
}
