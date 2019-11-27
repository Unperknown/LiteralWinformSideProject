using System.Collections;
using System.Data;

namespace HanbitMarket.Model
{
    public interface IRelationRepository
    {
        string TableName { get; set; }
        void FetchDataSet(DataSet dataSet);
        void InsertData(IList datas);
        void UpdateData(IList datas);
        void DeleteData(IList datas);
    }
}
