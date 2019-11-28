# 枚举和迭代器
#### 枚举器 enumeration
* 枚举器是一个只读的，作用于一序列值的、只能向前的游标。
* 枚举器是一个实现了下列任意一个接口的对象：
  * System.Collections.IEnumerator
  * System.Collections.Generic.IEnumerator\<T>
* 技术上来说任何一个含有名为MoveNext方法和名为Current的属性的对象，都被当做枚举器来对待。
* foreach语句会迭代可枚举的对象（enumerable object）。可枚举的对象是一序列值的逻辑表示。它本身不是游标，它是一个可以基于本身产生游标的对象。
#### 可枚举对象 enumerable object
* 一个可枚举对象可以是（下列任意一个）：
  * 实现了IEnumerable或者IEnumerable\<T>的对象
  * 有一个名为GetEnumerator的方法，并且该方法返回一个枚举器（enumerator）
* IEnumerator和IEnumerable是定义在System.Collections命名空间下的。
* IEnumerator\<T>和IEnumberable\<T>是定义在System.Collections.Generic命名空间下的。
#### 枚举模式 enumeration pattern
```
Class Enumerator //Typically implements IEnumerator or IEnumerator<T>
{
    public IteratorVariableType Current{get{...}}
    public bool MoveNext(){....}
}
```
```
class Enumerable //Typically implements IEnumerable or IEnumerable<T>
{
    public Enumerator GetEnumerator(){...}
}
```
* 例子
```
foreach(char c in "beer")
    Console.WriteLine(c);

using(var enumerator = "beer".GetEnumerator())
{
    while(enumerator.MoveNext())
    {
        var element=enumerator.Current;
        Console.WriteLine(element);
    }
}
```
* 注意：如果枚举器（enumerator）实现了IDisposable接口，那么foreach语句就会像using语句那样，隐式的dispose掉这个enumerator对象。

#### 迭代器 Iterators
* foreach语句是枚举器（enumerator）的消费者，而迭代器（iterator）是枚举器的生产者