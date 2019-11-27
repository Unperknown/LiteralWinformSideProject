using HanbitMarket.Presenter;
using System;
using System.Data;
using System.Windows.Forms;

namespace HanbitMarket.View
{
    public partial class HanbitMarket : Form, IDatabaseView
    {
        public HanbitMarket()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView { get => DatabaseViewSection; set => DatabaseViewSection = value; }
        public DataSet DataSet { get; set; } = new DataSet();
        public DatabasePresenter Presenter { private get; set; }

        private void HanbitMarket_Load(object sender, EventArgs e)
        {
            Presenter.RefreshDatabaseView();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Presenter.InsertDataToDatabase();
            Presenter.RefreshDatabaseView();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            Presenter.UpdateDataToDatabase();
            Presenter.RefreshDatabaseView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Presenter.DeleteDataToDatabase();
            Presenter.RefreshDatabaseView();
        }

        private void RewriteButton_Click(object sender, EventArgs e)
        {
            Presenter.RefreshDatabaseView();
        }
    }
}
