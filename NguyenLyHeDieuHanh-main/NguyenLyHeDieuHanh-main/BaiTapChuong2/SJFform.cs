using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapChuong2
{
    public partial class SJFform : Form
    {
        public static int n = 0;
        private static List<Process> processList = new List<Process>(); 
        public SJFform()
        {
            InitializeComponent();
        }
        private void resettextbox()
        {
            textBoxProcessID.Clear();
            textBoxArrivalTime.Clear();
            textBoxBurstTime.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n += 1;
                string id = textBoxProcessID.Text;
                double arrival_time = double.Parse(textBoxArrivalTime.Text);
                double burst_time = double.Parse(textBoxBurstTime.Text);
                Process process = new Process(id,arrival_time,burst_time);
                processList.Add(process);
                lbNumOfProcess.Text = "Number of processes: " + n.ToString();
                dataGridViewStart.Rows.Add(process.ID, process.TA, process.TCPU);
                resettextbox();
                SortListByTA();
                SortListByTCPU();
                TimeSystemAndWaiting();
                AverageWaitingTime();
                textBoxProcessID.Focus();
                //MessageBox.Show("Thêm process thành công.");
            }
            catch 
            {
                MessageBox.Show("Kiểm tra lại dữ liệu đầu vào!!!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /*DialogResult = MessageBox.Show("Reset sẽ đặt lại toàn bộ dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {*/
                try
                {
                    dataGridViewStart.Rows.Clear();
                    dataGridViewSortByArrivalTime.Rows.Clear();
                    dataGridViewSortByBurstTime.Rows.Clear();
                    dataGridViewSFJ.Rows.Clear();
                    n = 0;
                    resettextbox();
                    lbNumOfProcess.Text = "Number of processes: 0";
                    labelResult.Text = "Average waiting time =";
                    processList.Clear();
                    MessageBox.Show("Reset thành công.");
                }
                catch
                { }
            //}
            
        }

        //Sắp xếp theo thời gian bắt đầu
        private void SortListByTA()
        {
            processList = processList.OrderBy(p => p.TA).ToList(); // Sắp xếp theo Time Arrival
            UpdateDataGridViewSortByArrivalTime();
        }
        private void UpdateDataGridViewSortByArrivalTime()
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridViewSortByArrivalTime.Rows.Clear();

            // Hiển thị danh sách đã sắp xếp trong DataGridView
            foreach (var process in processList)
            {
                dataGridViewSortByArrivalTime.Rows.Add(process.ID, process.TA, process.TCPU);
            }
        }

        //Sắp xếp theo thời gian sử dụng cpu
        private void SortListByTCPU()
        {
            if (processList.Count > 1)
            {
                processList = processList
                    .Take(1) // Lấy đối tượng thứ nhất
                    .Concat(processList.Skip(1).OrderBy(p => p.TCPU)) // Sắp xếp từ đối tượng thứ hai trở đi
                    .ToList();
                UpdateDataGridViewSortByBurstTime();
            }
            else
            {
                UpdateDataGridViewSortByBurstTime();
            }
            
        }
        private void UpdateDataGridViewSortByBurstTime()
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridViewSortByBurstTime.Rows.Clear();

            // Hiển thị danh sách đã sắp xếp trong DataGridView
            foreach (var process in processList)
            {
                dataGridViewSortByBurstTime.Rows.Add(process.ID, process.TA, process.TCPU);
            }
        }

        //Tính toán thời gian lưu hệ thống và thời gian chờ
        private void TimeSystemAndWaiting()
        {
            for (int i = 0; i < processList.Count; i++)
            {

                double x = 0, _TimeHT, _WTime; // x: thoi gian Process[i] trong he thong 
                x += processList[0].TA;
                for (int j = 0; j <= i; j++)
                {
                    x = x + processList[j].TCPU;
                }

                _TimeHT = x - processList[i].TA;
                processList[i].TS = _TimeHT;

                _WTime = _TimeHT - processList[i].TCPU;
                processList[i].TW = _WTime;

            }
            UpdateDataGridViewSFJ();
        }
        private void UpdateDataGridViewSFJ()
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridViewSFJ.Rows.Clear();

            // Hiển thị danh sách đã sắp xếp trong DataGridView
            foreach (var process in processList)
            {
                dataGridViewSFJ.Rows.Add(process.ID, process.TS, process.TW);
            }
        }
        private void AverageWaitingTime()
        {
            double average = 0;
            for (int i = 0; i < processList.Count; i++)
            {
                average += processList[i].TW ;
            }
            labelResult.Text = "Average waiting time = " + average.ToString() + "/" + processList.Count.ToString() + " = " + average/processList.Count;
        }

        private void dataGridViewSortByArrivalTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }


}

