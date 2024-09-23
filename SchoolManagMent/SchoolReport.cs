using SchoolManagMent.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagMent
{
   
    public partial class SchoolReport : Form
    {
        List<SchoolViewModel> _list;

        public SchoolReport(List<SchoolViewModel> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void SchoolReport_Load(object sender, EventArgs e)
        {
            RptSchoolInfo rpt = new RptSchoolInfo();
            rpt.SetDataSource(_list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
