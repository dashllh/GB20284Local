using Core;
using GB20284Local.Models;
using GB20284Local.ViewModels;

namespace GB20284Local.Forms
{
    public partial class TestForm : Form
    {
        private readonly TestDataRecorder _testDataRecorder;
        public TestForm()
        {
            InitializeComponent();
            _testDataRecorder = new TestDataRecorder();
            _testDataRecorder.BindView(this);
        }

        public void UpdateDisplay(TestViewModel model)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    lblCounter.Text = model.Counter.ToString();
                    chartHRR.Series[0].Points.AddXY(model.Counter, model.SensorData.O2Concentration);
                    chartHRR.Series[1].Points.AddXY(model.Counter, model.CaculateData.Figra);
                    // 5分钟后开始平移曲线图坐标轴
                    if (model.Counter > 300)
                    {
                        chartHRR.Series[0].Points.RemoveAt(0);
                        chartHRR.Series[1].Points.RemoveAt(0);
                        chartHRR.ChartAreas[0].AxisX.Minimum = model.Counter - 300;
                        chartHRR.ChartAreas[0].AxisX.Maximum = model.Counter;
                    }
                    // 添加传感器数据                    
                    ListViewItem item = new ListViewItem(model.Counter.ToString());
                    item.SubItems.Add(model.SensorData.PropaneGasFlow.ToString());
                    item.SubItems.Add(model.SensorData.DuctPressureDelta.ToString());
                    item.SubItems.Add(model.SensorData.LightTransmission.ToString());
                    item.SubItems.Add(model.SensorData.O2Concentration.ToString());
                    item.SubItems.Add(model.SensorData.CO2Concentration.ToString());
                    item.SubItems.Add(model.SensorData.COConcentration.ToString());
                    item.SubItems.Add(model.SensorData.DuctTemperature1.ToString());
                    item.SubItems.Add(model.SensorData.DuctTemperature2.ToString());
                    item.SubItems.Add(model.SensorData.DuctTemperature3.ToString());
                    item.SubItems.Add(model.SensorData.AmbientPressure.ToString());
                    lvSensorData.Items.Insert(0, item);
                }));
            }
            catch (InvalidOperationException)
            {

            }
        }

        public void ResetDisplay()
        {

        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新建试验");
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            _testDataRecorder.Start();
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("停止计时");
        }

        private void btnRecordPhenomeno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("试验记录");
        }
    }
}
