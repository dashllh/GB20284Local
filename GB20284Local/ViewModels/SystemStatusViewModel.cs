using GB20284Local.Models;

namespace GB20284Local.ViewModels
{
    public class SystemStatusViewModel
    {
        public SensorData SensorData { get; set; }
        public CaculateData CaculateData { get; set; }

        public SystemStatusViewModel()
        {
            SensorData = new SensorData();
            CaculateData = new CaculateData();
        }
    }
}
