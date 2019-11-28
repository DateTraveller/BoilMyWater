# Lambda表达式
#### 什么是Lambda表达式
* Lanbda表达式其实就是一个用来代替委托实例的未命名方法；
* 编译器会把lambda表达式转换为以下二者之一
    * 一个委托实例
    * 一个表达式树（expression tree），类型是Expression\<TDelegate>，它表示了可遍历的对象模型中Lambda表达式里面的代码。它允许Lambda表达式延迟到运行时再被解释。
#### Lambda表达式的形式
* (parameters)=> expression-or-statement-block
* (参数)=>表达式或者语句块
* 其中如果只有一个参数并且类型可推断的话，那么参数的小括号可以省略
#### Lambda表达式与委托
* 每个Lambda表达式的参数对应委托的参数
* 表达式的类型对应委托的返回类型
#### Func和Action
* Lambda表达式通常与Func和Action委托一起使用
#### 被捕获的变量
* 被Lambda表达式引用的外部变量叫做被捕获的变量。
* 捕获了外部变量的Lambda表达式叫做闭包。
* 被捕获的变量是在委托被实际调用的时候才被计算，而不是在捕获的时候。
```
int factor=2;
Func<int,int> multiplier = n => n * factor;
factor=10;
Console.WriteLine(multiplier(3)); //30
```
* 被捕获的变量的生命周期会被延长到和委托一致 
* 在Lambda表达式内部实例化的本地变量对于委托实例的每次调用来说都是唯一的。
#### 捕获迭代变量
* 当捕获for循环的迭代变量时，C#会把这个变量当做是在循环外部定义的变量，这就意味着每次迭代捕获的都是同一个变量。
```
Action[] actions = new Action[3];
for(int i=0; i<3; i++)
    action[i] = () => Console.Write(i);
foreach(Action a in actions)
    a();            //333

//for循环捕获变量  最后i=3  于是Action里的i也为3
//foreach 输出  333
``` 
#### 匿名方法 vs Lambda表达式
* 匿名方法和Lambda表达式很像，但是缺少以下三个特性：
  * 隐式类型参数
  * 表达式语法（只能是语句块）
  * 编译表达式树的能力，通过赋值给Expression\<T>
