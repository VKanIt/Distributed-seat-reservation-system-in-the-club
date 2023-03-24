using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using Mono.Security;
using System.Data;
using System.Diagnostics;

namespace RGZIS_Ann
{
    public partial class WebForm5 : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            com = new NpgsqlCommand("select login,password,idcl from logins;", connect);
            string idclient="";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (TextBox1.Text == dr[0].ToString() && TextBox2.Text == dr[1].ToString())
                {
                    idclient = dr[2].ToString();
                    Debug.WriteLine(idclient);
                    
                }
            }
            if(idclient!="")
                Response.Redirect("~/WebForm6.aspx?idcl="+idclient);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm7.aspx");
        }
    }
}