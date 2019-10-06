using System;
using System.Collections.Generic;
using System.Text;

namespace BoilMyWater
{
    /// <summary>
    /// 简介和基础
    /// </summary>
    public class SynopsisAndFoundation
    {
        /*
        标识符：identifier
        关键字：keyword
        如果需要用保留的关键当标识符需要前面加一个@
        string @class = "";

        ------------ 分割线 ------------

        隐式转换的两个必要条件：
        1、编译器可以保证转换成功
        2、信息不会有损失
        显式转换的条件（任意一个成立）：
        1、编译器不能保证转换成功
        2、信息可能会有损失
        
        ------------ 分割线 ------------

        值类型的赋值：复制该实例
        引用类型的复制：复制引用而不是对象实例（允许多个变量引用同一个对象）
                
        ------------ 分割线 ------------

        数值Literal
        int million = 1_000_000;                                //从C#7开始支持下划线
        var b = 0b1010_1101_1110_1111;                        //支持二进制
        double d = 1.5;                                            //使用小数点 
        double million = 1E06;                                  //指数形式
        编译器推断数值Literal是double还是整数类型：
        1、如果包含小数点或者以指数形式展现，就是double
        2、否则Literal的类型是后面列表中第一个能容纳该数值的类型：int，uint，long，ulong
        数值的后缀：
        float f = 1.0F;//不加F会被默认成double
        double d = 1D;
        decimal d = 1.0M;//不加M会被默认成double
        uint i = 1U;
        long i = 1L;
        ulong i = 1UL;
        注意：
        1、当从浮点型转为整数型时，小数部分是被截断的，没有舍入。
        2、把一个很大的整数隐式转换为浮点类型后，会保证量级不变，但是偶尔会丢失精度。这是因为浮点类型有更多的量级而精度可能不足。
        static void Main()
        {
            int i = 100000001;      //100000001
            float f = i;                 //1E+08
            int i2 = (int)f;             //100000000
        }

        运算符：
        1、除法
        （1）针对整型的除法操作会截断余数；
        （2）除数变量为0，会抛出DivideByZeroException，运行时异常；
        （3）除数Literal为0，编译错误。

        Overflow溢出
        运行时整型的算术操作可能引起溢出，默认情况下不会抛出异常，运算结果类似“环绕”。
        static void Main()
        {
            int i = int.MaxValue;
            i++;
            Console.WriteLine(i==int.MinValue); // True
        }
        Overflow checked操作符
        checked会告诉运行时，如果整型的表达式或语句超出了该类型的极限，那么就会抛出OverflowException。
        checked操作符对++、--、+、-、*、/起作用
        checked可以用于表达式或语句
        checked对于float、double不起作用，因为它们有无限制。
            float min = float.NegativeInfinity;
            double max = double.PositiveInfinity;
        默认开启算数的Overflow检查
        /checked+ 命令行参数
        VS高级设置
        针对某部分代码想关闭Overflow使用unchecked操作符
            int x = int.MaxValue;
            int y = unchecked(x + 1);
            unchecked
            {
                int y1 = x++;
            }
        float和double除以0
        static void Main()
        {
            Console.WriteLine(1.0 / 0.0); //infinity
            Console.WriteLine(-1.0 / 0.0); //infinity
            Console.WriteLine(1.0 / -0.0); //infinity
            Console.WriteLine(-1.0 / -0.0); //infinity

            
             使用==时，NaN不等于任何一个值，包括NaN；
             使用object.Equals()方法时，两个NaN是相等的；
             验证某个值是否为NaN：float.IsNaN(),double.IsNaN()
             
            Console.WriteLine(0.0 / 0.0); //NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); //NaN


            Console.WriteLine((0.0 / 0.0) == double.NaN); //false


            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); //true
        }
        Double  Vs  Decimal
        double基于2适用于科学计算，例如计算坐标
        Decimal基于10 适用于财务计算或者人造数据
                        
        ------------ 分割线 ------------

        & 按位与 1与1为1    1与0为0
        |   按位或 1或1为1    1或0为1 
                                
        ------------ 分割线 ------------
        
        字符串
        @做前缀：不支持转义字符，支持多行字符串
        $做前缀： 可以包含表达式（在{}内） 默认支持单行字符串
        $@一起用
                                        
        ------------ 分割线 ------------
        
        数组
        创建数组时，所有的元素都会被初始化，其值为该类型的默认值
        类型的默认值就是内存按位归零的结果[char 的默认值是'\0']
        矩形数组：代表n维内存块
        使用逗号分割维度 int[3,3]
        GetLength(维度)
        循环方式：
        static void Main()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[i, j] = i * 2 + j;

                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
        交错数组：元素类型为数组的数组
        使用连续的中括号来声明和代表不同维度
        int[][] matrix=new int[3][];
        内层维度没有具体指明，内层数组可以是任意长度
                                       
        ------------ 分割线 ------------
        
        方法参数传递方式：
        1、按值传递argument
        传进方法的时候把参数的值复制一份
        2、按值传递引用类型的argument 
        复制的是引用，而不是对象
        3、按引用传递ref/out
        ref进入函数前被赋值，out离开函数前被赋值
        2.12
        */
        static void Main()
        {

        }
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
