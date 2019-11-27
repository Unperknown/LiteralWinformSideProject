using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanbitMarket
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new Model.CustomerRelationRepository();
            var view = new View.HanbitMarket();
            
            var presenter = new Presenter.DatabasePresenter(view, repository);

            Application.Run(view);
        }
    }
}
