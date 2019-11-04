# Event 事件
#### 广播和订阅
* 使用委托的时候通常出现两个角色，一个广播者，一个订阅者
* 广播者这个类型包含一个委托字段，广播者通过调用委托来决定什么时候进行广播
* 订阅者是方法目标的接收者，订阅者可以决定何时开始或者结束监听，方式是通过在委托商调用+=和-=
* 一个订阅者不知道和不干扰其他的订阅者
#### Event 事件
* 事件就是将上述模式正式化的一个语言特性。
* 事件是一种结构，为了实现广播者/订阅者模型，它只暴露了所需委托特性的部分子集
* 事件的主要目的就是防止订阅者之间互相干扰
```
// Delegate definition
public delegate void PriceChangedHandler (decimal oldPrice,decimal newPrice);

public class BroadCaster
{
    //Event  declaration
    public event PriceChangedHandler PriceChanged;
}
```
* BroadCaster类型里面的代码拥有对PriceChanged的完全访问权，在这里就可以把它当成委托
* 而BroadCaster类型之外的代码只能对PriceChanged这个event执行+=或者-=操作
#### 标准的事件模式
* 为编写事件，.net定义了一个标准的模式。
* System.EventArgs，一个预定义的框架类，除了静态的Empty属性之外没有其他成员。
* EventArgs是为事件传递信息的类的基类。
#### 为事件选择或定义委托
* 返回类型是void；
* 接收两个参数，第一个参数类型是object，第二个参数类型是EventArgs的子类。第一个参数表示事件的广播者，第二个参数包含需要传递的信息。
* 名称必须以EventHandler结尾。
* Framework定义了一个泛型委托System.EventHandler\<T>，它满足上述规则
```
public delegate void EventHandler<TEventArgs>(object source,TEventArgs e) where TEventArgs:EventArgs
```
#### 可触发事件的protected virtual方法
* 方法名必须和事件一致，前面这加上On，接收一个EventArgs参数
```
public class Stock
{
    ~~~
    public event EventHandler<PriceChangedEventArgs> PriceChanged;
    Protected virtual OnPriceChanged(PriceChangedEventArgs e)
    {
        if(PriceChanged != null) PriceChanged(this,e);
    }

}
```