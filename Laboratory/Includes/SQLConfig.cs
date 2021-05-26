using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace Laboratory.Includes
{
    class SQLConfig
    {
         // Copy and paste the Connection string to here ------------
         //                                                         |
         //                                                         |
         //                                                         |
        private SqlConnection connection = //                       ↓
            new SqlConnection(@"Data Source=.;Initial Catalog=Laboratory;Integrated Security=True");
         //                                                         ↑
         //                                                         |
         //                                                         |
         //----------------------------------------------------------
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        int result;
        public string role = String.Empty;
        public string SERVERNAME = String.Empty;

        public void Execute_CUD(string query, string msg_false, string msg_true)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void GetSingleResult(string query)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = connection;
                cmd.CommandText = query;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                connection.Close();
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void fill_CBO(string sql, ComboBox cbo)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[0].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                connection.Close();
            }

        }
        public void Load_DTG(string query, DataGridView dtg)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = connection;
                cmd.CommandText = query;
                da.SelectCommand = cmd;
                da.Fill(dt);

                dtg.DataSource = dt;
                dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                connection.Close();
            }
        }
        public string GetServerName()
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "exec sp_FindDatabaseOwner";
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        SERVERNAME = (read["_OWNER"].ToString());
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return SERVERNAME;
        }
        public string GetRole(string query)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = query;
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        role = (read["Role"].ToString());
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return role;
        }
        public void GetImage(string query, string id, PictureBox pictureBox, string image_col)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                connection.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                ds = new DataSet();

                cmd.Connection = connection;
                cmd.CommandText = query;
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["" + image_col + ""]);
                    pictureBox.Image = new Bitmap(ms);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
