using GB20284Local.Models;

namespace GB20284Local.DAQLocal
{
    public class DAQLocal
    {
        private readonly System.Threading.Timer _timer;
        public DAQLocal()
        {
            _timer = new System.Threading.Timer(RefreshSensorData);
        }

        private void RefreshSensorData(object? status)
        {
            Random rnd = new Random();
            double value = rnd.NextDouble();
            var _sensorData = AppData.Data?["SensorData"] as SensorData;
            if (_sensorData != null)
            {
                _sensorData.PropaneGasFlow = value;
                _sensorData.O2Concentration = value;
            }
        }

        public void StartDAQ()
        {
            _timer.Change(0, 1000);
        }

        public void StopDAQ()
        {
            _timer.Change(0, Timeout.Infinite);
        }
    }
}
