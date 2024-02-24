using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB20284Local.Models
{
    // 基线阶段(210s - 270s)关键值
    public class BaseLinePeriodKeyValue
    {
        public double BurnerMeanHRR { get; set; }               //燃烧器平均热释放速率
        public double BurnerHRRStandardDeviation { get; set; }  //燃烧器热释放速率标准偏差
        public double BurnerMeanSPR { get; set; }               //燃烧器平均产烟速率
        public double BurnerSPRStandardDeviation { get; set; }  //燃烧器产烟速率标准偏差
        public double MeanO2Concentration { get; set; }         //基准阶段氧气浓度平均值
        public double MeanCO2Concentration { get; set; }        //基准阶段二氧化碳浓度平均值
        public double CO2ProdToO2Depl { get; set; }             //二氧化碳的产生量与氧气的消耗量的比值
        public BaseLinePeriodKeyValue()
        {
            BurnerMeanHRR = 0.0;
            BurnerHRRStandardDeviation = 0.0;
            BurnerMeanSPR = 0.0;
            BurnerSPRStandardDeviation = 0.0;
            MeanO2Concentration = 0.0;
            MeanCO2Concentration = 0.0;
            CO2ProdToO2Depl = 0.0;
        }
    }
}
