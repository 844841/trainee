using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace trainee
{
    public partial class WebFormUpdateData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        public DataSet UpdateTrainee(int id, string name,string location,string techdomain,string date)
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
                    cmd.CommandText = "Update";
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
       
    }
}





       
   

        
  