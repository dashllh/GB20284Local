
namespace GB20284Local.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新建试验");
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开始计时");
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
