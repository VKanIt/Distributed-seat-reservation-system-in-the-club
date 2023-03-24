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
    public partial class WebForm3 : System.Web.UI.Page
    {
        NpgsqlConnection connect;
        NpgsqlCommand com;
        NpgsqlDataReader dr;
        DataSet dataSet1 = new DataSet();
        void droplist()
        {
            com = new NpgsqlCommand("select pl.number from place as pl, typeplace as tp where pl.type=tp.idtype and not(pl.id in (select pl.id from event as ev, reservation as r,place as pl, typeplace as tp where r.idplace=pl.id" +
" and pl.type = tp.idtype and ev.id = r.idevent and ev.name = '" + DropDownList3.SelectedItem.Text + "'));", connect);
            dr = com.ExecuteReader();

            DropDownList4.Items.Clear();
            while (dr.Read())
            {
                DropDownList4.Items.Add(dr[0].ToString());
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();

            com = new NpgsqlCommand("select name from event;", connect);
            dr = com.ExecuteReader();
            if (!IsPostBack)
            {
                DropDownList3.Items.Clear();
                while (dr.Read())
                {
                    DropDownList3.Items.Add(dr[0].ToString());
                }
                string name = Request.QueryString["name"];
                string url = Request.QueryString["url"];
                if (url == "WebForm3")
                {
                    DropDownList3.Items.FindByValue(name).Selected = true;
                    droplist();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            com = new NpgsqlCommand("select id from event where name='"+ DropDownList3.SelectedItem.Text + "';", connect);
            NpgsqlDataReader dr1 = com.ExecuteReader();
            dr1.Read();
            com = new NpgsqlCommand("select id from place where number=cast('" + DropDownList4.SelectedItem.Text + "' as integer) and row=cast('"+ Label1.Text + "' as integer);", connect);
            NpgsqlDataReader dr2 = com.ExecuteReader();
            dr2.Read();
            Response.Redirect("~/WebForm4.aspx?name=" + DropDownList3.SelectedItem.Text + "&numberplace=" + DropDownList4.SelectedItem.Text+ "&rowplace="+ Label1.Text+"&cost="+ Label2.Text+"&idevent="+ dr1[0].ToString()+"&idplace="+ dr2[0].ToString());
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            droplist();
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            com = new NpgsqlCommand("select pl.row, tp.cost::money::numeric::float8 from typeplace as tp, place as pl where pl.type=tp.idtype and pl.id=cast('"+ DropDownList4.SelectedItem.Text + "' as integer);",connect);
            dr = com.ExecuteReader();
            dr.Read();
            Label1.Text = dr[0].ToString();
            Label2.Text = dr[1].ToString()+" р.";
        }
    }
}