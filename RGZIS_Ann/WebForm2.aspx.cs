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
    
    public partial class WebForm2 : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=club;User Id=postgres;Password=765430asd;Pooling=false;");
            connect.Open();
            string name = Request.QueryString["name"];
            com = new NpgsqlCommand("select ageclient, date_part('day', datestart),date_part('month', datestart),date_part('hour', timestart),date_part('minute', timestart) from event where name='"+name+"';", connect);
            dr = com.ExecuteReader();
            dr.Read();
            Label5.Text = name;
            Label1.Text= dr[1].ToString()+" "+getMonth(dr[2].ToString());
            if (dr[4].ToString() == "0")
                Label2.Text = dr[3].ToString() + ":" + dr[4].ToString() + "0";
            else
                Label2.Text = dr[3].ToString() + ":" + dr[4].ToString();
            Label4.Text = dr[0].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = "WebForm3";
            string name = Label5.Text;
            Response.Redirect("~/WebForm3.aspx?name="+name+"&url="+url);
        }
    }
}