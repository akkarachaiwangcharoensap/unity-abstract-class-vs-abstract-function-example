# unity-abstract-class-vs-abstract-function-example

An abstract class is a class that cannot be instantiated. Usually, when you have a subclass with "IS-A" relationship, it is a good idea to mark the parent as an "abstract".

An abstract function is a function that has no implementation. Think of interfaces, interfaces do not have the actual implementation. Instead, the implementation relies solely on the class that implemented the interface. The concept applies the same to the subclass that inherited the abstract function. The subclass will need its own implementation of the function.

The possible use case for the abstract function is when you are guarantee that each subclass will have completely different functionality to each other. Otherwise, consider a function with no abstraction.

https://www.youtube.com/watch?v=14LRVeku1rk
