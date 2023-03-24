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
    public partial class WebForm6 : System.Web.UI.Page
    {
        NpgsqlConnection connect;
        NpgsqlCommand com;
        NpgsqlDataReader dr;
        DataSet dataSet1 = new DataSet();
        DataSet dataSet2 = new DataSet();
        void load()
        {
            string idclient = Request.QueryString["idcl"];
            string sql1 = "select cl.name,cl.fam,cl.datebirth from client as cl where cl.id=cast('" + idclient + "' as integer);";
            NpgsqlCommand com1 = new NpgsqlCommand(sql1, connect);
            dr = com1.ExecuteReader();
            dr.Read();
            Label2.Text = dr[0].ToString();
            Label1.Text = dr[1].ToString();
            Label3.Text = dr[2].ToString().Substring(0, 11);

            string sql = "select r.id,ev.name, pl.number,pl.row,ev.datestart,ev.timestart,tp.cost::money::numeric::float8,r.statecost from reservation as r, event as ev, place as pl,typeplace as tp where r.idclient=cast('" + idclient + "' as integer)"
                + " and tp.idtype=pl.type and pl.id=r.idplace and ev.id=r.idevent;";
            com = new NpgsqlCommand(sql, connect);
            try
            {

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com))
                {

                    dataSet1.Clear();
                    adapter.Fill(dataSet1);

                    GridView1.DataSource = dataSet1.Tables[0];
                    GridView1.DataBind();

                    int columnsNumber = dataSet1.Tables[0].Columns.Count;
                    int rowsNumber = dataSet1.Tables[0].Rows.Count;
                    for (int i = 1; i <= columnsNumber; i++)
                    {
                        if (GridView1.HeaderRow.Cells[i].Text == "id")
                            GridView1.HeaderRow.Cells[i].Text = "Номер брони";
                        if (GridView1.HeaderRow.Cells[i].Text == "name")
                            GridView1.HeaderRow.Cells[i].Text = "Мероприятие";
                        if (GridView1.HeaderRow.Cells[i].Text == "number")
                            GridView1.HeaderRow.Cells[i].Text = "Номер места";
                        if (GridView1.HeaderRow.Cells[i].Text == "row")
                            GridView1.HeaderRow.Cells[i].Text = "Номер ряда";
                        if (GridView1.HeaderRow.Cells[i].Text == "datestart")
                            GridView1.HeaderRow.Cells[i].Text = "Дата мероприятия";
                        if (GridView1.HeaderRow.Cells[i].Text == "timestart")
                            GridView1.HeaderRow.Cells[i].Text = "Время начала мероприятия";
                        if (GridView1.HeaderRow.Cells[i].Text == "cost")
                            GridView1.HeaderRow.Cells[i].Text = "Стоимость билета (руб)";
                        if (GridView1.HeaderRow.Cells[i].Text == "statecost")
                            GridView1.HeaderRow.Cells[i].Text = "Статус оплаты";
                    }
                    for (int i = 0; i < rowsNumber; i++)
                    {

                        GridView1.Rows[i].Cells[5].Text = GridView1.Rows[i].Cells[5].Text.Substring(0, 11);
                        GridView1.Rows[i].Cells[6].Text = GridView1.Rows[i].Cells[6].Text.Substring(11, 5);
                        if (GridView1.Rows[i].Cells[8].Text.Equals("1"))
                        {
                            GridView1.Rows[i].Cells[8].Text = "Оплачено";
                        }
                        else
                        {
                            GridView1.Rows[i].Cells[8].Text = "Не оплачено";
                        }
                    }
                }

            }
            catch { }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();
            load();
           
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            
            if (e.CommandName == "delet")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];

                string sql = "delete from reservation where id=cast('" + row.Cells[1].Text + "' as integer)";
                com = new NpgsqlCommand(sql, connect);
                dataSet2.Clear();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com);
                adapter.Fill(dataSet2);
            }
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string idres = TextBox4.Text;
            Response.Redirect("~/WebForm9.aspx?idres1=" + idres);
        }
    }
}