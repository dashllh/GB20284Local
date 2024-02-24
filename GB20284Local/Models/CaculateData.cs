
namespace GB20284Local.Models
{
    public class CaculateData : ObservableObject
    {
        //Qgas当前计算值
        private double _qGas;
        public double QGas
        {
            get { return _qGas; }
            set
            {
                if (value != this._qGas)
                {
                    this._qGas = value;
                    NotifyPropertyChange();
                }
            }
        }
        //V298
        private double _v298;
        public double V298
        {
            get { return _v298; }
            set
            {
                if (value != this._v298)
                {
                    this._v298 = value;
                    NotifyPropertyChange();
                }
            }
        }
        //HRR当前计算值
        private double _hrr;
        public double HRR
        {
            get { return _hrr; }
            set
            {
                if (value != this._hrr)
                {
                    this._hrr = value;
                    NotifyPropertyChange();
                }
            }
        }
        //SPR当前计算值
        private double _spr;
        public double SPR
        {
            get { return _spr; }
            set
            {
                if (value != this._spr)
                {
                    this._spr = value;
                    NotifyPropertyChange();
                }
            }
        }
        //Figra当前计算值
        private double _figra;
        public double Figra
        {
            get { return _figra; }
            set
            {
                if (value != this._figra)
                {
                    this._figra = value;
                    NotifyPropertyChange();
                }
            }
        }
        //Smogra当前计算值
        private double _smogra;
        public double Smogra
        {
            get { return _smogra; }
            set
            {
                if (value != this._smogra)
                {
                    this._smogra = value;
                    NotifyPropertyChange();
                }
            }
        }
        public CaculateData()
        {
            _qGas = 0.0;
            _v298 = 0.0;
            _hrr = 0.0;
            _spr = 0.0;
            _figra = 0.0;
            _smogra = 0.0;
        }
    }
}
