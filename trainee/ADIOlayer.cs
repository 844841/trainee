using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace traineedbtask
{
    public class ADIOlayer
    {
        DataSet ds = new DataSet();
        string constr = "";

        public ADIOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }


        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Student";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception Ex)
            {


            }
            return ds;
        }
        public DataSet Insertrecords()
        {
            DataSet dd = new DataSet();
            string sqlquery = "insert into Student values(5,'alex','javascript','11/2/2020') ";

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dd);
                }
            }
            catch (Exception Ex)
            {


            }
            return dd;
        }
        public DataSet GetaStudent(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.CommandText = "PrGetaStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Insertrow(int id, string name, string location,string techdomain, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Tid", id);
                    cmd.Parameters.AddWithValue("@Tname", name);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@Techdomain", techdomain);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "InsertRows";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;

        }
    }
}



    }
}