using GB20284Local.Models;

namespace GB20284Local.ViewModels
{
    public class TestViewModel
    {
        public int Counter { get; set; }
        public SensorData SensorData { get; set; }
        public CaculateData CaculateData { get; set; }
        public BaseLinePeriodKeyValue BaseLinePeriodKeyValue { get; set; }

        public TestViewModel()
        {
            Counter = 0;
            SensorData = new SensorData();
            CaculateData = new CaculateData();
            BaseLinePeriodKeyValue = new BaseLinePeriodKeyValue();
        }
    }
}
