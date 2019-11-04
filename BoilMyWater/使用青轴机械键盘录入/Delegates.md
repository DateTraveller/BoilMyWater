# Delegates 委托
* 委托是一个对象，它知道如何调用一个方法。
* 委托类型定义了委托实例可以调用的那类方法，即委托类型定义了方法的返回类型和参数。
```
delegate int del(int x); //委托类型
``` 
* 把方法复制给委托变量的时候就创建了委托实例
```
del d = Square;
``` 
* 调用
```
int answer = t(3); // answer is 9
``` 
#### 多播委托
* 使用+和+=操作符可以合并委托实例
* 委托的调用顺序与它们的定义顺序一致
* -和-=会把右边的委托从左边的委托里移除
* 委托是不可变的，使用+=或者-=操作符时实际上是创建了新的委托实例，并把它赋给当前的委托变量
* C#会把作用于委托的+、-、+=、-=操作编译成使用System.Delegate的Combine和Remove两个静态方法
#### 实例方法目标和静态方法目标
* 当一个实例方法被赋值给委托对象的时候，这个委托对象不仅要保留着对方法的引用，还要保留着方法所属实例的引用
* System.Delegate的Target属性就代表这个实例
* 如果引用的是静态方法，那么Target属性的值为null
#### Func和Action委托
* 使用泛型委托可以写出这样一组委托类型，它们可以调用的方法可以拥有任意的返回类型和任意（合理）数量的参数
```
delegate TResult Func<out TResult>                      ();
delegate TResult Func<in T, out TResult>                (T arg);
delegate TResult Func<in T1, in T2, out TResult>        (T1 arg1 , T2 arg2);
...up to T16

delegate void Action                                    ();
delegate void Action<in T>                              (T arg);
delegate void Action<in T1, in T2>                      (T1 arg1, T2 arg2);
...up to T16
```
#### 委托VS接口
* 委托可以解决的问题，接口都可以解决。
* 什么情况下更适合用委托而不是接口呢？当下列条件之一满足时：
  * 接口只能定义一个方法
  * 需要多播能力
  * 订阅者需要多次实现接口
#### 委托的兼容性 - 委托类型
* 委托类型之间互不兼容，即使方法签名一样：
```
delegate void D1();
delegate void D1();
D1 d1 = Method1;
D2 d2 = d1;             //编译错误
```
#### 委托的兼容性 - 参数
*  当调用一个方法时，提供的参数可以比方法的参数定义更具体（同一个类或者是其子类）
*  委托可以接受比它的方法目标更具体的参数类型，这个叫ContraVariance。逆变
*  和泛型类型的参数一样，委托的Variance仅支持引用转换。
#### 委托的兼容性 - 参数
* 调用方法时，可以得到一个比请求的类型更具体的类型的返回结果
* 委托的目标方法可以返回比委托描述里更具体的类型的返回结果，Convariance