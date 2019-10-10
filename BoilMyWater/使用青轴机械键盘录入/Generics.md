# 泛型
#### 泛型的作用
* 跨类型可复用的代码：继承和泛型
* 继承—>基类
* 泛型—>带有"(类型)占位符"的"模板"
#### 泛型的类型
* 泛型会声明类型参数 - 泛型的消费者需要提供类型参数（argument来吧占位符类型填充上）
```
public class Stack<T>
{
    int position;
    T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];
}

var stack = new Stack<int>();
stack.Push(5);
stack.Push(10);
int x = stack.Pop();        // x is 10
int y = stack.Pop();        // y is 5
``` 
只有类型和方法可以引入类型参数，属性、索引器、事件、字段、构造函数、操作符等都不可以声明类型参数。但是他们可以使用他们所在的泛型类型的类型参数。
#### OpenType & ClosedType
* Stack\<T> OpenType(开放类型)
* Stack\<int> ClosedType(封闭类型)
* 在运行时，所有的泛型类型实例都是封闭的（占位符类型已经被填充了）
#### 泛型的约束
* where T : base-class 
* where T : interface
* where T : class
* where T : struct
* where T : new()
* where U : T
#### 泛型类型的子类
* 泛型class可以有子类，在子类里可以继续让父类的类型参数保持开放
```
class Stack<T>                      {...}
Class SpecialStack<T> : Stack<T>    {...}
```
* 在子类里也可以使用具体的类型来关闭父类的类型参数
```
Class IntStack<T> : Stack<Int>    {...}
```
* 子类型也可以引入新的类型参数
```
class List<T>                           {...}
Class KeyedList<T,Tkey> : List<T>       {...}
```