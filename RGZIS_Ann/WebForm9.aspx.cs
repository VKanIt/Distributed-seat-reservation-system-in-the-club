using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using Mono.Security;
using System.Data;

namespace RGZIS_Ann
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        NpgsqlConnection connect;
        NpgsqlCommand com;
        NpgsqlDataReader dr;
        DataSet dataSet1 = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string idres = Request.QueryString["idres1"];
            dataSet1.Clear();
            com = new NpgsqlCommand("update reservation set statecost=1 where id=cast('"+idres+"' as integer);", connect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com);
            adapter.Fill(dataSet1);
        }
    }
}