using GB20284Local.Forms;
using GB20284Local.Models;
using GB20284Local.ViewModels;

namespace GB20284Local.Forms
{
    public partial class SystemStatusForm : Form
    {
        private readonly System.Threading.Timer _timer;

        private SystemStatusViewModel _systemStatusViewModel;
        public SystemStatusForm()
        {
            InitializeComponent();
            _systemStatusViewModel = new SystemStatusViewModel();
            _timer = new System.Threading.Timer(UpdateRealTimeValue);
        }

        private void UpdateRealTimeValue(object? status)
        {
            var sensorData = AppData.Data?["SensorData"] as SensorData;
            if (sensorData != null)
            {
                _systemStatusViewModel.SensorData.PropaneGasFlow = sensorData.PropaneGasFlow;
                _systemStatusViewModel.SensorData.O2Concentration = sensorData.O2Concentration;
                try
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        lblGasFlow.Text = _systemStatusViewModel.SensorData.PropaneGasFlow.ToString();
                        lblO2Concentration.Text = _systemStatusViewModel.SensorData.O2Concentration.ToString();
                    }));
                }
                catch (ObjectDisposedException e)
                {
                    //...
                }                
            }
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
            //lblGasFlow.DataBindings.Add("Text", AppData.Data?["SensorData"], "PropaneGasFlow");
            //lblO2Concentration.DataBindings.Add("Text", AppData.Data?["SensorData"], "O2Concentration");
            _timer.Change(0, 1000);
        }

        private void SystemStatusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timer.Change(0, Timeout.Infinite);
        }
    }
}
