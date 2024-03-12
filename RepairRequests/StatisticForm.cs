using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class StatisticForm : Form
    {
        private StatisticProvider statisticProvider = new StatisticProvider();

        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            long count = statisticProvider.GetTotalDone();
            long completeTime = statisticProvider.GetCompleteTime();
            List<Statistic> statisticList = statisticProvider.GetStatistics();

            countDone.Text += " " + count;
            if (completeTime == 0)
            {
                completeTime = 1;
            }
            rangeTimeLbl.Text += " " + completeTime + " дней";

            foreach(Statistic statistic in statisticList)
            {
                statisticView.Rows.Add(statistic.Title, statistic.Count);
            }
        }
    }
}
