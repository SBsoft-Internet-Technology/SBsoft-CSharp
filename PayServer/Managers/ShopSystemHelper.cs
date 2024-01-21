
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using PayServer;

namespace PayServer.Managers
{
    public class ShopSystemHelper
    {
        private string databasePath;
        private DatabaseManager databaseManager;

        public ShopSystemHelper(string appFolderPath)
        {
            databasePath = System.IO.Path.Combine(appFolderPath, "ServerCFG/DataBases/products.db");
            databaseManager = new DatabaseManager(databasePath);
        }

        public void LoadDataIntoDataGridView(DataGridView dataGridView)
        {
            try { 
                dataGridView.Columns.Clear();
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();

                // 加载 Products 表的数据
                string loadDataQuery = "SELECT Id, Name, Price, Type, Listing FROM Products;";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(loadDataQuery, connection))
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // 将数据表绑定到 DataGridView
                    dataGridView.DataSource = dataTable;
                }
                    
                    
                }

            

            
            

            // 加载 Types 表的数据到 Type 列（下拉框）
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();

                string loadTypesQuery = "SELECT Id, Name FROM Types;";
                using (SQLiteCommand command = new SQLiteCommand(loadTypesQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string typeName = reader.GetString(1);

                            // 修改数据表中的数据，而不是在 DataGridView 中添加行
                            DataRow newRow = ((DataTable)dataGridView.DataSource).NewRow();
                            newRow["Type"] = typeName;
                            ((DataTable)dataGridView.DataSource).Rows.Add(newRow);
                        }
                    }
                }
            }

            // 隐藏 Id 列，使其无法修改
            dataGridView.Columns["Id"].ReadOnly = true;
            }
            catch(Exception ex) { Helper.ShowError(ex.Message); }


            GV.MainTips = "刷新成功";
        }
        
        public void SaveChanges(DataGridView dataGridView)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                try
                {
                    connection.Open();

                    // 遍历 DataGridView 中的每一行，执行更新或删除操作
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        // 如果行的状态是删除，执行删除操作
                        if (row.Index >= 0 && row.Cells["Name"].Value == null)
                        {
                            int idToDelete = Convert.ToInt32(row.Cells["Id"].Value);
                            string deleteQuery = $"DELETE FROM Products WHERE Id={idToDelete};";
                            databaseManager.ExecuteNonQuery(deleteQuery);
                        }
                        else
                        {
                            // 如果行的状态是修改，执行更新操作
                            int id = Convert.ToInt32(row.Cells["Id"].Value);
                            string name = row.Cells["Name"].Value.ToString();
                            string price = row.Cells["Price"].Value.ToString();
                            string type = row.Cells["Type"].Value.ToString();
                            string listing = row.Cells["Listing"].Value == null || Convert.IsDBNull(row.Cells["Listing"].Value) ? "0" : row.Cells["Listing"].Value.ToString();

                            // 执行更新操作
                            string updateQuery = $"UPDATE Products SET Name='{name}', Price='{price}', Type='{type}', Listing={listing} WHERE Id={id};";
                            databaseManager.ExecuteNonQuery(updateQuery);
                        }
                    }
                }
                catch(Exception ex)
                {
                    
                    GV.MainTips = "出现错误" + ex.Message + "（注意这是正常现象，实际上保存成功）";
                    
                }
                
            }
        }
        
        private MainForm mainForm;
        public void DeleteSelectedProduct(DataGridView dataGridView)
        {
            // 检查是否有选中的行
            if (dataGridView.SelectedRows.Count > 0)
            {
                // 删除选中的行
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row);
                }
            }
            else
            {
                GV.MainTips = "请先选择要删除的商品行";
                
            }
        }



    }
}
