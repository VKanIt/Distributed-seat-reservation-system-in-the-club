using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Npgsql;
using Mono.Security;
using System.Data;
using System.Diagnostics;

namespace RGZIS_Ann
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        NpgsqlConnection connect;
        NpgsqlCommand com;
        NpgsqlDataReader dr;
        DataSet dataSet1 = new DataSet();
        string getMonth(string number)
        {
            string r = "";
            switch (number)
            {
                case "1":
                    r = "января";
                    break;
                case "2":
                    r = "февраля";
                    break;
                case "3":
                    r = "марта";
                    break;
                case "4":
                    r = "апреля";
                    break;
                case "5":
                    r = "мая";
                    break;
                case "6":
                    r = "июня";
                    break;
                case "7":
                    r = "июля";
                    break;
                case "8":
                    r = "августа";
                    break;
                case "9":
                    r = "сентября";
                    break;
                case "10":
                    r = "октября";
                    break;
                case "11":
                    r = "ноября";
                    break;
                case "12":
                    r = "декабря";
                    break;
            }
            return r;
        }
        void load(string sql, string sql1)
        {
            com = new NpgsqlCommand(sql, connect);
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(com))
            {

                dataSet1.Clear();
                adapter.Fill(dataSet1);
            }
            NpgsqlCommand com1 = new NpgsqlCommand(sql1, connect);
            NpgsqlDataReader dr1 = com1.ExecuteReader();
            dr1.Read();
            Table1.Rows.Clear();
            int countEvent = Convert.ToInt32(dr1[0].ToString());

            int countColumn = 3;
            int countRow = countEvent - countColumn;
            int k = 0;
            if (countEvent != 0)
            {
                Panel1.Visible = false;
                if (countEvent == 1)
                {
                    countRow = 1;
                    countColumn = 1;
                }
                if (countEvent == 2)
                {
                    countRow = 1;
                    countColumn = 2;
                }
                if (countEvent == 3)
                {
                    countRow = 1;
                    countColumn = 3;
                }
                for (int RowNum = 1; RowNum <= countRow; RowNum++)
                {
                    TableRow tempRow = new TableRow();
                    for (int cellNum = 1; cellNum <= countColumn; cellNum++)
                    {
                        if (k < countEvent)
                        {
                            Panel panel = new Panel();
                            panel.BorderColor = ColorTranslator.FromHtml("black");
                            panel.BorderStyle = BorderStyle.Double;
                            panel.BackColor = ColorTranslator.FromHtml("white");
                            panel.Height = Unit.Pixel(400);
                            panel.Width = Unit.Pixel(400);
                            panel.Visible = true;
                            Panel panelchild = new Panel();
                            panelchild.BackColor = ColorTranslator.FromHtml("black");
                            panelchild.Height = Unit.Pixel(110);
                            panelchild.Width = Unit.Pixel(400);
                            panelchild.CssClass = "panel";
                            panelchild.Visible = true;
                            Label label1 = new Label();
                            Label label2 = new Label();
                            label1.Font.Name = "Arial";
                            label2.Font.Name = "Arial";
                            label1.CssClass = "label1";
                            label2.CssClass = "label2";
                            label1.ForeColor = ColorTranslator.FromHtml("white");
                            label2.ForeColor = ColorTranslator.FromHtml("white");

                            string month = getMonth(dataSet1.Tables[0].Rows[k][3].ToString());
                            label1.Text = dataSet1.Tables[0].Rows[k][2].ToString() + " " + month;
                            if (dataSet1.Tables[0].Rows[k][5].ToString() == "0")
                                label2.Text = dataSet1.Tables[0].Rows[k][4].ToString() + ":" + dataSet1.Tables[0].Rows[k][5].ToString() + "0";
                            else
                                label2.Text = dataSet1.Tables[0].Rows[k][4].ToString() + ":" + dataSet1.Tables[0].Rows[k][5].ToString();

                            panelchild.Controls.Add(label1);
                            panelchild.Controls.Add(new LiteralControl("<br/>"));
                            panelchild.Controls.Add(label2);


                            Label label3 = new Label();
                            label3.ForeColor = ColorTranslator.FromHtml("black");
                            label3.Font.Name = "Arial";
                            label3.CssClass = "label3";
                            label3.Text = dataSet1.Tables[0].Rows[k][0].ToString();

                            Button btn = new Button();
                            btn.Text = "Подробнее";
                            btn.Width = Unit.Pixel(130);
                            btn.Height = Unit.Pixel(30);
                            btn.CssClass = "button1";
                            btn.BackColor = ColorTranslator.FromHtml("orange");

                            btn.CommandArgument = dataSet1.Tables[0].Rows[k][0].ToString();
                            btn.Click += new EventHandler(btn_Click);

                            panel.Controls.Add(panelchild);
                            panel.Controls.Add(new LiteralControl("<center>"));
                            panel.Controls.Add(label3);
                            panel.Controls.Add(new LiteralControl("</center>"));
                            panel.Controls.Add(new LiteralControl("<center>"));
                            panel.Controls.Add(btn);
                            panel.Controls.Add(new LiteralControl("</center>"));
                            TableCell tempCell = new TableCell();
                            tempCell.Controls.Add(panel);
                            tempRow.Cells.Add(tempCell);
                            k++;
                        }
                    }
                    Table1.Rows.Add(tempRow);
                }
            }
            else
            {
                Panel1.Visible = true;
                Label label2 = new Label();
                label2.Font.Name = "Arial";
                label2.ForeColor = ColorTranslator.FromHtml("black");
                label2.CssClass = "title";
                label2.Text = "Нет мероприятий на заданный день!";
                Panel1.Height = Unit.Pixel(500);
                Panel1.Width = Unit.Pixel(800);
                Panel1.Controls.Add(label2);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();
            string sql= "select name,ageclient,date_part('day', datestart),date_part('month', datestart),date_part('hour', timestart),date_part('minute', timestart) from event order by datestart asc;";
            string sql1 = "select count(*) from event;";
            load(sql, sql1);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string sql = "select name,ageclient,date_part('day', datestart),date_part('month', datestart),date_part('hour', timestart),date_part('minute', timestart) from event where datestart='"+TextBox1.Text+"' order by datestart asc;";
            string sql1 = "select count(*) from event where datestart='" + TextBox1.Text + "';";
            load(sql, sql1);
        }
        protected void btn_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string name = btn.CommandArgument;
            Response.Redirect("~/WebForm2.aspx?name=" + name);

        }
    }
}