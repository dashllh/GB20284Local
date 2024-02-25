using GB20284Local.Forms;
using GB20284Local.Models;
using GB20284Local.DAQLocal;

namespace GB20284Local
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /* 样品试验、梯级校准过程数据模型对象声明 */
            InitialPeriodKeyValue initKeyValue = new InitialPeriodKeyValue();
            BaseLinePeriodKeyValue baseLineKeyValue = new BaseLinePeriodKeyValue();
            SensorData sensorData = new SensorData();
            CaculateData caculateData = new CaculateData();

            // 初始化应用程序全局存储
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("InitialPeriodKeyValue", initKeyValue);
            AppData.Data?.Add("BaseLinePeriodKeyValue", baseLineKeyValue);
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("CaculateData", caculateData);

            // 测试代码: 启动DAQLocal数据采集线程
            var daq = new DAQLocal.DAQLocal();
            daq.StartDAQ();

            Application.Run(new MainForm());
        }
    }

    static class AppData
    {
        public static Dictionary<string, object>? Data { get; set; }
    }
}