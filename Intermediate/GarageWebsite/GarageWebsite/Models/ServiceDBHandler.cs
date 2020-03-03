using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GarageWebsite.Models
{  
    public class ServiceDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["CamTowConString"].ToString();
            con = new SqlConnection(constring);
        }
		public List<ItemList> GetItemList()
		{
			connection();
			List<ItemList> iList = new List<ItemList>();

			string query = "SELECT * FROM Services ORDER BY Price";
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			con.Open();
			adapter.Fill(dt);
			con.Close();

			foreach (DataRow dr in dt.Rows)
			{
				iList.Add(new ItemList
				{
					ID = Convert.ToInt32(dr["ID"]),
					Service = Convert.ToString(dr["Service"]),
					Category = Convert.ToString(dr["Category"]),
					Price = Convert.ToDecimal(dr["Price"]),
					Description = Convert.ToString(dr["Description"])
				});
			}
			return iList;
		}
	}
}