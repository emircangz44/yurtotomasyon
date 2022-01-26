using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Yurtotomasyon
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=yurtoto.database.windows.net;Initial Catalog=yurtotomasyon;User ID=samsunlu55621;Password=SamsunLu5562");
            baglan.Open();
            return baglan;
        }
    }
}
