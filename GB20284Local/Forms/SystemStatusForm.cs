using GB20284Local.Forms;

namespace GB20284Local.Forms
{
    public partial class SystemStatusForm : Form
    {
        public SystemStatusForm()
        {
            InitializeComponent();
        }

        private void SystemStatusForm_Load(object sender, EventArgs e)
        {
            // 将当前Form对象UI上下文添加进全局存储
            //SynchronizationContext? uiContext = SynchronizationContext.Current;
            //if (uiContext != null)
            //{
            //    AppData.Data?.Add("UIContext", uiContext);
            //}
            // 数据绑定
            lblGasFlow.DataBindings.Add("Text", AppData.Data?["SensorData"], "PropaneGasFlow");
            lblO2Concentration.DataBindings.Add("Text", AppData.Data?["SensorData"], "O2Concentration");
        }
    }
}
