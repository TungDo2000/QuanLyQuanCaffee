using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_QuanCafe
{
    class KetNoiCSDL
    {
         public SqlConnection conn;
         public KetNoiCSDL()
        {
            string s = "Data Source=DOTHANHTUNG; Initial Catalog=QL_QuanCaFe; User ID=sa; password=123456789";
            conn = new SqlConnection(s);
        }
        public int moKetNoi()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
                   return 1;
            }
            return 0;
        }
        public void DongKetNoi()
        {
            if (conn.State.ToString() == "Open")
            {
                conn.Close();
            }
        }
    }
}
