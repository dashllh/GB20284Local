using Core;
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
                chartHRR.BeginInvoke(new Action(() =>
                {
                    chartHRR.Series[0].Points.AddXY(model.Counter, 120);
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
