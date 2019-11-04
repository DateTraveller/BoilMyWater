# Lambda表达式
#### 什么是Lambda表达式
* Lanbda表达式其实就是一个用来代替委托实例的未命名方法；
* 编译器会把lambda表达式转换为以下二者之一
    * 一个委托实例
    * 一个表达式树（expression tree），类型是Expression\<TDelegate>，它表示了可遍历的对象模型中Lambda表达式里面的代码。它允许Lambda表达式延迟到运行时再被解释。
