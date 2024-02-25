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

            /* ��Ʒ���顢�ݼ�У׼��������ģ�Ͷ������� */
            InitialPeriodKeyValue initKeyValue = new InitialPeriodKeyValue();
            BaseLinePeriodKeyValue baseLineKeyValue = new BaseLinePeriodKeyValue();
            SensorData sensorData = new SensorData();
            CaculateData caculateData = new CaculateData();

            // ��ʼ��Ӧ�ó���ȫ�ִ洢
            AppData.Data = new Dictionary<string, object>();
            AppData.Data?.Add("InitialPeriodKeyValue", initKeyValue);
            AppData.Data?.Add("BaseLinePeriodKeyValue", baseLineKeyValue);
            AppData.Data?.Add("SensorData", sensorData);
            AppData.Data?.Add("CaculateData", caculateData);

            // ���Դ���: ����DAQLocal���ݲɼ��߳�
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