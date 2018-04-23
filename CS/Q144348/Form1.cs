using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.PivotGrid;

namespace Q144348 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

        }

        private void chartControl1_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
            SeriesPoint point = e.AdditionalObject as SeriesPoint;

            if (point != null) {
                PivotChartDataSourceRowItem coord = point.Tag as PivotChartDataSourceRowItem;

                ChartControl chart = (ChartControl)sender;
                PivotGridControl pivot = (PivotGridControl)chart.DataSource;
                PivotCellEventArgs info = pivot.Cells.GetCellInfo(coord.CellX , coord.CellY );
                PivotSummaryDataSource source = info.CreateSummaryDataSource();
                string s = string.Empty;
                for (int i = 0; i < source.RowCount; i++)
                    s += "Country = " + source.GetValue(i, 0).ToString() +
                        "\r\tYear = " + source.GetValue(i, 1).ToString() +
                        "\r\tExtended Price = " + source.GetValue(i, 2).ToString() + "\r\n";
                toolTipController1.ShowHint(s);
            } else
                toolTipController1.HideHint();
        }
    }
}