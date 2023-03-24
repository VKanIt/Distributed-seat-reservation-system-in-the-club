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
    public partial class WebForm4 : System.Web.UI.Page
    {
        NpgsqlConnection connect;
        NpgsqlCommand com;
        NpgsqlDataReader dr;
        DataSet dataSet1 = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();
            string name = Request.QueryString["name"];
            string numberplace = Request.QueryString["numberplace"];
            string rowplace = Request.QueryString["rowplace"];
            string cost = Request.QueryString["cost"];

            com = new NpgsqlCommand("select datestart,date_part('hour', timestart),date_part('minute', timestart) from event where name='" + name + "';", connect);
            dr = com.ExecuteReader();
            dr.Read();
            Label2.Text = name;
            string str = dr[0].ToString().Substring(0, 11);
            Label5.Text= str;
            if (dr[2].ToString() == "0")
                Label6.Text = dr[1].ToString() + ":" + dr[2].ToString() + "0";
            else
                Label6.Text = dr[1].ToString() + ":" + dr[2].ToString();
            Label1.Text = numberplace;
            Label3.Text = rowplace;
            Label4.Text = cost;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string idevent = Request.QueryString["idevent"];
            string idplace = Request.QueryString["idplace"];
            string s;
            if (RadioButtonList1.SelectedValue == "Мужской")
                s = "1";
            else
                s = "0";
            dataSet1.Clear();
            com = new NpgsqlCommand("insert into client values (default,'"+TextBox1.Text+"','"+ TextBox2.Text + "','"+ TextBox3.Text + "',cast('"+s+"' as integer))", connect);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com);
            adapter.Fill(dataSet1);
            com = new NpgsqlCommand("select id from client where name='" + TextBox1.Text + "' and fam='"+ TextBox2.Text + "' and datebirth=cast('"+TextBox3.Text+ "' as date) and sex=cast('" +s+"' as integer); ", connect);
            dr = com.ExecuteReader();
            dr.Read();
            dataSet1.Clear();
            com = new NpgsqlCommand("insert into reservation values (default,cast('"+dr[0].ToString()+ "' as integer),cast('" + idplace + "' as integer),cast('" + idevent + "' as integer),0)", connect);
            adapter = new NpgsqlDataAdapter(com);
            adapter.Fill(dataSet1);
            com = new NpgsqlCommand("select id from reservation where idclient=cast('" + dr[0].ToString() + "' as integer) and idplace=cast('" + idplace + "' as integer) and idevent=cast('" + idevent + "' as integer);", connect);
            dr = com.ExecuteReader();
            dr.Read();
            Response.Redirect("~/WebForm8.aspx?idres=" + dr[0].ToString());
        }
    }
}