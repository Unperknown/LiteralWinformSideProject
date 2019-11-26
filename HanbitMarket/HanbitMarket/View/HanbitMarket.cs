using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HanbitMarket
{
    public partial class HanbitMarket : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataSet dataSet;
        private static string connectionString = "PRIVATE";

        public HanbitMarket()
        {
            InitializeComponent();
        }

        private void HanbitMarket_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            adapter = new MySqlDataAdapter("SELECT * FROM customer", connection);
            dataSet = new DataSet();

            adapter.Fill(dataSet, "customer");
            DatabaseViewSection.DataSource = dataSet.Tables["customer"];
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                foreach (DataGridViewRow row in DatabaseViewSection.SelectedRows)
                {
                    adapter.InsertCommand = new MySqlCommand("insert into customer values(@0, @1, @2, @3, @4, @5)", connection);
                    
                    for (int i = 0; i <= 5; i++)
                    {
                        adapter.InsertCommand.Parameters.AddWithValue("@" + i.ToString(), row.Cells[i].Value.ToString());
                    }
                    adapter.InsertCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    DatabaseViewSection.Refresh();

                    if (adapter.Fill(dataSet, "customer") > 0)
                    {
                        DatabaseViewSection.DataSource = null;
                        DatabaseViewSection.DataSource = dataSet.Tables["customer"];
                    }
                    else
                        MessageBox.Show("정상적으로 삽입되지 않았습니다.");
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

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                DataGridViewSelectedCellCollection cells = DatabaseViewSection.SelectedCells;

                if (cells.Count > 0)
                {
                    foreach (DataGridViewCell cell in cells)
                    {
                        adapter.UpdateCommand = new MySqlCommand(string.Format("update customer set {0}=@UpdatedValue where id=@id", DatabaseViewSection.Columns[cells[0].ColumnIndex].Name), connection);
                        
                        adapter.UpdateCommand.Parameters.AddWithValue("@UpdatedValue", cell.Value);
                        adapter.UpdateCommand.Parameters.AddWithValue("@id", DatabaseViewSection.Rows[cells[0].RowIndex].Cells[0].Value.ToString());
                        
                        adapter.UpdateCommand.ExecuteNonQuery();

                        dataSet.Clear();
                        DatabaseViewSection.Refresh();

                        if (adapter.Fill(dataSet, "customer") > 0)
                        {
                            DatabaseViewSection.DataSource = null;
                            DatabaseViewSection.DataSource = dataSet.Tables["customer"];
                        }
                        else
                            MessageBox.Show("정상적으로 수정되지 않았습니다.");
                    }
                }
                else
                    MessageBox.Show("먼저 수정할 행을 선택해주세요!", "선택 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "내부 오류");
            }
            finally
            {
                connection.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                DataGridViewSelectedRowCollection rows = DatabaseViewSection.SelectedRows;

                if (rows.Count > 0)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        adapter.DeleteCommand = new MySqlCommand("delete from customer where id=@id", connection);
                        adapter.DeleteCommand.Parameters.AddWithValue("@id", row.Cells[0].Value.ToString());

                        adapter.DeleteCommand.ExecuteNonQuery();

                        dataSet.Clear();
                        DatabaseViewSection.Refresh();

                        if (adapter.Fill(dataSet, "customer") > 0)
                            DatabaseViewSection.DataSource = dataSet.Tables["customer"];
                        else
                            MessageBox.Show("정상적으로 삭제되지 않았습니다!", "데이터베이스 오류");
                    }
                }
                else
                {
                    MessageBox.Show("삭제할 행을 먼저 선택해주세요!", "선택 오류");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "내부 오류");
            }
            finally
            {
                connection.Close();
            }
        }

        private void RewriteButton_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            DatabaseViewSection.Refresh();
            adapter.Fill(dataSet, "customer");
            DatabaseViewSection.DataSource = dataSet.Tables["customer"];
        }
    }
}
