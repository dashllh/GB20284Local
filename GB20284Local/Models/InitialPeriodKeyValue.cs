using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB20284Local.Models
{
    // 初始阶段(30s - 90s)关键值
    public class InitialPeriodKeyValue
    {
        public double MeanDuctTemperature { get; set; }  //管道平均温度(管道内三个热电偶的温度平均值)
        public double MeanO2Concentration { get; set; }  //平均氧气浓度
        public double MeanCO2Concentration { get; set; } //平均二氧化碳浓度
        public double MeanLightTransmission { get; set; }//平均光通量
        public double O2AmbientTemperature { get; set; } //氧气环境浓度

        public InitialPeriodKeyValue()
        {
            MeanDuctTemperature = 0.0;
            MeanO2Concentration = 0.0;
            MeanCO2Concentration = 0.0;
            MeanLightTransmission = 0.0;
            O2AmbientTemperature = 0.0;
        }
    }
}
