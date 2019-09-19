using System;
using System.Collections.Generic;
using System.Text;

namespace BoilMyWater._1_2.简介和基础
{
    /// <summary>
    /// 简介和基础
    /// </summary>
    public class SynopsisAndFoundation
    {
        //标识符：identifier
        //关键字：keyword
        //如果需要用保留的关键当标识符需要前面加一个@
        string @class = "";

    }
    /// <summary>
    /// 自定义类型
    /// </summary>
    public class UnitConverter
    {
        int ratio;// Field 字段
        public UnitConverter(int unitRatio)//Constructor 构造函数
        {
            ratio = unitRatio;
        }
        public int Convert(int unit)// Method 方法
        {
            return unit * ratio;
        }
    }
}
