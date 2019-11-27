using System.Data;
using System.Windows.Forms;

namespace HanbitMarket.View
{
    public interface IDatabaseView
    {
        DataGridView DataGridView { get; set; }
        DataSet DataSet { get; set; }
        Presenter.DatabasePresenter Presenter { set; }
    }
}
