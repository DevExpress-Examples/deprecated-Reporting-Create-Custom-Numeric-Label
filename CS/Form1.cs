using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace Reporting_Create_Custom_Numeric_Label {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ReportDesignTool designTool = new ReportDesignTool(new XtraReport1());
            designTool.ShowDesigner();
        }
    }
}
