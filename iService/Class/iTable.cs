using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace iService.Class
{
    public class iTable
    {
        public int TableID { get; set; }
        public string TableName { get; set; }
        public int TableType { get; set; }
        public string PicturePath { get; set; }
        public Image Picture {  get; set; }
        public int Position { get; set; }

        public List<iTable> getAllTable()
        {
            List<iTable> listTable = new List<iTable>();
            try
            {
                string sql = "select * from iTable";
                DatabaseConnection con = new DatabaseConnection();
                DataTable data = con.getSQLDataReader(sql);
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        iTable temp = new iTable();
                        temp.TableID = Convert.ToInt16(row["TableID"]);
                        temp.TableType = Convert.ToInt16(row["TableType"]);
                        temp.TableName = row["TableName"].ToString();
                        temp.PicturePath = row["PicturePath"].ToString();
                        string imgPath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, temp.PicturePath);
                        var img = Image.FromFile(imgPath);
                        temp.Picture = new Bitmap(img, new Size(351, 234));
                        temp.Position = Convert.ToInt16(row["Position"]);
                        listTable.Add(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listTable;
        }
    }
}
