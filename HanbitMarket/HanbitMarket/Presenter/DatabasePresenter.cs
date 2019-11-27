using HanbitMarket.Model;
using HanbitMarket.View;

namespace HanbitMarket.Presenter
{
    public class DatabasePresenter
    {
        private readonly IDatabaseView _view;
        private readonly IRelationRepository _repository;

        public DatabasePresenter(IDatabaseView view, IRelationRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;
            _repository.TableName = "customer";
        }

        public void RefreshDatabaseView()
        {
            _view.DataSet.Clear();
            _view.DataGridView.Refresh();
            _repository.FetchDataSet(_view.DataSet);
            _view.DataGridView.DataSource = _view.DataSet.Tables[_repository.TableName];
        }

        public void InsertDataToDatabase()
        {
            _repository.InsertData(_view.DataGridView.SelectedRows);
        }

        public void UpdateDataToDatabase()
        {
            _repository.UpdateData(_view.DataGridView.SelectedCells);
        }

        public void DeleteDataToDatabase()
        {
            _repository.DeleteData(_view.DataGridView.SelectedRows);
        }
    }
}
