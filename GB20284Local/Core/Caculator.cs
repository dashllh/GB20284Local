
namespace Core
{
    public class Caculator
    {
        /* 
         * 功能: 计算标准环境(标准大气压,25℃)下管道内气体的体积流量 
         * 参数: ductdiam - 排烟管道直径,单位:M
		 *       Kt       - Kt系数
		 *       Kp       - 雷诺校正系数
		 *       deltap   - 排烟管道压差(单位:Pa)
		 *       Ts       - 排烟管道温度(单位:K)
         * 返回:
		 *       double   - V298
         */
        public static double CaculateV298(double ductdiam, double Kt, double Kp, double deltap, double Ts)
        {
            return 22.4 * (((Math.PI * (ductdiam / 2) * (ductdiam / 2)) * Kt) / Kp) * Math.Sqrt(deltap / Ts);
        }

        /* 
         * 功能: 计算点火源气体热释放功率 
         * 参数: vgas    - 燃气质量流速(g/s)
		 *       gastype - 燃气类型
         *  返回:
		 *       double  - 燃气热功率       
         */
        public static double CaculateQgas(double vgas)
        {
            return vgas * 46.4;  //46.4 为丙烷在标准条件下的燃烧热值,单位为: KJ/g
        }

        /* 
         * 功能: 计算耗氧系数(Oxygen Depletion Factor) 
         * 参数: O2zero  - 氧气初始浓度(单位:%)
         *       CO2zero - 二氧化碳初始浓度(单位:%)
		 *       O2real  - 氧气实时浓度(单位:%)
		 *       CO2real - 二氧化碳实时浓度(单位:%)
         *  返回:
		 *       double  - 耗氧系数
         */
        public static double CaculateODF(double O2zero, double CO2zero, double O2real, double CO2real)
        {
            return (O2zero * (1 - CO2real) - O2real * (1 - CO2zero)) / (O2zero * (1 - CO2real - O2real));
        }

        /* 
         * 功能: 计算氧气环境浓度(含水蒸气的氧气环境摩尔分数) 
         * 参数: O2zero   - 氧气初始浓度(单位:%)
         *       ambhumi  - 环境相对湿度(单位:%)
		 *       ambpress - 环境压力(单位:帕)
		 *       Tamb     - 初始阶段排烟管道温度(30s-90s)(单位:K)
         * 返回:
		 *       double   - 氧气环境浓度(单位:%)
         */
        public static double CaculateO2AmbConcen(double O2zero, double ambhumi, double ambpress, double Tamb)
        {
            return O2zero * (1 - (ambhumi / (100 * ambpress)) * Math.Exp(23.2 - (3816 / (Tamb - 46))));
        }

        /* 
         * 功能:计算燃烧器和样品的总热释放速率(热功率) 
         * 参数: E1(17200)   - 25℃环境下单位体积样品的热释放量(单位:kJ/m3)
		 *       V298        - 标准环境下的排烟管道体积流速(单位:m3/s)
		 *       O2AmbConcen - 氧气环境浓度(单位:%)
		 *       odf         - 耗氧系数
         * 返回:
		 *       double      - 样品与燃烧器的总热释放速率(单位:kW)
         */
        public static double CaculateHRRTotal(double V298, double O2AmbConcen, double odf)
        {
            return 17200 * V298 * O2AmbConcen * (odf / ((0.105 * odf) + 1));
        }

        /* 
         * 功能:计算样品热释放速率(热功率) 
         * 参数: 
		 *       HRRT - 样品与燃烧器的总热释放速率(单位:kW)
		 *       Qgas - 燃烧器热释放速率(单位:kW)
         * 返回:
		 *       double - 样品与燃烧器的总热释放速率(单位:kW)
         */
        public static double CaculateHRRProd(double HRRT, double Qgas)
        {
            return HRRT - (17200 / 16800) * Qgas;
        }

        /* 
         * 功能:计算光通量系数(k) 
         * 参数:
		 *       L  - 排烟管道直径(单位:m)
		 *       I0 - 初始光信号测量值(单位:%)
		 *       I  - 实时光信号测量值(单位:%)
         * 返回:
		 *       double - 光通量系数(k)
         */
        public static double CaculateLightK(double L, double I0, double I)
        {
            return Math.Log(I0 / I) / L;
        }

        /* 
         * 功能:计算产烟速率(SPR) 
         * 参数:
		 *       k  - 光通量系数
		 *       Vs - 指定温度条件下排烟管道内气体的总体积流速(单位:m3/s)
         * 返回:
		 *       double - 产烟速率(单位:m2/s)
         */
        public static double CaculateSPR(double k, double Vs)
        {
            return k * Vs;
        }
    }
}
