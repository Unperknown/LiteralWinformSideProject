using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace HanbitMarket.Model
{
    public class RelationRepository : IRelationRepository
    {
        private MySqlConnection _connection;
        private MySqlDataAdapter _adapter;
        private readonly string connectionString = "PRIVATE";

        public string TableName { get; set; }

        private delegate void QueryDelegate(dynamic data);

        public RelationRepository()
        {
            _connection = new MySqlConnection(connectionString);
            _adapter = new MySqlDataAdapter(string.Format("SELECT * FROM {0}", TableName), _connection);
        }

        public void FetchDataSet(DataSet dataSet)
        {
            _adapter.Fill(dataSet, TableName);
        }

        public void InsertData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_insertQuery));
        }

        public void UpdateData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_updateQuery));
        }

        public void DeleteData(IList datas)
        {
            AccessAndProcessQuery(datas, new QueryDelegate(_deleteQuery));
        }

        private void _insertQuery(dynamic data)
        {
            _adapter.InsertCommand = new MySqlCommand(InsertCommand(6), _connection);

            _adapter.InsertCommand.ExecuteNonQuery();
        }

        private void _updateQuery(dynamic data)
        {
            _adapter.UpdateCommand = new MySqlCommand(UpdateCommand("ww", "id"), _connection);
            _adapter.UpdateCommand.ExecuteNonQuery();
        }

        private void _deleteQuery(dynamic data)
        {
            _adapter.DeleteCommand = new MySqlCommand(DeleteCommand("id"), _connection);
            _adapter.DeleteCommand.Parameters.AddWithValue("@primeValue", data.Cells[0].Value.ToString());
            _adapter.DeleteCommand.ExecuteNonQuery();
        }

        private void AccessAndProcessQuery(dynamic datas, QueryDelegate queryDelegate)
        {
            try
            {
                _connection.Open();

                foreach (var data in datas)
                {
                    queryDelegate(data);
                }
            }
            catch (MySqlException databaseEx)
            {
                MessageBox.Show(databaseEx.Message, "데이터베이스 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "기타 오류");
            }
            finally
            {
                _connection.Close();
            }
        }

        private string InsertCommand(int lengthOfColumns)
        {
            return string.Format("insert into {0} values()", TableName);
        }
        private string UpdateCommand(string updatedColumn, string primeColumn)
        {
            return string.Format("update {0} set {1}=@updatedValue where {2}=@primeValue", TableName, updatedColumn, primeColumn);
        }
        private string DeleteCommand(string primeColumn)
        {
            return string.Format("delete from {0} where {1}=@primeValue", TableName, primeColumn);
        }
    }
}
