# Understanding delegates with C#

A delegate is similar to a function pointer in C or C++ except that delegates are type-safe. The term type-safe means that code is specified in a well-defined manner that can be recognized by a compiler. In this case it means that an incorrect use of a delegate is a compile-time error. This is quite different than in C++, where an incorrect use of a function pointer may not cause an error until the program is running.

Delegates allow you to write code that can dynamically change the methods that it calls.

A delegate contains a reference to a method rather than the method name.

By using delegates, you can invoke a method without knowing its name. Calling the delegate will actually execute the method referenced by the delegate.

To use a delegate, you must follow these steps:

First, define it using the reserved keyword delegate.
Second, instantiate it.
Third, write the implementation with the same return value and signature of your delegate.
Fig 1. Steps to use a delegate.



A delegate is similar to an interface. It specifies a contract between a caller and an implementer.

The following code shows how to define, create and call delegates, It creates an array of delegates with instances of delegates that refers to the methods that represent each arithmetic operation. We execute each delegate with a foreach keyword that iterates through this array.

Fig 2. Sample using delegates.



Using delegates is a solution much simpler than using function pointer.

Fig 3. Testing the program.



Fig 4. Another test.



Download source code
