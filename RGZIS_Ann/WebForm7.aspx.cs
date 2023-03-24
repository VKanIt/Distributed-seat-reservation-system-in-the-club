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
    public partial class WebForm7 : System.Web.UI.Page
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
            string s;
            if (RadioButtonList1.SelectedValue == "Мужской")
                s = "1";
            else
                s = "0";
            dataSet1.Clear();
            com = new NpgsqlCommand("insert into client values (default,'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "',cast('" + s + "' as integer))", connect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com);
            adapter.Fill(dataSet1);
            com = new NpgsqlCommand("select id from client where name='" + TextBox1.Text + "' and fam='" + TextBox2.Text + "' and datebirth=cast('" + TextBox3.Text + "' as date) and sex=cast('" + s + "' as integer); ", connect);
            dr = com.ExecuteReader();
            dr.Read();
            dataSet1.Clear();
            com = new NpgsqlCommand("insert into logins values (default,'" + TextBox4.Text + "','" + TextBox5.Text + "',cast('" + dr[0].ToString() + "' as integer))", connect);
            adapter = new NpgsqlDataAdapter(com);
            adapter.Fill(dataSet1);
        }
    }
}