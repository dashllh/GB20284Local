
namespace GB20284Local.Models
{
    public class SensorData : ObservableObject
    {
        //丙烷流量
        private double _propaneGasFlow;
        public double PropaneGasFlow
        {
            get { return _propaneGasFlow; }
            set
            {
                if (value != this._propaneGasFlow)
                {
                    this._propaneGasFlow = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //管道压差
        private double _ductPressureDelta;
        public double DuctPressureDelta
        {
            get { return _ductPressureDelta; }
            set
            {
                if (value != this._ductPressureDelta)
                {
                    this._ductPressureDelta = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //光通过率
        private double _lightTransmission;
        public double LightTransmission
        {
            get { return _lightTransmission; }
            set
            {
                if (value != this._lightTransmission)
                {
                    this._lightTransmission = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //氧气浓度
        private double _o2Concentration;
        public double O2Concentration
        {
            get { return _o2Concentration; }
            set
            {
                if (value != this._o2Concentration)
                {
                    this._o2Concentration = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //二氧化碳浓度
        private double _co2Concentration;
        public double CO2Concentration
        {
            get { return _co2Concentration; }
            set
            {
                if (value != this._co2Concentration)
                {
                    this._co2Concentration = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //一氧化碳浓度
        private double _coConcentration;
        public double COConcentration
        {
            get { return _coConcentration; }
            set
            {
                if (value != this._coConcentration)
                {
                    this._coConcentration = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //环境压力
        private double _ambientPressure;
        public double AmbientPressure
        {
            get { return _ambientPressure; }
            set
            {
                if (value != this._ambientPressure)
                {
                    this._ambientPressure = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //环境温度
        private double _ambientTemperature;
        public double AmbientTemperature
        {
            get { return _ambientTemperature; }
            set
            {
                if (value != this._ambientTemperature)
                {
                    this._ambientTemperature = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //管道温度1
        private double _ductTemperature1;
        public double DuctTemperature1
        {
            get { return _ductTemperature1; }
            set
            {
                if (value != this._ductTemperature1)
                {
                    this._ductTemperature1 = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //管道温度2
        private double _ductTemperature2;
        public double DuctTemperature2
        {
            get { return _ductTemperature2; }
            set
            {
                if (value != this._ductTemperature2)
                {
                    this._ductTemperature2 = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //管道温度3
        private double _ductTemperature3;
        public double DuctTemperature3
        {
            get { return _ductTemperature3; }
            set
            {
                if (value != this._ductTemperature3)
                {
                    this._ductTemperature3 = value;
                    //NotifyPropertyChange();
                }
            }
        }
        //冷阱温度
        private double _gasCoolPipeTemperature;
        public double GasCoolPipeTemperature
        {
            get { return _gasCoolPipeTemperature; }
            set
            {
                if (value != this._gasCoolPipeTemperature)
                {
                    this._gasCoolPipeTemperature = value;
                    //NotifyPropertyChange();
                }
            }
        }
        public SensorData()
        {
            _propaneGasFlow = 0.0;
            _ductPressureDelta = 0.0;
            _lightTransmission = 0.0;
            _o2Concentration = 0.0;
            _co2Concentration = 0.0;
            _coConcentration = 0.0;
            _ambientPressure = 0.0;
            _ambientTemperature = 0.0;
            _ductTemperature1 = 0.0;
            _ductTemperature2 = 0.0;
            _ductTemperature3 = 0.0;
            _gasCoolPipeTemperature = 0.0;
        }
    }
}
